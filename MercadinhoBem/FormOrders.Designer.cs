namespace MercadinhoBem
{
    partial class FormOrders
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOrders = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colState = new DataGridViewTextBoxColumn();
            colPagamento = new DataGridViewTextBoxColumn();
            menu = new MenuStrip();
            menuCriarPedido = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToOrderColumns = true;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colId, colData, colTotalAmount, colState, colPagamento });
            dgvOrders.Cursor = Cursors.Hand;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 33);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1250, 569);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
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
            // colData
            // 
            colData.DataPropertyName = "Data";
            colData.HeaderText = "Data";
            colData.MinimumWidth = 8;
            colData.Name = "colData";
            colData.ReadOnly = true;
            colData.Width = 200;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            colTotalAmount.HeaderText = "Total";
            colTotalAmount.MinimumWidth = 8;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            colTotalAmount.Width = 150;
            // 
            // colState
            // 
            colState.DataPropertyName = "StateDescription";
            colState.HeaderText = "Status";
            colState.MinimumWidth = 8;
            colState.Name = "colState";
            colState.ReadOnly = true;
            colState.Width = 300;
            // 
            // colPagamento
            // 
            colPagamento.DataPropertyName = "PaymentDescription";
            colPagamento.HeaderText = "Pagamento";
            colPagamento.MinimumWidth = 8;
            colPagamento.Name = "colPagamento";
            colPagamento.ReadOnly = true;
            colPagamento.Width = 300;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { menuCriarPedido });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1250, 33);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // menuCriarPedido
            // 
            menuCriarPedido.Name = "menuCriarPedido";
            menuCriarPedido.Size = new Size(124, 29);
            menuCriarPedido.Text = "Criar Pedido";
            menuCriarPedido.Click += menuCriarPedido_Click;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 602);
            Controls.Add(dgvOrders);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "FormOrders";
            Text = "Pedidos (Mercadinho Bem)";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private MenuStrip menu;
        private ToolStripMenuItem menuCriarPedido;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colState;
        private DataGridViewTextBoxColumn colPagamento;
    }
}
