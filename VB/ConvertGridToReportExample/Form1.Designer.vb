Namespace ConvertGridToReportExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery3 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column21 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression21 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column22 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression22 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column23 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression23 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column24 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression24 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column25 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression25 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column26 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression26 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column27 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression27 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column28 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression28 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column29 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression29 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column30 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression30 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
			Me.skinDropDownButtonItem = New DevExpress.XtraBars.SkinDropDownButtonItem()
			Me.skinPaletteRibbonGalleryBarItem = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
			Me.btnShowPreview = New DevExpress.XtraBars.BarButtonItem()
			Me.btnShowReportDesigner = New DevExpress.XtraBars.BarButtonItem()
			Me.chkOnlyExpRecords = New DevExpress.XtraBars.BarCheckItem()
			Me.btnReportGeneratorPreview = New DevExpress.XtraBars.BarButtonItem()
			Me.btnReportGeneratorDesigner = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgSkins = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			DirectCast(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl
			' 
			Me.gridControl.DataMember = "Query"
			Me.gridControl.DataSource = Me.sqlDataSource1
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.Location = New System.Drawing.Point(0, 158)
			Me.gridControl.MainView = Me.gridView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.Size = New System.Drawing.Size(905, 333)
			Me.gridControl.TabIndex = 0
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression21.ColumnName = "CustomerID"
			table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""283"" />"
			table3.Name = "Customers"
			columnExpression21.Table = table3
			column21.Expression = columnExpression21
			columnExpression22.ColumnName = "CompanyName"
			columnExpression22.Table = table3
			column22.Expression = columnExpression22
			columnExpression23.ColumnName = "ContactName"
			columnExpression23.Table = table3
			column23.Expression = columnExpression23
			columnExpression24.ColumnName = "ContactTitle"
			columnExpression24.Table = table3
			column24.Expression = columnExpression24
			columnExpression25.ColumnName = "Address"
			columnExpression25.Table = table3
			column25.Expression = columnExpression25
			columnExpression26.ColumnName = "City"
			columnExpression26.Table = table3
			column26.Expression = columnExpression26
			columnExpression27.ColumnName = "Region"
			columnExpression27.Table = table3
			column27.Expression = columnExpression27
			columnExpression28.ColumnName = "PostalCode"
			columnExpression28.Table = table3
			column28.Expression = columnExpression28
			columnExpression29.ColumnName = "Country"
			columnExpression29.Table = table3
			column29.Expression = columnExpression29
			columnExpression30.ColumnName = "Phone"
			columnExpression30.Table = table3
			column30.Expression = columnExpression30
			selectQuery3.Columns.Add(column21)
			selectQuery3.Columns.Add(column22)
			selectQuery3.Columns.Add(column23)
			selectQuery3.Columns.Add(column24)
			selectQuery3.Columns.Add(column25)
			selectQuery3.Columns.Add(column26)
			selectQuery3.Columns.Add(column27)
			selectQuery3.Columns.Add(column28)
			selectQuery3.Columns.Add(column29)
			selectQuery3.Columns.Add(column30)
			selectQuery3.Name = "Query"
			selectQuery3.Tables.Add(table3)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery3})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' gridView
			' 
			Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone})
			Me.gridView.GridControl = Me.gridControl
			Me.gridView.GroupCount = 1
			Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
			Me.gridView.Name = "gridView"
			Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCountry, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			' 
			' colCompanyName
			' 
			Me.colCompanyName.Caption = "CompanyName"
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Visible = True
			Me.colCompanyName.VisibleIndex = 0
			' 
			' colContactName
			' 
			Me.colContactName.Caption = "ContactName"
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.VisibleIndex = 1
			' 
			' colContactTitle
			' 
			Me.colContactTitle.Caption = "ContactTitle"
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			' 
			' colAddress
			' 
			Me.colAddress.Caption = "Address"
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 2
			' 
			' colCity
			' 
			Me.colCity.Caption = "City"
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 3
			' 
			' colRegion
			' 
			Me.colRegion.Caption = "Region"
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			' 
			' colPostalCode
			' 
			Me.colPostalCode.Caption = "PostalCode"
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			' 
			' colCountry
			' 
			Me.colCountry.Caption = "Country"
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 4
			' 
			' colPhone
			' 
			Me.colPhone.Caption = "Phone"
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			' 
			' ribbonControl
			' 
			Me.ribbonControl.ExpandCollapseItem.Id = 0
			Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.skinRibbonGalleryBarItem, Me.skinDropDownButtonItem, Me.skinPaletteRibbonGalleryBarItem, Me.btnShowPreview, Me.btnShowReportDesigner, Me.chkOnlyExpRecords, Me.btnReportGeneratorPreview, Me.btnReportGeneratorDesigner})
			Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl.MaxItemId = 7
			Me.ribbonControl.Name = "ribbonControl"
			Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage})
			Me.ribbonControl.Size = New System.Drawing.Size(905, 158)
			' 
			' skinRibbonGalleryBarItem
			' 
			Me.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem"
			Me.skinRibbonGalleryBarItem.Id = 1
			Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
			' 
			' skinDropDownButtonItem
			' 
			Me.skinDropDownButtonItem.Id = 2
			Me.skinDropDownButtonItem.Name = "skinDropDownButtonItem"
			' 
			' skinPaletteRibbonGalleryBarItem
			' 
			Me.skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem"
			Me.skinPaletteRibbonGalleryBarItem.Id = 3
			Me.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem"
			' 
			' btnShowPreview
			' 
			Me.btnShowPreview.Caption = "Show Preview"
			Me.btnShowPreview.Id = 2
			Me.btnShowPreview.Name = "btnShowPreview"
			' 
			' btnShowReportDesigner
			' 
			Me.btnShowReportDesigner.Caption = "Show Report Designer"
			Me.btnShowReportDesigner.Id = 3
			Me.btnShowReportDesigner.Name = "btnShowReportDesigner"
			' 
			' chkOnlyExpRecords
			' 
			Me.chkOnlyExpRecords.Caption = "Only expanded records"
			Me.chkOnlyExpRecords.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText
			Me.chkOnlyExpRecords.Id = 4
			Me.chkOnlyExpRecords.Name = "chkOnlyExpRecords"
			' 
			' btnReportGeneratorPreview
			' 
			Me.btnReportGeneratorPreview.Caption = "Show Preview"
			Me.btnReportGeneratorPreview.Id = 5
			Me.btnReportGeneratorPreview.Name = "btnReportGeneratorPreview"
			' 
			' btnReportGeneratorDesigner
			' 
			Me.btnReportGeneratorDesigner.Caption = "Show Report Designer"
			Me.btnReportGeneratorDesigner.Id = 6
			Me.btnReportGeneratorDesigner.Name = "btnReportGeneratorDesigner"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Grid to Report"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.AllowTextClipping = False
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnShowPreview)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnShowReportDesigner)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.chkOnlyExpRecords)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "DataTable Conversion"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.AllowTextClipping = False
			Me.ribbonPageGroup2.ItemLinks.Add(Me.btnReportGeneratorPreview)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.btnReportGeneratorDesigner)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "ReportGenerator Conversion"
			' 
			' ribbonPage
			' 
			Me.ribbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgSkins})
			Me.ribbonPage.Name = "ribbonPage"
			Me.ribbonPage.Text = "Appearance"
			' 
			' rpgSkins
			' 
			Me.rpgSkins.ItemLinks.Add(Me.skinDropDownButtonItem)
			Me.rpgSkins.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem)
			Me.rpgSkins.Name = "rpgSkins"
			Me.rpgSkins.Text = "Skins"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(905, 491)
			Me.Controls.Add(Me.gridControl)
			Me.Controls.Add(Me.ribbonControl)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl
			Me.Text = "Convert Grid to Report "
			DirectCast(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl As DevExpress.XtraGrid.GridControl
		Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpgSkins As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
		Private skinDropDownButtonItem As DevExpress.XtraBars.SkinDropDownButtonItem
		Private skinPaletteRibbonGalleryBarItem As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
		Private WithEvents btnShowPreview As DevExpress.XtraBars.BarButtonItem
		Private WithEvents btnShowReportDesigner As DevExpress.XtraBars.BarButtonItem
		Private chkOnlyExpRecords As DevExpress.XtraBars.BarCheckItem
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents btnReportGeneratorPreview As DevExpress.XtraBars.BarButtonItem
		Private WithEvents btnReportGeneratorDesigner As DevExpress.XtraBars.BarButtonItem
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	End Class
End Namespace
