namespace IFSPStore.App.Cadastros
{
    partial class CarroForm
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPlaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMarca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataAquisicao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDiaria = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            switch1 = new ReaLTaiizor.Controls.MaterialSwitch();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(switch1);
            tabPage1.Controls.Add(cboStatus);
            tabPage1.Controls.Add(txtDiaria);
            tabPage1.Controls.Add(txtDataAquisicao);
            tabPage1.Controls.Add(txtCor);
            tabPage1.Controls.Add(txtAno);
            tabPage1.Controls.Add(txtMarca);
            tabPage1.Controls.Add(txtModelo);
            tabPage1.Controls.Add(txtPlaca);
            tabPage1.Controls.Add(cboCategoria);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.SetChildIndex(txtNome, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(cboCategoria, 0);
            tabPage1.Controls.SetChildIndex(txtPlaca, 0);
            tabPage1.Controls.SetChildIndex(txtModelo, 0);
            tabPage1.Controls.SetChildIndex(txtMarca, 0);
            tabPage1.Controls.SetChildIndex(txtAno, 0);
            tabPage1.Controls.SetChildIndex(txtCor, 0);
            tabPage1.Controls.SetChildIndex(txtDataAquisicao, 0);
            tabPage1.Controls.SetChildIndex(txtDiaria, 0);
            tabPage1.Controls.SetChildIndex(cboStatus, 0);
            tabPage1.Controls.SetChildIndex(switch1, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(649, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(661, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(124, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            cboCategoria.AutoResize = false;
            cboCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cboCategoria.Depth = 0;
            cboCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategoria.DropDownHeight = 174;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.DropDownWidth = 121;
            cboCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Hint = "Categoria";
            cboCategoria.IntegralHeight = false;
            cboCategoria.ItemHeight = 43;
            cboCategoria.Location = new Point(6, 223);
            cboCategoria.MaxDropDownItems = 4;
            cboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(779, 49);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 9;
            // 
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.AutoCompleteMode = AutoCompleteMode.None;
            txtPlaca.AutoCompleteSource = AutoCompleteSource.None;
            txtPlaca.BackgroundImageLayout = ImageLayout.None;
            txtPlaca.CharacterCasing = CharacterCasing.Normal;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlaca.HideSelection = true;
            txtPlaca.Hint = "Placa";
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new Point(262, 60);
            txtPlaca.MaxLength = 7;
            txtPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PasswordChar = '\0';
            txtPlaca.PrefixSuffixText = null;
            txtPlaca.ReadOnly = false;
            txtPlaca.RightToLeft = RightToLeft.No;
            txtPlaca.SelectedText = "";
            txtPlaca.SelectionLength = 0;
            txtPlaca.SelectionStart = 0;
            txtPlaca.ShortcutsEnabled = true;
            txtPlaca.Size = new Size(266, 48);
            txtPlaca.TabIndex = 13;
            txtPlaca.TabStop = false;
            txtPlaca.TextAlign = HorizontalAlignment.Left;
            txtPlaca.TrailingIcon = null;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = ImageLayout.None;
            txtModelo.CharacterCasing = CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.Hint = "Modelo";
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new Point(534, 60);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new Size(250, 48);
            txtModelo.TabIndex = 14;
            txtModelo.TabStop = false;
            txtModelo.TextAlign = HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // txtMarca
            // 
            txtMarca.AnimateReadOnly = false;
            txtMarca.AutoCompleteMode = AutoCompleteMode.None;
            txtMarca.AutoCompleteSource = AutoCompleteSource.None;
            txtMarca.BackgroundImageLayout = ImageLayout.None;
            txtMarca.CharacterCasing = CharacterCasing.Normal;
            txtMarca.Depth = 0;
            txtMarca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMarca.HideSelection = true;
            txtMarca.Hint = "Marca";
            txtMarca.LeadingIcon = null;
            txtMarca.Location = new Point(6, 114);
            txtMarca.MaxLength = 32767;
            txtMarca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMarca.Name = "txtMarca";
            txtMarca.PasswordChar = '\0';
            txtMarca.PrefixSuffixText = null;
            txtMarca.ReadOnly = false;
            txtMarca.RightToLeft = RightToLeft.No;
            txtMarca.SelectedText = "";
            txtMarca.SelectionLength = 0;
            txtMarca.SelectionStart = 0;
            txtMarca.ShortcutsEnabled = true;
            txtMarca.Size = new Size(250, 48);
            txtMarca.TabIndex = 15;
            txtMarca.TabStop = false;
            txtMarca.TextAlign = HorizontalAlignment.Left;
            txtMarca.TrailingIcon = null;
            txtMarca.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            txtAno.AnimateReadOnly = false;
            txtAno.AutoCompleteMode = AutoCompleteMode.None;
            txtAno.AutoCompleteSource = AutoCompleteSource.None;
            txtAno.BackgroundImageLayout = ImageLayout.None;
            txtAno.CharacterCasing = CharacterCasing.Normal;
            txtAno.Depth = 0;
            txtAno.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAno.HideSelection = true;
            txtAno.Hint = "Ano";
            txtAno.LeadingIcon = null;
            txtAno.Location = new Point(264, 114);
            txtAno.MaxLength = 4;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.ReadOnly = false;
            txtAno.RightToLeft = RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new Size(264, 48);
            txtAno.TabIndex = 16;
            txtAno.TabStop = false;
            txtAno.TextAlign = HorizontalAlignment.Left;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
            // 
            // txtCor
            // 
            txtCor.AnimateReadOnly = false;
            txtCor.AutoCompleteMode = AutoCompleteMode.None;
            txtCor.AutoCompleteSource = AutoCompleteSource.None;
            txtCor.BackgroundImageLayout = ImageLayout.None;
            txtCor.CharacterCasing = CharacterCasing.Normal;
            txtCor.Depth = 0;
            txtCor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCor.HideSelection = true;
            txtCor.Hint = "Cor";
            txtCor.LeadingIcon = null;
            txtCor.Location = new Point(536, 114);
            txtCor.MaxLength = 32767;
            txtCor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCor.Name = "txtCor";
            txtCor.PasswordChar = '\0';
            txtCor.PrefixSuffixText = null;
            txtCor.ReadOnly = false;
            txtCor.RightToLeft = RightToLeft.No;
            txtCor.SelectedText = "";
            txtCor.SelectionLength = 0;
            txtCor.SelectionStart = 0;
            txtCor.ShortcutsEnabled = true;
            txtCor.Size = new Size(250, 48);
            txtCor.TabIndex = 17;
            txtCor.TabStop = false;
            txtCor.TextAlign = HorizontalAlignment.Left;
            txtCor.TrailingIcon = null;
            txtCor.UseSystemPasswordChar = false;
            // 
            // txtDataAquisicao
            // 
            txtDataAquisicao.AllowPromptAsInput = true;
            txtDataAquisicao.AnimateReadOnly = false;
            txtDataAquisicao.AsciiOnly = false;
            txtDataAquisicao.BackgroundImageLayout = ImageLayout.None;
            txtDataAquisicao.BeepOnError = false;
            txtDataAquisicao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataAquisicao.Depth = 0;
            txtDataAquisicao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataAquisicao.HidePromptOnLeave = false;
            txtDataAquisicao.HideSelection = true;
            txtDataAquisicao.Hint = "Data de aquisição";
            txtDataAquisicao.InsertKeyMode = InsertKeyMode.Default;
            txtDataAquisicao.LeadingIcon = null;
            txtDataAquisicao.Location = new Point(8, 168);
            txtDataAquisicao.Mask = "99/99/9999";
            txtDataAquisicao.MaxLength = 32767;
            txtDataAquisicao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataAquisicao.Name = "txtDataAquisicao";
            txtDataAquisicao.PasswordChar = '\0';
            txtDataAquisicao.PrefixSuffixText = null;
            txtDataAquisicao.PromptChar = '_';
            txtDataAquisicao.ReadOnly = false;
            txtDataAquisicao.RejectInputOnFirstFailure = false;
            txtDataAquisicao.ResetOnPrompt = true;
            txtDataAquisicao.ResetOnSpace = true;
            txtDataAquisicao.RightToLeft = RightToLeft.No;
            txtDataAquisicao.SelectedText = "";
            txtDataAquisicao.SelectionLength = 0;
            txtDataAquisicao.SelectionStart = 0;
            txtDataAquisicao.ShortcutsEnabled = true;
            txtDataAquisicao.Size = new Size(250, 48);
            txtDataAquisicao.SkipLiterals = true;
            txtDataAquisicao.TabIndex = 21;
            txtDataAquisicao.TabStop = false;
            txtDataAquisicao.Text = "  /  /";
            txtDataAquisicao.TextAlign = HorizontalAlignment.Left;
            txtDataAquisicao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataAquisicao.TrailingIcon = null;
            txtDataAquisicao.UseSystemPasswordChar = false;
            txtDataAquisicao.ValidatingType = null;
            // 
            // txtDiaria
            // 
            txtDiaria.AllowPromptAsInput = true;
            txtDiaria.AnimateReadOnly = false;
            txtDiaria.AsciiOnly = false;
            txtDiaria.BackgroundImageLayout = ImageLayout.None;
            txtDiaria.BeepOnError = false;
            txtDiaria.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDiaria.Depth = 0;
            txtDiaria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiaria.HidePromptOnLeave = false;
            txtDiaria.HideSelection = true;
            txtDiaria.Hint = "Diaria";
            txtDiaria.InsertKeyMode = InsertKeyMode.Default;
            txtDiaria.LeadingIcon = null;
            txtDiaria.Location = new Point(8, 60);
            txtDiaria.Mask = "9999\\,99";
            txtDiaria.MaxLength = 32767;
            txtDiaria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDiaria.Name = "txtDiaria";
            txtDiaria.PasswordChar = '\0';
            txtDiaria.PrefixSuffixText = null;
            txtDiaria.PromptChar = '_';
            txtDiaria.ReadOnly = false;
            txtDiaria.RejectInputOnFirstFailure = false;
            txtDiaria.ResetOnPrompt = true;
            txtDiaria.ResetOnSpace = true;
            txtDiaria.RightToLeft = RightToLeft.No;
            txtDiaria.SelectedText = "";
            txtDiaria.SelectionLength = 0;
            txtDiaria.SelectionStart = 0;
            txtDiaria.ShortcutsEnabled = true;
            txtDiaria.Size = new Size(250, 48);
            txtDiaria.SkipLiterals = true;
            txtDiaria.TabIndex = 22;
            txtDiaria.TabStop = false;
            txtDiaria.Text = "    ,";
            txtDiaria.TextAlign = HorizontalAlignment.Left;
            txtDiaria.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDiaria.TrailingIcon = null;
            txtDiaria.UseSystemPasswordChar = false;
            txtDiaria.ValidatingType = null;
            // 
            // cboStatus
            // 
            cboStatus.AutoResize = false;
            cboStatus.BackColor = Color.FromArgb(255, 255, 255);
            cboStatus.Depth = 0;
            cboStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cboStatus.DropDownHeight = 174;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.DropDownWidth = 121;
            cboStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Hint = "Status";
            cboStatus.IntegralHeight = false;
            cboStatus.ItemHeight = 43;
            cboStatus.Items.AddRange(new object[] { "", "Em operação", "Em manutenção", "Fora de serviço" });
            cboStatus.Location = new Point(262, 168);
            cboStatus.MaxDropDownItems = 4;
            cboStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(266, 49);
            cboStatus.StartIndex = 0;
            cboStatus.TabIndex = 23;
            // 
            // switch1
            // 
            switch1.AutoSize = true;
            switch1.Depth = 0;
            switch1.Location = new Point(603, 179);
            switch1.Margin = new Padding(0);
            switch1.MouseLocation = new Point(-1, -1);
            switch1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            switch1.Name = "switch1";
            switch1.Ripple = true;
            switch1.Size = new Size(132, 37);
            switch1.TabIndex = 24;
            switch1.Text = "Disponivel";
            switch1.UseAccentColor = false;
            switch1.UseVisualStyleBackColor = true;
            // 
            // CarroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 562);
            Location = new Point(0, 0);
            Name = "CarroForm";
            Text = "Cadastro de carro";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMarca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlaca;
        private ReaLTaiizor.Controls.MaterialComboBox cboStatus;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDiaria;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataAquisicao;
        private ReaLTaiizor.Controls.MaterialSwitch switch1;
    }
}