using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace dxKB17175 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1(checkEdit1.Checked ? FillDatasetFromGrid() : nwindDataSet, gridView1);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private DataSet FillDatasetFromGrid() {
            nwindDataSet ds = new nwindDataSet();
            int rowHandle;
            DataRow gridRow;
            for (int i = 0; i < gridView1.RowCount; i++) {
                rowHandle = gridView1.GetVisibleRowHandle(i);
                if (!gridView1.IsGroupRow(rowHandle)) {
                    gridRow = gridView1.GetDataRow(rowHandle);
                    ds.Tables[0].Rows.Add(gridRow.ItemArray);
                }
            }
            return ds;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1(checkEdit1.Checked ? FillDatasetFromGrid() : nwindDataSet, gridView1);
            ReportDesignTool designTool = new ReportDesignTool(report);
            designTool.ShowDesignerDialog();
        }
    }
}