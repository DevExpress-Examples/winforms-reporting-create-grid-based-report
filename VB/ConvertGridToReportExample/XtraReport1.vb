Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Collections
Imports System.Drawing
Namespace ConvertGridToReportExample
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal dSource As Object, ByVal dMember As String, ByVal gView As GridView)
			InitializeComponent()
			Dim columnArrayList As New ArrayList()
			Me.DataSource = dSource
			Me.DataMember = dMember
			For i As Integer = gView.GroupCount - 1 To 0 Step -1
				InsertGroupBand(gView.GroupedColumns(i), i)
			Next i
			For i As Integer = 0 To gView.Columns.Count - 1
				If gView.Columns(i).Visible AndAlso gView.Columns(i).GroupIndex < 0 Then
					columnArrayList.Add(gView.Columns(i).Caption)
				End If
			Next i
			InitTables(columnArrayList)
		End Sub

		Private Sub InsertGroupBand(ByVal gridColumn As GridColumn, ByVal i As Integer)
			Dim ghBand As New GroupHeaderBand()
			ghBand.Height = 25
			ghBand.RepeatEveryPage = True
			Dim lbl As New XRLabel()
			lbl.ExpressionBindings.Add(New ExpressionBinding("Text", gridColumn.Caption))
			lbl.Size = New Size(300, 25)
			lbl.Location = New Point(0 + i * 20, 0)
			lbl.BackColor = Color.Beige
			ghBand.Controls.Add(lbl)
			Dim gField As GroupField
			If gridColumn.SortOrder = ColumnSortOrder.Ascending Then
				gField = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending)
			Else
				gField = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending)
			End If
			ghBand.GroupFields.Add(gField)
			Me.Bands.Add(ghBand)
		End Sub
		Public Sub InitTables(ByVal columns As ArrayList)
			Dim colCount As Integer = columns.Count
'INSTANT VB NOTE: The variable pagewidth was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim pagewidth_Renamed As Integer = (PageWidth - (Margins.Left + Margins.Right))
			Dim colWidth As Integer = pagewidth_Renamed \ colCount

			Dim table As New XRTable()
			Dim row As New XRTableRow()
			Dim table2 As New XRTable()
			Dim row2 As New XRTableRow()

			For i As Integer = 0 To colCount - 1
				Dim cell As New XRTableCell()
				cell.Width = CInt(colWidth)
				cell.Text = columns(i).ToString()
				row.Cells.Add(cell)

				Dim cell2 As New XRTableCell()
				cell2.Width = CInt(colWidth)
				cell2.ExpressionBindings.Add(New ExpressionBinding("Text", columns(i).ToString()))
				row2.Cells.Add(cell2)
			Next i
			table.Rows.Add(row)
			table.Width = pagewidth_Renamed
			table.Borders = BorderSide.Bottom

			table2.Rows.Add(row2)
			table2.Width = pagewidth_Renamed

			Bands(BandKind.PageHeader).Controls.Add(table)
			Bands(BandKind.Detail).Controls.Add(table2)
		End Sub

	End Class
End Namespace
