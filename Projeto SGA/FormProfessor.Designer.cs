namespace SGA
{
    partial class FormProfessor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessor));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.CboxTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TXTPID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboEstados = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.mmtbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Remove = new ReaLTaiizor.Controls.MaterialButton();
            this.Btn_Edit = new ReaLTaiizor.Controls.MaterialButton();
            this.Btn_new = new ReaLTaiizor.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(776, 455);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtFormacao);
            this.tabPage1.Controls.Add(this.CboxTitulacao);
            this.tabPage1.Controls.Add(this.TXTPID);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.cboEstados);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.mmtbDataNascimento);
            this.tabPage1.Controls.Add(this.txtMatricula);
            this.tabPage1.ImageKey = "form (1).png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtFormacao
            // 
            this.TxtFormacao.AnimateReadOnly = false;
            this.TxtFormacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtFormacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtFormacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtFormacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtFormacao.Depth = 0;
            this.TxtFormacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFormacao.HideSelection = true;
            this.TxtFormacao.Hint = "Área de Formação";
            this.TxtFormacao.LeadingIcon = null;
            this.TxtFormacao.Location = new System.Drawing.Point(26, 222);
            this.TxtFormacao.MaxLength = 32767;
            this.TxtFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtFormacao.Name = "TxtFormacao";
            this.TxtFormacao.PasswordChar = '\0';
            this.TxtFormacao.PrefixSuffixText = null;
            this.TxtFormacao.ReadOnly = false;
            this.TxtFormacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFormacao.SelectedText = "";
            this.TxtFormacao.SelectionLength = 0;
            this.TxtFormacao.SelectionStart = 0;
            this.TxtFormacao.ShortcutsEnabled = true;
            this.TxtFormacao.Size = new System.Drawing.Size(660, 48);
            this.TxtFormacao.TabIndex = 12;
            this.TxtFormacao.TabStop = false;
            this.TxtFormacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFormacao.TrailingIcon = null;
            this.TxtFormacao.UseSystemPasswordChar = false;
            // 
            // CboxTitulacao
            // 
            this.CboxTitulacao.AutoResize = false;
            this.CboxTitulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboxTitulacao.Depth = 0;
            this.CboxTitulacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CboxTitulacao.DropDownHeight = 174;
            this.CboxTitulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTitulacao.DropDownWidth = 121;
            this.CboxTitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CboxTitulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CboxTitulacao.FormattingEnabled = true;
            this.CboxTitulacao.Hint = "Estado";
            this.CboxTitulacao.IntegralHeight = false;
            this.CboxTitulacao.ItemHeight = 43;
            this.CboxTitulacao.Items.AddRange(new object[] {
            "Graduação",
            "Especialização",
            "Mestrado",
            "Doutorado"});
            this.CboxTitulacao.Location = new System.Drawing.Point(438, 168);
            this.CboxTitulacao.MaxDropDownItems = 4;
            this.CboxTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CboxTitulacao.Name = "CboxTitulacao";
            this.CboxTitulacao.Size = new System.Drawing.Size(248, 49);
            this.CboxTitulacao.StartIndex = 0;
            this.CboxTitulacao.TabIndex = 11;
            // 
            // TXTPID
            // 
            this.TXTPID.AnimateReadOnly = false;
            this.TXTPID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TXTPID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TXTPID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXTPID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TXTPID.Depth = 0;
            this.TXTPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TXTPID.HideSelection = true;
            this.TXTPID.Hint = "ID";
            this.TXTPID.LeadingIcon = null;
            this.TXTPID.Location = new System.Drawing.Point(619, 6);
            this.TXTPID.MaxLength = 32767;
            this.TXTPID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TXTPID.Name = "TXTPID";
            this.TXTPID.PasswordChar = '\0';
            this.TXTPID.PrefixSuffixText = null;
            this.TXTPID.ReadOnly = true;
            this.TXTPID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTPID.SelectedText = "";
            this.TXTPID.SelectionLength = 0;
            this.TXTPID.SelectionStart = 0;
            this.TXTPID.ShortcutsEnabled = true;
            this.TXTPID.Size = new System.Drawing.Size(71, 48);
            this.TXTPID.TabIndex = 10;
            this.TXTPID.TabStop = false;
            this.TXTPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTPID.TrailingIcon = null;
            this.TXTPID.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(488, 333);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(105, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(612, 333);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(85, 36);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.AutoResize = false;
            this.cboEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEstados.Depth = 0;
            this.cboEstados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEstados.DropDownHeight = 174;
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.DropDownWidth = 121;
            this.cboEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEstados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Hint = "Estado";
            this.cboEstados.IntegralHeight = false;
            this.cboEstados.ItemHeight = 43;
            this.cboEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstados.Location = new System.Drawing.Point(215, 167);
            this.cboEstados.MaxDropDownItems = 4;
            this.cboEstados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(202, 49);
            this.cboEstados.StartIndex = 0;
            this.cboEstados.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.HideSelection = true;
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.Location = new System.Drawing.Point(26, 168);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.PrefixSuffixText = null;
            this.txtCidade.ReadOnly = false;
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(183, 48);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.TabStop = false;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.HideSelection = true;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.Location = new System.Drawing.Point(436, 114);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.PrefixSuffixText = null;
            this.txtBairro.ReadOnly = false;
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(250, 48);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.TabStop = false;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBairro.TrailingIcon = null;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AnimateReadOnly = false;
            this.txtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.HideSelection = true;
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(26, 114);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PrefixSuffixText = null;
            this.txtEndereco.ReadOnly = false;
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(391, 48);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.TrailingIcon = null;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(26, 60);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(662, 48);
            this.txtNome.TabIndex = 2;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // mmtbDataNascimento
            // 
            this.mmtbDataNascimento.AllowPromptAsInput = true;
            this.mmtbDataNascimento.AnimateReadOnly = false;
            this.mmtbDataNascimento.AsciiOnly = false;
            this.mmtbDataNascimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtbDataNascimento.BeepOnError = false;
            this.mmtbDataNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtbDataNascimento.Depth = 0;
            this.mmtbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtbDataNascimento.HidePromptOnLeave = false;
            this.mmtbDataNascimento.HideSelection = true;
            this.mmtbDataNascimento.Hint = "Data de Nascimento";
            this.mmtbDataNascimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtbDataNascimento.LeadingIcon = null;
            this.mmtbDataNascimento.Location = new System.Drawing.Point(438, 6);
            this.mmtbDataNascimento.Mask = "99/99/9999";
            this.mmtbDataNascimento.MaxLength = 32767;
            this.mmtbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mmtbDataNascimento.Name = "mmtbDataNascimento";
            this.mmtbDataNascimento.PasswordChar = '\0';
            this.mmtbDataNascimento.PrefixSuffixText = null;
            this.mmtbDataNascimento.PromptChar = '_';
            this.mmtbDataNascimento.ReadOnly = false;
            this.mmtbDataNascimento.RejectInputOnFirstFailure = false;
            this.mmtbDataNascimento.ResetOnPrompt = true;
            this.mmtbDataNascimento.ResetOnSpace = true;
            this.mmtbDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtbDataNascimento.SelectedText = "";
            this.mmtbDataNascimento.SelectionLength = 0;
            this.mmtbDataNascimento.SelectionStart = 0;
            this.mmtbDataNascimento.ShortcutsEnabled = true;
            this.mmtbDataNascimento.Size = new System.Drawing.Size(175, 48);
            this.mmtbDataNascimento.SkipLiterals = true;
            this.mmtbDataNascimento.TabIndex = 1;
            this.mmtbDataNascimento.TabStop = false;
            this.mmtbDataNascimento.Text = "  /  /";
            this.mmtbDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtbDataNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtbDataNascimento.TrailingIcon = null;
            this.mmtbDataNascimento.UseSystemPasswordChar = false;
            this.mmtbDataNascimento.ValidatingType = null;
            // 
            // txtMatricula
            // 
            this.txtMatricula.AnimateReadOnly = false;
            this.txtMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatricula.Depth = 0;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatricula.HideSelection = true;
            this.txtMatricula.Hint = "Matrícula";
            this.txtMatricula.LeadingIcon = null;
            this.txtMatricula.Location = new System.Drawing.Point(26, 6);
            this.txtMatricula.MaxLength = 32767;
            this.txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PasswordChar = '\0';
            this.txtMatricula.PrefixSuffixText = null;
            this.txtMatricula.ReadOnly = false;
            this.txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatricula.SelectedText = "";
            this.txtMatricula.SelectionLength = 0;
            this.txtMatricula.SelectionStart = 0;
            this.txtMatricula.ShortcutsEnabled = true;
            this.txtMatricula.Size = new System.Drawing.Size(391, 48);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TabStop = false;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatricula.TrailingIcon = null;
            this.txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.Btn_Remove);
            this.tabPage2.Controls.Add(this.Btn_Edit);
            this.tabPage2.Controls.Add(this.Btn_new);
            this.tabPage2.ImageKey = "search.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(762, 348);
            this.dataGridView1.TabIndex = 13;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Remove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Remove.Depth = 0;
            this.Btn_Remove.HighEmphasis = true;
            this.Btn_Remove.Icon = null;
            this.Btn_Remove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.Btn_Remove.Location = new System.Drawing.Point(607, 375);
            this.Btn_Remove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Remove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btn_Remove.Size = new System.Drawing.Size(89, 36);
            this.Btn_Remove.TabIndex = 12;
            this.Btn_Remove.Text = "&Excluir";
            this.Btn_Remove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Remove.UseAccentColor = false;
            this.Btn_Remove.UseVisualStyleBackColor = true;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Edit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_Edit.Depth = 0;
            this.Btn_Edit.HighEmphasis = true;
            this.Btn_Edit.Icon = null;
            this.Btn_Edit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.Btn_Edit.Location = new System.Drawing.Point(518, 375);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_Edit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btn_Edit.Size = new System.Drawing.Size(81, 36);
            this.Btn_Edit.TabIndex = 11;
            this.Btn_Edit.Text = "&Editar";
            this.Btn_Edit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_Edit.UseAccentColor = false;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Btn_new
            // 
            this.Btn_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_new.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_new.Depth = 0;
            this.Btn_new.HighEmphasis = true;
            this.Btn_new.Icon = null;
            this.Btn_new.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.Btn_new.Location = new System.Drawing.Point(439, 375);
            this.Btn_new.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btn_new.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btn_new.Size = new System.Drawing.Size(71, 36);
            this.Btn_new.TabIndex = 10;
            this.Btn_new.Text = "&Novo";
            this.Btn_new.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_new.UseAccentColor = false;
            this.Btn_new.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "form (1).png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 522);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.FormProfessor_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton Btn_Remove;
        private ReaLTaiizor.Controls.MaterialButton Btn_Edit;
        private ReaLTaiizor.Controls.MaterialButton Btn_new;
        private DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TXTPID;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtFormacao;
        private ReaLTaiizor.Controls.MaterialComboBox CboxTitulacao;
    }
}