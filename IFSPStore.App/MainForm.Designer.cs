namespace IFSPStore.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            btnFuncionario = new ReaLTaiizor.Controls.MaterialButton();
            btnCategoria = new ReaLTaiizor.Controls.MaterialButton();
            btnCarro = new ReaLTaiizor.Controls.MaterialButton();
            btnCidade = new ReaLTaiizor.Controls.MaterialButton();
            btnCliente = new ReaLTaiizor.Controls.MaterialButton();
            btnLocacao = new ReaLTaiizor.Controls.MaterialButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1012, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(60, 20);
            helpToolStripMenuItem.Text = "Suporte";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(97, 20);
            closeToolStripMenuItem.Text = "Fechar registro";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser });
            statusStrip1.Location = new Point(3, 603);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1012, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(53, 17);
            lblUser.Text = "Usuario: ";
            // 
            // btnFuncionario
            // 
            btnFuncionario.AutoSize = false;
            btnFuncionario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFuncionario.BackColor = Color.ForestGreen;
            btnFuncionario.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFuncionario.Depth = 0;
            btnFuncionario.ForeColor = SystemColors.ActiveCaptionText;
            btnFuncionario.HighEmphasis = true;
            btnFuncionario.Icon = null;
            btnFuncionario.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnFuncionario.Location = new Point(17, 109);
            btnFuncionario.Margin = new Padding(4, 6, 4, 6);
            btnFuncionario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.NoAccentTextColor = Color.Empty;
            btnFuncionario.Size = new Size(158, 36);
            btnFuncionario.TabIndex = 10;
            btnFuncionario.Text = "Registro de funcionario";
            btnFuncionario.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFuncionario.UseAccentColor = false;
            btnFuncionario.UseMnemonic = false;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.AutoSize = false;
            btnCategoria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCategoria.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCategoria.Depth = 0;
            btnCategoria.HighEmphasis = true;
            btnCategoria.Icon = null;
            btnCategoria.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCategoria.Location = new Point(17, 253);
            btnCategoria.Margin = new Padding(4, 6, 4, 6);
            btnCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCategoria.Name = "btnCategoria";
            btnCategoria.NoAccentTextColor = Color.Empty;
            btnCategoria.Size = new Size(158, 36);
            btnCategoria.TabIndex = 11;
            btnCategoria.Text = "Registro de Categoria";
            btnCategoria.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCategoria.UseAccentColor = false;
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnCarro
            // 
            btnCarro.AutoSize = false;
            btnCarro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarro.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarro.Depth = 0;
            btnCarro.HighEmphasis = true;
            btnCarro.Icon = null;
            btnCarro.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCarro.Location = new Point(17, 301);
            btnCarro.Margin = new Padding(4, 6, 4, 6);
            btnCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCarro.Name = "btnCarro";
            btnCarro.NoAccentTextColor = Color.Empty;
            btnCarro.Size = new Size(158, 36);
            btnCarro.TabIndex = 12;
            btnCarro.Text = "Registro de Carro";
            btnCarro.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarro.UseAccentColor = false;
            btnCarro.UseVisualStyleBackColor = true;
            btnCarro.Click += btnCarro_Click;
            // 
            // btnCidade
            // 
            btnCidade.AutoSize = false;
            btnCidade.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCidade.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCidade.Depth = 0;
            btnCidade.HighEmphasis = true;
            btnCidade.Icon = null;
            btnCidade.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCidade.Location = new Point(17, 205);
            btnCidade.Margin = new Padding(4, 6, 4, 6);
            btnCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCidade.Name = "btnCidade";
            btnCidade.NoAccentTextColor = Color.Empty;
            btnCidade.Size = new Size(158, 36);
            btnCidade.TabIndex = 13;
            btnCidade.Text = "Registro de cidade";
            btnCidade.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCidade.UseAccentColor = false;
            btnCidade.UseVisualStyleBackColor = true;
            btnCidade.Click += btnCidade_Click;
            // 
            // btnCliente
            // 
            btnCliente.AutoSize = false;
            btnCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCliente.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCliente.Depth = 0;
            btnCliente.HighEmphasis = true;
            btnCliente.Icon = null;
            btnCliente.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCliente.Location = new Point(17, 157);
            btnCliente.Margin = new Padding(4, 6, 4, 6);
            btnCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCliente.Name = "btnCliente";
            btnCliente.NoAccentTextColor = Color.Empty;
            btnCliente.Size = new Size(158, 36);
            btnCliente.TabIndex = 14;
            btnCliente.Text = "Registro de cliente";
            btnCliente.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCliente.UseAccentColor = false;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnLocacao
            // 
            btnLocacao.AutoSize = false;
            btnLocacao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLocacao.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLocacao.Depth = 0;
            btnLocacao.HighEmphasis = true;
            btnLocacao.Icon = null;
            btnLocacao.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLocacao.Location = new Point(17, 349);
            btnLocacao.Margin = new Padding(4, 6, 4, 6);
            btnLocacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLocacao.Name = "btnLocacao";
            btnLocacao.NoAccentTextColor = Color.Empty;
            btnLocacao.Size = new Size(158, 36);
            btnLocacao.TabIndex = 15;
            btnLocacao.Text = "Registro de locação";
            btnLocacao.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLocacao.UseAccentColor = false;
            btnLocacao.UseVisualStyleBackColor = true;
            btnLocacao.Click += btnAluguel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.LightGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 628);
            Controls.Add(btnLocacao);
            Controls.Add(btnCliente);
            Controls.Add(btnCidade);
            Controls.Add(btnCarro);
            Controls.Add(btnCategoria);
            Controls.Add(btnFuncionario);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DriveNow";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ReaLTaiizor.Controls.MaterialButton btnFuncionario;
        private ReaLTaiizor.Controls.MaterialButton btnCategoria;
        private ReaLTaiizor.Controls.MaterialButton btnCarro;
        private ReaLTaiizor.Controls.MaterialButton btnCidade;
        private ReaLTaiizor.Controls.MaterialButton btnCliente;
        private ReaLTaiizor.Controls.MaterialButton btnLocacao;
    }
}
