namespace WFCadastroProduto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip1 = new MenuStrip();
            menuCadastrar = new ToolStripMenuItem();
            menuListar = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            picImage = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCadastrar, menuListar, menuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(300, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            menuCadastrar.Name = "menuCadastrar";
            menuCadastrar.Size = new Size(69, 20);
            menuCadastrar.Text = "Cadastrar";
            menuCadastrar.Click += menuCadastrar_Click;
            // 
            // menuListar
            // 
            menuListar.Name = "menuListar";
            menuListar.Size = new Size(47, 20);
            menuListar.Text = "Listar";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(38, 20);
            menuSair.Text = "Sair";
            menuSair.Click += menuSair_Click;
            // 
            // picImage
            // 
            picImage.Dock = DockStyle.Fill;
            picImage.Image = (Image)resources.GetObject("picImage.Image");
            picImage.Location = new Point(0, 24);
            picImage.Name = "picImage";
            picImage.Size = new Size(300, 209);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 1;
            picImage.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 233);
            Controls.Add(picImage);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastrar;
        private ToolStripMenuItem menuListar;
        private ToolStripMenuItem menuSair;
        private PictureBox picImage;
    }
}