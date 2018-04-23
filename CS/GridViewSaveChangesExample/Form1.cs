using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace GridViewSaveChangesExample {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            ColumnView view = (ColumnView)gridControl1.FocusedView;
            view.CloseEditor();
            if (view.UpdateCurrentRow())
                productsTableAdapter.Update(nwindDataSet.Products);
        }
    }
}