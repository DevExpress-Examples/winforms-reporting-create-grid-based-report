Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace dxKB17175
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Dim report As XtraReport1
			If checkEdit1.Checked Then
				report = New XtraReport1(FillDatasetFromGrid(), gridView1)
			Else
				report = New XtraReport1(nwindDataSet, gridView1)
			End If
			report.ShowPreviewDialog()
		End Sub
		Private Function FillDatasetFromGrid() As DataSet
			Dim ds As New nwindDataSet()
			Dim rowHandle As Integer
			Dim gridRow As DataRow
			For i As Integer = 0 To gridView1.RowCount - 1
				rowHandle = gridView1.GetVisibleRowHandle(i)
				If (Not gridView1.IsGroupRow(rowHandle)) Then
					gridRow = gridView1.GetDataRow(rowHandle)
				   ds.Tables(0).Rows.Add(gridRow.ItemArray)
				End If
			Next i
			Return ds
		End Function
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report As XtraReport1
			If checkEdit1.Checked Then
				report = New XtraReport1(FillDatasetFromGrid(), gridView1)
			Else
				report = New XtraReport1(nwindDataSet, gridView1)
			End If
			report.ShowDesignerDialog()
		End Sub
	End Class

End Namespace