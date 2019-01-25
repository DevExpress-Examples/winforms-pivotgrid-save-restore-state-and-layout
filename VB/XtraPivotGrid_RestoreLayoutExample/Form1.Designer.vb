Namespace XtraPivotGrid_RestoreLayoutExample
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
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo10 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo11 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo12 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
			Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
			Me.fieldFirstName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName1, Me.fieldProductName1, Me.fieldSalesPerson1, Me.fieldExtendedPrice1})
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 41)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(727, 416)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "CategoryName"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Country"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "FirstName"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "LastName"
			fieldInfo4.Type = GetType(String)
			fieldInfo5.Name = "ProductName"
			fieldInfo5.Type = GetType(String)
			fieldInfo6.Name = "Sales Person"
			fieldInfo6.Type = GetType(String)
			fieldInfo7.Name = "OrderDate"
			fieldInfo7.Type = GetType(Date)
			fieldInfo8.Name = "OrderID"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "Quantity"
			fieldInfo9.Type = GetType(Double)
			fieldInfo10.Name = "Discount"
			fieldInfo10.Type = GetType(Double)
			fieldInfo11.Name = "Extended Price"
			fieldInfo11.Type = GetType(Double)
			fieldInfo12.Name = "UnitPrice"
			fieldInfo12.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10, fieldInfo11, fieldInfo12})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Data"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.excelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' btnSave
			' 
			Me.btnSave.Location = New System.Drawing.Point(13, 12)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(75, 23)
			Me.btnSave.TabIndex = 1
			Me.btnSave.Text = "Save"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			' 
			' btnLoad
			' 
			Me.btnLoad.Location = New System.Drawing.Point(94, 12)
			Me.btnLoad.Name = "btnLoad"
			Me.btnLoad.Size = New System.Drawing.Size(75, 23)
			Me.btnLoad.TabIndex = 2
			Me.btnLoad.Text = "Load"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			' 
			' fieldFirstName1
			' 
			Me.fieldFirstName1.AreaIndex = 0
			Me.fieldFirstName1.Caption = "First Name"
			Me.fieldFirstName1.FieldName = "FirstName"
			Me.fieldFirstName1.Name = "fieldFirstName1"
			' 
			' btnClear
			' 
			Me.btnClear.Location = New System.Drawing.Point(175, 12)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New System.Drawing.Size(75, 23)
			Me.btnClear.TabIndex = 3
			Me.btnClear.Text = "Clear"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 1
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson1.AreaIndex = 0
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(751, 469)
			Me.Controls.Add(Me.btnClear)
			Me.Controls.Add(Me.btnLoad)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "RestoreLayoutExample"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private fieldFirstName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

