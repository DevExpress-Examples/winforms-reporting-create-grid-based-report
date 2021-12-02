using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.Collections;
using System.Drawing;
namespace ConvertGridToReportExample
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public XtraReport1(object dSource, string dMember, GridView gView)
        {
            InitializeComponent();
            ArrayList columnArrayList = new ArrayList();
            this.DataSource = dSource;
            this.DataMember = dMember;
            for (int i = gView.GroupCount - 1; i >= 0; i--)
                InsertGroupBand(gView.GroupedColumns[i], i);
            for (int i = 0; i < gView.Columns.Count; i++)
                if (gView.Columns[i].Visible && gView.Columns[i].GroupIndex < 0)
                {
                    columnArrayList.Add(gView.Columns[i].Caption);
                }
            InitTables(columnArrayList);
        }

        private void InsertGroupBand(GridColumn gridColumn, int i)
        {
            GroupHeaderBand ghBand = new GroupHeaderBand();
            ghBand.Height = 25;
            ghBand.RepeatEveryPage = true;
            XRLabel lbl = new XRLabel();
            lbl.ExpressionBindings.Add(new ExpressionBinding("Text", gridColumn.Caption));
            lbl.Size = new Size(300, 25);
            lbl.Location = new Point(0 + i * 20, 0);
            lbl.BackColor = Color.Beige;
            ghBand.Controls.Add(lbl);
            GroupField gField;
            if (gridColumn.SortOrder == ColumnSortOrder.Ascending)
                gField = new GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending);
            else
                gField = new GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending);
            ghBand.GroupFields.Add(gField);
            this.Bands.Add(ghBand);
        }
        public void InitTables(ArrayList columns)
        {
            int colCount = columns.Count;
            int pagewidth = (PageWidth - (Margins.Left + Margins.Right));
            int colWidth = pagewidth / colCount;

            XRTable table = new XRTable();
            XRTableRow row = new XRTableRow();
            XRTable table2 = new XRTable();
            XRTableRow row2 = new XRTableRow();

            for (int i = 0; i < colCount; i++)
            {
                XRTableCell cell = new XRTableCell();
                cell.Width = (int)colWidth;
                cell.Text = columns[i].ToString();
                row.Cells.Add(cell);

                XRTableCell cell2 = new XRTableCell();
                cell2.Width = (int)colWidth;
                cell2.ExpressionBindings.Add(new ExpressionBinding("Text", columns[i].ToString()));
                row2.Cells.Add(cell2);
            }
            table.Rows.Add(row);
            table.Width = pagewidth;
            table.Borders = BorderSide.Bottom;

            table2.Rows.Add(row2);
            table2.Width = pagewidth;

            Bands[BandKind.PageHeader].Controls.Add(table);
            Bands[BandKind.Detail].Controls.Add(table2);
        }

    }
}
