namespace IFSPStore.App.Base
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnDeletar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewList = new DataGridView();
            imageList1 = new ImageList(components);
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Controls.Add(tabPage1);
            tabControlRegister.Controls.Add(tabPage2);
            tabControlRegister.Depth = 0;
            tabControlRegister.ImageList = imageList1;
            tabControlRegister.Location = new Point(3, 64);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(798, 485);
            tabControlRegister.TabIndex = 0;
            tabControlRegister.SelectedIndexChanged += tabControlRegister_SelectedIndexChanged;
            tabControlRegister.Enter += tabPageList_Enter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.ImageKey = "form.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 399);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 48);
            panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(600, 6);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancel_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(704, 6);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSave_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dataGridViewList);
            tabPage2.ImageKey = "search.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNovo);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnDeletar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 44);
            panel2.TabIndex = 4;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(719, 5);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNew_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(640, 5);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEdit_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeletar.Depth = 0;
            btnDeletar.HighEmphasis = true;
            btnDeletar.Icon = null;
            btnDeletar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDeletar.Location = new Point(548, 5);
            btnDeletar.Margin = new Padding(4, 6, 4, 6);
            btnDeletar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.NoAccentTextColor = Color.Empty;
            btnDeletar.Size = new Size(84, 36);
            btnDeletar.TabIndex = 2;
            btnDeletar.Text = "Deletar";
            btnDeletar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeletar.UseAccentColor = false;
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDelete_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.AllowUserToAddRows = false;
            dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewList.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(1, 0);
            dataGridViewList.MultiSelect = false;
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.ReadOnly = true;
            dataGridViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewList.Size = new Size(787, 397);
            dataGridViewList.TabIndex = 3;
            dataGridViewList.DoubleClick += dataGridViewList_CellDoubleClick;
            dataGridViewList.KeyDown += dataGridViewList_KeyDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(1, "form.png");
            imageList1.Images.SetKeyName(2, "ifsp_icon.ico");
            imageList1.Images.SetKeyName(3, "logo.png");
            imageList1.Images.SetKeyName(4, "search.png");
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 555);
            Controls.Add(tabControlRegister);
            DrawerTabControl = tabControlRegister;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterParent;
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnDeletar;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        protected TabPage tabPage2;
        protected DataGridView dataGridViewList;
        private Panel panel1;
        private Panel panel2;
        public ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
        public TabPage tabPage1;
    }
}