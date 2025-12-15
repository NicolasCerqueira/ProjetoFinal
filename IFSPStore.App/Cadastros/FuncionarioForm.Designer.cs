namespace IFSPStore.App.Cadastros
{
    partial class FuncionarioForm
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
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataRegistro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUltimoLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkAtivo = new ReaLTaiizor.Controls.MaterialSwitch();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(txtUltimoLogin);
            tabPage1.Controls.Add(txtDataRegistro);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtSenha);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Text = "Usuario Ativo";
            tabPage1.Controls.SetChildIndex(txtNome, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtUsuario, 0);
            tabPage1.Controls.SetChildIndex(txtSenha, 0);
            tabPage1.Controls.SetChildIndex(txtEmail, 0);
            tabPage1.Controls.SetChildIndex(txtDataRegistro, 0);
            tabPage1.Controls.SetChildIndex(txtUltimoLogin, 0);
            tabPage1.Controls.SetChildIndex(chkAtivo, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackColor = Color.FromArgb(50, 50, 50);
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
            txtNome.Size = new Size(610, 48);
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
            txtId.BackColor = Color.FromArgb(50, 50, 50);
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(622, 6);
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
            txtId.Size = new Size(162, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.AutoCompleteMode = AutoCompleteMode.None;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.None;
            txtUsuario.BackColor = Color.FromArgb(50, 50, 50);
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "Usuario";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(6, 60);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PrefixSuffixText = null;
            txtUsuario.ReadOnly = false;
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(388, 48);
            txtUsuario.TabIndex = 5;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Left;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackColor = Color.FromArgb(50, 50, 50);
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(400, 60);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(384, 48);
            txtSenha.TabIndex = 6;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackColor = Color.FromArgb(50, 50, 50);
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(6, 114);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(600, 48);
            txtEmail.TabIndex = 7;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDataRegistro
            // 
            txtDataRegistro.AnimateReadOnly = false;
            txtDataRegistro.AutoCompleteMode = AutoCompleteMode.None;
            txtDataRegistro.AutoCompleteSource = AutoCompleteSource.None;
            txtDataRegistro.BackColor = Color.FromArgb(50, 50, 50);
            txtDataRegistro.BackgroundImageLayout = ImageLayout.None;
            txtDataRegistro.CharacterCasing = CharacterCasing.Normal;
            txtDataRegistro.Depth = 0;
            txtDataRegistro.Enabled = false;
            txtDataRegistro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataRegistro.HideSelection = true;
            txtDataRegistro.Hint = "Data de Registro";
            txtDataRegistro.LeadingIcon = null;
            txtDataRegistro.Location = new Point(284, 168);
            txtDataRegistro.MaxLength = 32767;
            txtDataRegistro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataRegistro.Name = "txtDataRegistro";
            txtDataRegistro.PasswordChar = '\0';
            txtDataRegistro.PrefixSuffixText = null;
            txtDataRegistro.ReadOnly = false;
            txtDataRegistro.RightToLeft = RightToLeft.No;
            txtDataRegistro.SelectedText = "";
            txtDataRegistro.SelectionLength = 0;
            txtDataRegistro.SelectionStart = 0;
            txtDataRegistro.ShortcutsEnabled = true;
            txtDataRegistro.Size = new Size(250, 48);
            txtDataRegistro.TabIndex = 8;
            txtDataRegistro.TabStop = false;
            txtDataRegistro.TextAlign = HorizontalAlignment.Left;
            txtDataRegistro.TrailingIcon = null;
            txtDataRegistro.UseSystemPasswordChar = false;
            // 
            // txtUltimoLogin
            // 
            txtUltimoLogin.AnimateReadOnly = false;
            txtUltimoLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtUltimoLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtUltimoLogin.BackColor = Color.FromArgb(50, 50, 50);
            txtUltimoLogin.BackgroundImageLayout = ImageLayout.None;
            txtUltimoLogin.CharacterCasing = CharacterCasing.Normal;
            txtUltimoLogin.Depth = 0;
            txtUltimoLogin.Enabled = false;
            txtUltimoLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUltimoLogin.HideSelection = true;
            txtUltimoLogin.Hint = "Ultimo login";
            txtUltimoLogin.LeadingIcon = null;
            txtUltimoLogin.Location = new Point(284, 222);
            txtUltimoLogin.MaxLength = 32767;
            txtUltimoLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUltimoLogin.Name = "txtUltimoLogin";
            txtUltimoLogin.PasswordChar = '\0';
            txtUltimoLogin.PrefixSuffixText = null;
            txtUltimoLogin.ReadOnly = false;
            txtUltimoLogin.RightToLeft = RightToLeft.No;
            txtUltimoLogin.SelectedText = "";
            txtUltimoLogin.SelectionLength = 0;
            txtUltimoLogin.SelectionStart = 0;
            txtUltimoLogin.ShortcutsEnabled = true;
            txtUltimoLogin.Size = new Size(250, 48);
            txtUltimoLogin.TabIndex = 9;
            txtUltimoLogin.TabStop = false;
            txtUltimoLogin.TextAlign = HorizontalAlignment.Left;
            txtUltimoLogin.TrailingIcon = null;
            txtUltimoLogin.UseSystemPasswordChar = false;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.BackColor = Color.FromArgb(50, 50, 50);
            chkAtivo.Depth = 0;
            chkAtivo.ForeColor = Color.FromArgb(222, 255, 255, 255);
            chkAtivo.Location = new Point(622, 125);
            chkAtivo.Margin = new Padding(0);
            chkAtivo.MouseLocation = new Point(-1, -1);
            chkAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Ripple = true;
            chkAtivo.Size = new Size(151, 37);
            chkAtivo.TabIndex = 25;
            chkAtivo.Text = "Usuario ativo";
            chkAtivo.UseAccentColor = false;
            chkAtivo.UseVisualStyleBackColor = false;
            // 
            // FuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 556);
            Location = new Point(0, 0);
            Name = "FuncionarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de funcionarios";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUltimoLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataRegistro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialSwitch chkAtivo;
    }
}