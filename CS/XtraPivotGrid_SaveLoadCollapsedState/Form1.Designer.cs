namespace XtraPivotGrid_SaveLoadCollapsedState {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "ShippedDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "ShippedDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            // 
            // fieldMonth
            // 
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 2;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "ShippedDate";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYear,
            this.fieldProductName,
            this.fieldProductSales,
            this.fieldCategoryName,
            this.fieldQuarter,
            this.fieldMonth});
            pivotGridGroup3.Fields.Add(this.fieldYear);
            pivotGridGroup3.Fields.Add(this.fieldQuarter);
            pivotGridGroup3.Fields.Add(this.fieldMonth);
            pivotGridGroup3.Hierarchy = null;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup3});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 41);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(719, 416);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "Sales";
            this.fieldProductSales.FieldName = "ProductSales";
            this.fieldProductSales.Name = "fieldProductSales";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(94, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(175, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 469);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "RestoreLayoutExample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}

