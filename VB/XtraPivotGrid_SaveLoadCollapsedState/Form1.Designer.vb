Namespace XtraPivotGrid_SaveLoadCollapsedState
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
            Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
            Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'fieldYear
            '
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "ShippedDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            '
            'fieldQuarter
            '
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            Me.fieldQuarter.FieldName = "ShippedDate"
            Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
            '
            'fieldMonth
            '
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldMonth.AreaIndex = 2
            Me.fieldMonth.Caption = "Month"
            Me.fieldMonth.FieldName = "ShippedDate"
            Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldMonth.Name = "fieldMonth"
            Me.fieldMonth.UnboundFieldName = "fieldMonth"
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear, Me.fieldProductName, Me.fieldProductSales, Me.fieldCategoryName, Me.fieldQuarter, Me.fieldMonth})
            PivotGridGroup1.Fields.Add(Me.fieldYear)
            PivotGridGroup1.Fields.Add(Me.fieldQuarter)
            PivotGridGroup1.Fields.Add(Me.fieldMonth)
            PivotGridGroup1.Hierarchy = Nothing
            PivotGridGroup1.ShowNewValues = True
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 41)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(719, 416)
            Me.pivotGridControl1.TabIndex = 0
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            '
            'fieldProductSales
            '
            Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductSales.AreaIndex = 0
            Me.fieldProductSales.Caption = "Sales"
            Me.fieldProductSales.FieldName = "ProductSales"
            Me.fieldProductSales.Name = "fieldProductSales"
            '
            'fieldCategoryName
            '
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(13, 12)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 23)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            '
            'btnLoad
            '
            Me.btnLoad.Location = New System.Drawing.Point(94, 12)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(75, 23)
            Me.btnLoad.TabIndex = 2
            Me.btnLoad.Text = "Load"
            '
            'btnClear
            '
            Me.btnClear.Location = New System.Drawing.Point(175, 12)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(75, 23)
            Me.btnClear.TabIndex = 3
            Me.btnClear.Text = "Clear"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(743, 469)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnLoad)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "RestoreLayoutExample"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

