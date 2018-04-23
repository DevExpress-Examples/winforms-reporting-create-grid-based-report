using System;
using System.Data;
using System.Drawing;
using System.Collections;

using DevExpress.Data;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace dxKB17175
{
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }
        public XtraReport1(DataSet gridData, GridView gv) {
            InitializeComponent();
            ArrayList columnAL = new ArrayList();
            this.DataSource = gridData;
            this.DataMember = gridData.Tables[0].TableName;
            for(int i = gv.GroupCount-1; i >= 0; i--) 
                InsertGroupBand(gv.GroupedColumns[i],i);
              for(int i=0;i<gv.Columns.Count;i++)
                  if(gv.Columns[i].Visible && gv.Columns[i].GroupIndex < 0) {
                      columnAL.Add(gv.Columns[i].Caption);
                  }
              InitTables(columnAL);
        }

        private void InsertGroupBand(GridColumn gridColumn,int i)
        {
            GroupHeaderBand gb = new GroupHeaderBand();
            gb.Height = 25;
            gb.RepeatEveryPage = true;
            XRLabel l = new XRLabel();
            l.DataBindings.Add("Text", this.DataSource, gridColumn.Caption);
            l.Size = new Size(300, 25);
            l.Location = new Point(0 + i*20, 0);
            l.BackColor = Color.Beige;
            gb.Controls.Add(l);
            GroupField gf;
            if( gridColumn.SortOrder == ColumnSortOrder.Ascending )
                gf = new GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending);
            else
                gf = new GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending);
            gb.GroupFields.Add(gf);
            this.Bands.Add(gb);
        }
        public void InitTables(ArrayList columns) {

            int colCount = columns.Count;
            int pagewidth = (PageWidth - (Margins.Left + Margins.Right));
            int colWidth = pagewidth / colCount;
            
            XRTable table = new XRTable();
            XRTableRow row = new XRTableRow();
            XRTable table2 = new XRTable();
            XRTableRow row2 = new XRTableRow();
            
            for(int i = 0; i < colCount; i++) {
                XRTableCell cell = new XRTableCell();
                cell.Width = (int)colWidth;
                cell.Text = columns[i].ToString();
                row.Cells.Add(cell);

                XRTableCell cell2 = new XRTableCell();
                cell2.Width = (int)colWidth;
                cell2.DataBindings.Add("Text", null, columns[i].ToString());
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
