namespace IFSPStore.App.Cadastros
{
    partial class LocacaoForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtDataLocacao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboFuncionario = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCarro = new ReaLTaiizor.Controls.MaterialComboBox();
            lblQtdItens = new ReaLTaiizor.Controls.MaterialLabel();
            lblTotalPrice = new ReaLTaiizor.Controls.MaterialLabel();
            txtDataDevolucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPreco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecoTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewItens = new DataGridView();
            txtDiarias = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            groupBoxItens = new GroupBox();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            groupBoxItens.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Size = new Size(790, 597);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(798, 632);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDataDevolucao);
            tabPage1.Controls.Add(lblTotalPrice);
            tabPage1.Controls.Add(lblQtdItens);
            tabPage1.Controls.Add(groupBoxItens);
            tabPage1.Controls.Add(cboCliente);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(cboFuncionario);
            tabPage1.Controls.Add(txtDataLocacao);
            tabPage1.Controls.Add(cboCarro);
            tabPage1.Size = new Size(790, 597);
            tabPage1.Controls.SetChildIndex(cboCarro, 0);
            tabPage1.Controls.SetChildIndex(txtDataLocacao, 0);
            tabPage1.Controls.SetChildIndex(cboFuncionario, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(cboCliente, 0);
            tabPage1.Controls.SetChildIndex(groupBoxItens, 0);
            tabPage1.Controls.SetChildIndex(lblQtdItens, 0);
            tabPage1.Controls.SetChildIndex(lblTotalPrice, 0);
            tabPage1.Controls.SetChildIndex(txtDataDevolucao, 0);
            // 
            // txtDataLocacao
            // 
            txtDataLocacao.AllowPromptAsInput = true;
            txtDataLocacao.AnimateReadOnly = false;
            txtDataLocacao.AsciiOnly = false;
            txtDataLocacao.BackColor = Color.FromArgb(50, 50, 50);
            txtDataLocacao.BackgroundImageLayout = ImageLayout.None;
            txtDataLocacao.BeepOnError = false;
            txtDataLocacao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataLocacao.Depth = 0;
            txtDataLocacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataLocacao.HidePromptOnLeave = false;
            txtDataLocacao.HideSelection = true;
            txtDataLocacao.Hint = "Data de locação";
            txtDataLocacao.InsertKeyMode = InsertKeyMode.Default;
            txtDataLocacao.LeadingIcon = null;
            txtDataLocacao.Location = new Point(332, 62);
            txtDataLocacao.Mask = "99/99/9999";
            txtDataLocacao.MaxLength = 32767;
            txtDataLocacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataLocacao.Name = "txtDataLocacao";
            txtDataLocacao.PasswordChar = '\0';
            txtDataLocacao.PrefixSuffixText = null;
            txtDataLocacao.PromptChar = '_';
            txtDataLocacao.ReadOnly = false;
            txtDataLocacao.RejectInputOnFirstFailure = false;
            txtDataLocacao.ResetOnPrompt = true;
            txtDataLocacao.ResetOnSpace = true;
            txtDataLocacao.RightToLeft = RightToLeft.No;
            txtDataLocacao.SelectedText = "";
            txtDataLocacao.SelectionLength = 0;
            txtDataLocacao.SelectionStart = 0;
            txtDataLocacao.ShortcutsEnabled = true;
            txtDataLocacao.Size = new Size(220, 48);
            txtDataLocacao.SkipLiterals = true;
            txtDataLocacao.TabIndex = 3;
            txtDataLocacao.TabStop = false;
            txtDataLocacao.Text = "  /  /";
            txtDataLocacao.TextAlign = HorizontalAlignment.Left;
            txtDataLocacao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataLocacao.TrailingIcon = null;
            txtDataLocacao.UseSystemPasswordChar = false;
            txtDataLocacao.ValidatingType = null;
            txtDataLocacao.Leave += txtDataLocacao_Leave;
            // 
            // cboFuncionario
            // 
            cboFuncionario.AutoResize = false;
            cboFuncionario.BackColor = Color.FromArgb(50, 50, 50);
            cboFuncionario.Depth = 0;
            cboFuncionario.DrawMode = DrawMode.OwnerDrawVariable;
            cboFuncionario.DropDownHeight = 174;
            cboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncionario.DropDownWidth = 121;
            cboFuncionario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFuncionario.ForeColor = Color.FromArgb(222, 255, 255, 255);
            cboFuncionario.FormattingEnabled = true;
            cboFuncionario.Hint = "Funcionario";
            cboFuncionario.IntegralHeight = false;
            cboFuncionario.ItemHeight = 43;
            cboFuncionario.Location = new Point(6, 7);
            cboFuncionario.MaxDropDownItems = 4;
            cboFuncionario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFuncionario.Name = "cboFuncionario";
            cboFuncionario.Size = new Size(320, 49);
            cboFuncionario.StartIndex = 0;
            cboFuncionario.TabIndex = 4;
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
            txtId.Location = new Point(658, 7);
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
            txtId.Size = new Size(126, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(50, 50, 50);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 255, 255, 255);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(332, 7);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(320, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 6;
            // 
            // cboCarro
            // 
            cboCarro.AutoResize = false;
            cboCarro.BackColor = Color.FromArgb(50, 50, 50);
            cboCarro.Depth = 0;
            cboCarro.DrawMode = DrawMode.OwnerDrawVariable;
            cboCarro.DropDownHeight = 174;
            cboCarro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarro.DropDownWidth = 121;
            cboCarro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCarro.ForeColor = Color.FromArgb(222, 255, 255, 255);
            cboCarro.FormattingEnabled = true;
            cboCarro.Hint = "Carro";
            cboCarro.IntegralHeight = false;
            cboCarro.ItemHeight = 43;
            cboCarro.Location = new Point(6, 60);
            cboCarro.MaxDropDownItems = 4;
            cboCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCarro.Name = "cboCarro";
            cboCarro.Size = new Size(320, 49);
            cboCarro.StartIndex = 0;
            cboCarro.TabIndex = 0;
            cboCarro.SelectedValueChanged += cboCarro_SelectedValueChanged;
            // 
            // lblQtdItens
            // 
            lblQtdItens.AutoSize = true;
            lblQtdItens.BackColor = Color.FromArgb(50, 50, 50);
            lblQtdItens.Depth = 0;
            lblQtdItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQtdItens.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblQtdItens.Location = new Point(12, 524);
            lblQtdItens.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQtdItens.Name = "lblQtdItens";
            lblQtdItens.Size = new Size(183, 19);
            lblQtdItens.TabIndex = 8;
            lblQtdItens.Text = "Quantidade de veiculos: 0";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.FromArgb(50, 50, 50);
            lblTotalPrice.Depth = 0;
            lblTotalPrice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalPrice.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblTotalPrice.Location = new Point(352, 524);
            lblTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(140, 19);
            lblTotalPrice.TabIndex = 9;
            lblTotalPrice.Text = "Valor Total: R$ 0,00";
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.AllowPromptAsInput = true;
            txtDataDevolucao.AnimateReadOnly = false;
            txtDataDevolucao.AsciiOnly = false;
            txtDataDevolucao.BackColor = Color.FromArgb(50, 50, 50);
            txtDataDevolucao.BackgroundImageLayout = ImageLayout.None;
            txtDataDevolucao.BeepOnError = false;
            txtDataDevolucao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.Depth = 0;
            txtDataDevolucao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataDevolucao.HidePromptOnLeave = false;
            txtDataDevolucao.HideSelection = true;
            txtDataDevolucao.Hint = "Data de devolução";
            txtDataDevolucao.InsertKeyMode = InsertKeyMode.Default;
            txtDataDevolucao.LeadingIcon = null;
            txtDataDevolucao.Location = new Point(564, 62);
            txtDataDevolucao.Mask = "99/99/9999";
            txtDataDevolucao.MaxLength = 32767;
            txtDataDevolucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.PasswordChar = '\0';
            txtDataDevolucao.PrefixSuffixText = null;
            txtDataDevolucao.PromptChar = '_';
            txtDataDevolucao.ReadOnly = false;
            txtDataDevolucao.RejectInputOnFirstFailure = false;
            txtDataDevolucao.ResetOnPrompt = true;
            txtDataDevolucao.ResetOnSpace = true;
            txtDataDevolucao.RightToLeft = RightToLeft.No;
            txtDataDevolucao.SelectedText = "";
            txtDataDevolucao.SelectionLength = 0;
            txtDataDevolucao.SelectionStart = 0;
            txtDataDevolucao.ShortcutsEnabled = true;
            txtDataDevolucao.Size = new Size(220, 48);
            txtDataDevolucao.SkipLiterals = true;
            txtDataDevolucao.TabIndex = 10;
            txtDataDevolucao.TabStop = false;
            txtDataDevolucao.Text = "  /  /";
            txtDataDevolucao.TextAlign = HorizontalAlignment.Left;
            txtDataDevolucao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.TrailingIcon = null;
            txtDataDevolucao.UseSystemPasswordChar = false;
            txtDataDevolucao.ValidatingType = null;
            txtDataDevolucao.Leave += txtDataLocacao_Leave;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.AutoCompleteMode = AutoCompleteMode.None;
            txtPreco.AutoCompleteSource = AutoCompleteSource.None;
            txtPreco.BackColor = Color.FromArgb(50, 50, 50);
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Enabled = false;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço da diaria";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(82, 73);
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.ReadOnly = false;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(238, 48);
            txtPreco.TabIndex = 2;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // txtPrecoTotal
            // 
            txtPrecoTotal.AnimateReadOnly = false;
            txtPrecoTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecoTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecoTotal.BackColor = Color.FromArgb(50, 50, 50);
            txtPrecoTotal.BackgroundImageLayout = ImageLayout.None;
            txtPrecoTotal.CharacterCasing = CharacterCasing.Normal;
            txtPrecoTotal.Depth = 0;
            txtPrecoTotal.Enabled = false;
            txtPrecoTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoTotal.HideSelection = true;
            txtPrecoTotal.Hint = "Preço total";
            txtPrecoTotal.LeadingIcon = null;
            txtPrecoTotal.Location = new Point(326, 73);
            txtPrecoTotal.MaxLength = 32767;
            txtPrecoTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecoTotal.Name = "txtPrecoTotal";
            txtPrecoTotal.PasswordChar = '\0';
            txtPrecoTotal.PrefixSuffixText = null;
            txtPrecoTotal.ReadOnly = false;
            txtPrecoTotal.RightToLeft = RightToLeft.No;
            txtPrecoTotal.SelectedText = "";
            txtPrecoTotal.SelectionLength = 0;
            txtPrecoTotal.SelectionStart = 0;
            txtPrecoTotal.ShortcutsEnabled = true;
            txtPrecoTotal.Size = new Size(238, 48);
            txtPrecoTotal.TabIndex = 3;
            txtPrecoTotal.TabStop = false;
            txtPrecoTotal.TextAlign = HorizontalAlignment.Left;
            txtPrecoTotal.TrailingIcon = null;
            txtPrecoTotal.UseSystemPasswordChar = false;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.BackColor = Color.FromArgb(50, 50, 50);
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.ForeColor = Color.FromArgb(222, 255, 255, 255);
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(585, 25);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(98, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewItens
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewItens.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewItens.Location = new Point(6, 130);
            dataGridViewItens.MultiSelect = false;
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.ReadOnly = true;
            dataGridViewItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItens.Size = new Size(766, 276);
            dataGridViewItens.TabIndex = 5;
            // 
            // txtDiarias
            // 
            txtDiarias.AnimateReadOnly = false;
            txtDiarias.AutoCompleteMode = AutoCompleteMode.None;
            txtDiarias.AutoCompleteSource = AutoCompleteSource.None;
            txtDiarias.BackColor = Color.FromArgb(50, 50, 50);
            txtDiarias.BackgroundImageLayout = ImageLayout.None;
            txtDiarias.CharacterCasing = CharacterCasing.Normal;
            txtDiarias.Depth = 0;
            txtDiarias.Enabled = false;
            txtDiarias.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiarias.HideSelection = true;
            txtDiarias.Hint = "Diarias";
            txtDiarias.LeadingIcon = null;
            txtDiarias.Location = new Point(326, 19);
            txtDiarias.MaxLength = 32767;
            txtDiarias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDiarias.Name = "txtDiarias";
            txtDiarias.PasswordChar = '\0';
            txtDiarias.PrefixSuffixText = null;
            txtDiarias.ReadOnly = false;
            txtDiarias.RightToLeft = RightToLeft.No;
            txtDiarias.SelectedText = "";
            txtDiarias.SelectionLength = 0;
            txtDiarias.SelectionStart = 0;
            txtDiarias.ShortcutsEnabled = true;
            txtDiarias.Size = new Size(238, 48);
            txtDiarias.TabIndex = 6;
            txtDiarias.TabStop = false;
            txtDiarias.TextAlign = HorizontalAlignment.Left;
            txtDiarias.TrailingIcon = null;
            txtDiarias.UseSystemPasswordChar = false;
            txtDiarias.KeyPress += txtDiarias_KeyPress;
            txtDiarias.Leave += txtDiarias_Leave;
            // 
            // cboCategoria
            // 
            cboCategoria.AutoResize = false;
            cboCategoria.BackColor = Color.FromArgb(50, 50, 50);
            cboCategoria.Depth = 0;
            cboCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategoria.DropDownHeight = 174;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.DropDownWidth = 121;
            cboCategoria.Enabled = false;
            cboCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategoria.ForeColor = Color.FromArgb(222, 255, 255, 255);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Hint = "Categoria";
            cboCategoria.IntegralHeight = false;
            cboCategoria.ItemHeight = 43;
            cboCategoria.Location = new Point(82, 19);
            cboCategoria.MaxDropDownItems = 4;
            cboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(238, 49);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 7;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.BackColor = Color.FromArgb(50, 50, 50);
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.ForeColor = Color.FromArgb(222, 255, 255, 255);
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(595, 73);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(79, 36);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Apagar";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // groupBoxItens
            // 
            groupBoxItens.BackColor = Color.FromArgb(50, 50, 50);
            groupBoxItens.Controls.Add(btnExcluir);
            groupBoxItens.Controls.Add(cboCategoria);
            groupBoxItens.Controls.Add(txtDiarias);
            groupBoxItens.Controls.Add(dataGridViewItens);
            groupBoxItens.Controls.Add(btnAdd);
            groupBoxItens.Controls.Add(txtPrecoTotal);
            groupBoxItens.Controls.Add(txtPreco);
            groupBoxItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBoxItens.ForeColor = Color.FromArgb(222, 255, 255, 255);
            groupBoxItens.Location = new Point(6, 115);
            groupBoxItens.Name = "groupBoxItens";
            groupBoxItens.Size = new Size(778, 438);
            groupBoxItens.TabIndex = 7;
            groupBoxItens.TabStop = false;
            groupBoxItens.Text = "Detalhes da locação";
            // 
            // LocacaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 702);
            Location = new Point(0, 0);
            Name = "LocacaoForm";
            Text = "Aluguel de veiculos";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            groupBoxItens.ResumeLayout(false);
            groupBoxItens.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboFuncionario;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataLocacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboCarro;
        private ReaLTaiizor.Controls.MaterialLabel lblTotalPrice;
        private ReaLTaiizor.Controls.MaterialLabel lblQtdItens;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDevolucao;
        private GroupBox groupBoxItens;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDiarias;
        private DataGridView dataGridViewItens;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecoTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPreco;
    }
}