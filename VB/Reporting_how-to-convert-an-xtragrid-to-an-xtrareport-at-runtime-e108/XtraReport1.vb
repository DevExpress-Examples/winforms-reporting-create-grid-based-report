Imports System
Imports System.Data
Imports System.Drawing
Imports System.Collections

Imports DevExpress.Data
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace dxKB17175
    Partial Public Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal gridData As DataSet, ByVal gv As GridView)
            InitializeComponent()
            Dim columnAL As New ArrayList()
            Me.DataSource = gridData
            Me.DataMember = gridData.Tables(0).TableName
            For i As Integer = gv.GroupCount-1 To 0 Step -1
                InsertGroupBand(gv.GroupedColumns(i),i)
            Next i
              For i As Integer = 0 To gv.Columns.Count - 1
                  If gv.Columns(i).Visible AndAlso gv.Columns(i).GroupIndex < 0 Then
                      columnAL.Add(gv.Columns(i).Caption)
                  End If
              Next i
              InitTables(columnAL)
        End Sub

        Private Sub InsertGroupBand(ByVal gridColumn As GridColumn, ByVal i As Integer)
            Dim gb As New GroupHeaderBand()
            gb.Height = 25
            gb.RepeatEveryPage = True
            Dim l As New XRLabel()
            l.DataBindings.Add("Text", Me.DataSource, gridColumn.Caption)
            l.Size = New Size(300, 25)
            l.Location = New Point(0 + i*20, 0)
            l.BackColor = Color.Beige
            gb.Controls.Add(l)
            Dim gf As GroupField
            If gridColumn.SortOrder = ColumnSortOrder.Ascending Then
                gf = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending)
            Else
                gf = New GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending)
            End If
            gb.GroupFields.Add(gf)
            Me.Bands.Add(gb)
        End Sub
        Public Sub InitTables(ByVal columns As ArrayList)

            Dim colCount As Integer = columns.Count

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
                cell2.DataBindings.Add("Text", Nothing, columns(i).ToString())
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
