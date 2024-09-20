namespace MercadinhoBem
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice });
            dgvProducts.Cursor = Cursors.Hand;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(702, 441);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 150;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Nome";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Preço";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 150;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 441);
            Controls.Add(dgvProducts);
            Name = "FormProducts";
            Text = "Produtos Disponíveis";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
    }
}