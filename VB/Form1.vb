Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

' ...
Namespace dxKB17175

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1(If(checkEdit1.Checked, FillDatasetFromGrid(), nwindDataSet), gridView1)
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub

        Private Function FillDatasetFromGrid() As DataSet
            Dim ds As nwindDataSet = New nwindDataSet()
            Dim rowHandle As Integer
            Dim gridRow As DataRow
            For i As Integer = 0 To gridView1.RowCount - 1
                rowHandle = gridView1.GetVisibleRowHandle(i)
                If Not gridView1.IsGroupRow(rowHandle) Then
                    gridRow = gridView1.GetDataRow(rowHandle)
                    ds.Tables(CInt(0)).Rows.Add(gridRow.ItemArray)
                End If
            Next

            Return ds
        End Function

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            customersTableAdapter.Fill(nwindDataSet.Customers)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1(If(checkEdit1.Checked, FillDatasetFromGrid(), nwindDataSet), gridView1)
            Dim designTool As ReportDesignTool = New ReportDesignTool(report)
            designTool.ShowDesignerDialog()
        End Sub
    End Class
End Namespace
