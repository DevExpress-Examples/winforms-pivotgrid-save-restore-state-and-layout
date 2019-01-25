using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;

namespace XtraPivotGrid_SaveLoadCollapsedState {
    public partial class Form1 : Form {
        MemoryStream layoutStream = new MemoryStream();
        MemoryStream collapseStateStream = new MemoryStream();
        public Form1() {
            InitializeComponent();
            btnClear.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e) {
            nwindDataSetTableAdapters.ProductReportsTableAdapter adapter =
                new nwindDataSetTableAdapters.ProductReportsTableAdapter();
            pivotGridControl1.DataSource = adapter.GetData();
        }
        private void btnSave_Click(object sender, EventArgs e) {
            if (pivotGridControl1.Fields.Count > 0)
            {
                layoutStream.Dispose();
                layoutStream = new MemoryStream();
                pivotGridControl1.SaveLayoutToStream(layoutStream, OptionsLayoutBase.FullLayout);
                collapseStateStream.Dispose();
                collapseStateStream = new MemoryStream();
                pivotGridControl1.SaveCollapsedStateToStream(collapseStateStream);
                btnClear.Enabled = true;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e) {
            if (layoutStream.Length > 0 && collapseStateStream.Length > 0)
            {
                layoutStream.Seek(0, SeekOrigin.Begin);
                pivotGridControl1.RestoreLayoutFromStream(layoutStream, OptionsLayoutBase.FullLayout);
                collapseStateStream.Seek(0, SeekOrigin.Begin);
                pivotGridControl1.LoadCollapsedStateFromStream(collapseStateStream);
            }
        }
        private void btnClear_Click(object sender, EventArgs e) {
            if (layoutStream.Length > 0 && collapseStateStream.Length > 0)
                pivotGridControl1.Fields.Clear();
        }
    }
}