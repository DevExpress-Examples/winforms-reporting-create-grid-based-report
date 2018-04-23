Imports Microsoft.VisualBasic
Imports System
Namespace dxKB17175
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New dxKB17175.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.customersTableAdapter = New dxKB17175.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customersBindingSource
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(708, 255)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCompanyName, Me.colContactName, Me.colAddress, Me.colCity, Me.colRegion, Me.colCountry, Me.colPhone, Me.colCustomerID, Me.colContactTitle, Me.colPostalCode, Me.colFax})
			Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(568, 271, 208, 189)
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
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
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			' 
			' colContactTitle
			' 
			Me.colContactTitle.Caption = "ContactTitle"
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			' 
			' colPostalCode
			' 
			Me.colPostalCode.Caption = "PostalCode"
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			' 
			' colFax
			' 
			Me.colFax.Caption = "Fax"
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(504, 273)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(84, 23)
			Me.simpleButton2.TabIndex = 3
			Me.simpleButton2.Text = "Show Preview"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(594, 273)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(124, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Show Report Designer"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(332, 273)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Show expanded records only"
			Me.checkEdit1.Size = New System.Drawing.Size(166, 19)
			Me.checkEdit1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(733, 308)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As dxKB17175.nwindDataSetTableAdapters.CustomersTableAdapter
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colFax As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

