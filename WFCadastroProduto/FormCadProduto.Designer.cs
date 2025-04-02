namespace WFCadastroProduto
{
    partial class FormCadProduto
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
            lblCodigo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            gbxStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblPreco = new Label();
            nudPreco = new NumericUpDown();
            nudQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            btnSalvar = new Button();
            mskCodigo = new MaskedTextBox();
            gbxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 11);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(21, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 129);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(287, 23);
            txtNome.TabIndex = 2;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Location = new Point(166, 11);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(144, 96);
            gbxStatus.TabIndex = 4;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(23, 56);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(24, 24);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(23, 177);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(85, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço Unitário:";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(25, 202);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 6;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(189, 202);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(187, 177);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(234, 263);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mskCodigo
            // 
            mskCodigo.Enabled = false;
            mskCodigo.Location = new Point(25, 34);
            mskCodigo.Mask = "0000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(100, 23);
            mskCodigo.TabIndex = 10;
            mskCodigo.ValidatingType = typeof(int);
            // 
            // FormCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 314);
            Controls.Add(mskCodigo);
            Controls.Add(btnSalvar);
            Controls.Add(nudQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(nudPreco);
            Controls.Add(lblPreco);
            Controls.Add(gbxStatus);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += FormCadProduto_Load;
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gbxStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblPreco;
        private NumericUpDown nudPreco;
        private NumericUpDown nudQuantidade;
        private Label lblQuantidade;
        private Button btnSalvar;
        private MaskedTextBox mskCodigo;
    }
}