namespace MercadinhoBem
{
    partial class FormOrder
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
            txtId = new TextBox();
            lblId = new Label();
            lblTotal = new Label();
            txtTotalAmount = new TextBox();
            dgvOrderItems = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblState = new Label();
            txtState = new TextBox();
            btnCancelar = new Button();
            btnNext = new Button();
            lblPagamento = new Label();
            cbPagamento = new ComboBox();
            lblData = new Label();
            txtData = new TextBox();
            cbCustomers = new ComboBox();
            lblCustomer = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(9, 44);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 31);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(9, 16);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(761, 16);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(761, 44);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(160, 31);
            txtTotalAmount.TabIndex = 3;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { colProductName, colQuantity, colSubtotal });
            dgvOrderItems.Cursor = Cursors.Hand;
            dgvOrderItems.Location = new Point(9, 169);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new Size(1214, 313);
            dgvOrderItems.TabIndex = 6;
            dgvOrderItems.DoubleClick += dgvOrderItems_DoubleClick;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Produto";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 150;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Quantidade";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 150;
            // 
            // colSubtotal
            // 
            colSubtotal.DataPropertyName = "Total";
            colSubtotal.HeaderText = "Subtotal (R$)";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(432, 25);
            label1.TabIndex = 7;
            label1.Text = "Clique duas vezes na grid para adicionar um produto";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(140, 16);
            lblState.Name = "lblState";
            lblState.Size = new Size(60, 25);
            lblState.TabIndex = 9;
            lblState.Text = "Status";
            // 
            // txtState
            // 
            txtState.Location = new Point(140, 44);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(355, 31);
            txtState.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(797, 498);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Location = new Point(927, 498);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(274, 34);
            btnNext.TabIndex = 11;
            btnNext.Text = "Próximo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Location = new Point(940, 11);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(102, 25);
            lblPagamento.TabIndex = 12;
            lblPagamento.Text = "Pagamento";
            // 
            // cbPagamento
            // 
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Items.AddRange(new object[] { "Pix", "Cartão de Crédito" });
            cbPagamento.Location = new Point(940, 44);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(274, 33);
            cbPagamento.TabIndex = 13;
            cbPagamento.SelectedIndexChanged += cbPagamento_SelectedIndexChanged;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(527, 16);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 25);
            lblData.TabIndex = 15;
            lblData.Text = "Data";
            // 
            // txtData
            // 
            txtData.Location = new Point(527, 44);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(207, 31);
            txtData.TabIndex = 14;
            // 
            // cbCustomers
            // 
            cbCustomers.Cursor = Cursors.Hand;
            cbCustomers.DisplayMember = "Name";
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Items.AddRange(new object[] { "Pix", "Cartão de Crédito" });
            cbCustomers.Location = new Point(940, 120);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(274, 33);
            cbCustomers.TabIndex = 17;
            cbCustomers.ValueMember = "Email";
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(940, 87);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(65, 25);
            lblCustomer.TabIndex = 16;
            lblCustomer.Text = "Cliente";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 556);
            Controls.Add(cbCustomers);
            Controls.Add(lblCustomer);
            Controls.Add(lblData);
            Controls.Add(txtData);
            Controls.Add(cbPagamento);
            Controls.Add(lblPagamento);
            Controls.Add(btnNext);
            Controls.Add(btnCancelar);
            Controls.Add(lblState);
            Controls.Add(txtState);
            Controls.Add(label1);
            Controls.Add(dgvOrderItems);
            Controls.Add(lblTotal);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "FormOrder";
            Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label lblTotal;
        private TextBox txtTotalAmount;
        private DataGridView dgvOrderItems;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colSubtotal;
        private Label label1;
        private Label lblState;
        private TextBox txtState;
        private Button btnCancelar;
        private Button btnNext;
        private Label lblPagamento;
        private ComboBox cbPagamento;
        private Label lblData;
        private TextBox txtData;
        private ComboBox cbCustomers;
        private Label lblCustomer;
    }
}