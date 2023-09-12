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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessor));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            TxtFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CboxTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            TXTPID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboEstados = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mmtbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            Btn_Remove = new ReaLTaiizor.Controls.MaterialButton();
            Btn_Edit = new ReaLTaiizor.Controls.MaterialButton();
            Btn_new = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            bindingSource1 = new BindingSource(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(776, 455);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(TxtFormacao);
            tabPage1.Controls.Add(CboxTitulacao);
            tabPage1.Controls.Add(TXTPID);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(cboEstados);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(mmtbDataNascimento);
            tabPage1.Controls.Add(txtMatricula);
            tabPage1.ImageKey = "form (1).png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtFormacao
            // 
            TxtFormacao.AnimateReadOnly = false;
            TxtFormacao.AutoCompleteMode = AutoCompleteMode.None;
            TxtFormacao.AutoCompleteSource = AutoCompleteSource.None;
            TxtFormacao.BackgroundImageLayout = ImageLayout.None;
            TxtFormacao.CharacterCasing = CharacterCasing.Normal;
            TxtFormacao.Depth = 0;
            TxtFormacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtFormacao.HideSelection = true;
            TxtFormacao.Hint = "Área de Formação";
            TxtFormacao.LeadingIcon = null;
            TxtFormacao.Location = new Point(26, 222);
            TxtFormacao.MaxLength = 32767;
            TxtFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtFormacao.Name = "TxtFormacao";
            TxtFormacao.PasswordChar = '\0';
            TxtFormacao.PrefixSuffixText = null;
            TxtFormacao.ReadOnly = false;
            TxtFormacao.RightToLeft = RightToLeft.No;
            TxtFormacao.SelectedText = "";
            TxtFormacao.SelectionLength = 0;
            TxtFormacao.SelectionStart = 0;
            TxtFormacao.ShortcutsEnabled = true;
            TxtFormacao.Size = new Size(660, 48);
            TxtFormacao.TabIndex = 12;
            TxtFormacao.TabStop = false;
            TxtFormacao.TextAlign = HorizontalAlignment.Left;
            TxtFormacao.TrailingIcon = null;
            TxtFormacao.UseSystemPasswordChar = false;
            // 
            // CboxTitulacao
            // 
            CboxTitulacao.AutoResize = false;
            CboxTitulacao.BackColor = Color.FromArgb(255, 255, 255);
            CboxTitulacao.Depth = 0;
            CboxTitulacao.DrawMode = DrawMode.OwnerDrawVariable;
            CboxTitulacao.DropDownHeight = 174;
            CboxTitulacao.DropDownStyle = ComboBoxStyle.DropDownList;
            CboxTitulacao.DropDownWidth = 121;
            CboxTitulacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CboxTitulacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CboxTitulacao.FormattingEnabled = true;
            CboxTitulacao.Hint = "Estado";
            CboxTitulacao.IntegralHeight = false;
            CboxTitulacao.ItemHeight = 43;
            CboxTitulacao.Items.AddRange(new object[] { "Graduação", "Especialização", "Mestrado", "Doutorado" });
            CboxTitulacao.Location = new Point(438, 168);
            CboxTitulacao.MaxDropDownItems = 4;
            CboxTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CboxTitulacao.Name = "CboxTitulacao";
            CboxTitulacao.Size = new Size(248, 49);
            CboxTitulacao.StartIndex = 0;
            CboxTitulacao.TabIndex = 11;
            // 
            // TXTPID
            // 
            TXTPID.AnimateReadOnly = false;
            TXTPID.AutoCompleteMode = AutoCompleteMode.None;
            TXTPID.AutoCompleteSource = AutoCompleteSource.None;
            TXTPID.BackgroundImageLayout = ImageLayout.None;
            TXTPID.CharacterCasing = CharacterCasing.Normal;
            TXTPID.Depth = 0;
            TXTPID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTPID.HideSelection = true;
            TXTPID.Hint = "ID";
            TXTPID.LeadingIcon = null;
            TXTPID.Location = new Point(619, 6);
            TXTPID.MaxLength = 32767;
            TXTPID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TXTPID.Name = "TXTPID";
            TXTPID.PasswordChar = '\0';
            TXTPID.PrefixSuffixText = null;
            TXTPID.ReadOnly = true;
            TXTPID.RightToLeft = RightToLeft.No;
            TXTPID.SelectedText = "";
            TXTPID.SelectionLength = 0;
            TXTPID.SelectionStart = 0;
            TXTPID.ShortcutsEnabled = true;
            TXTPID.Size = new Size(71, 48);
            TXTPID.TabIndex = 10;
            TXTPID.TabStop = false;
            TXTPID.TextAlign = HorizontalAlignment.Left;
            TXTPID.TrailingIcon = null;
            TXTPID.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(488, 333);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(612, 333);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(85, 36);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "&Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboEstados
            // 
            cboEstados.AutoResize = false;
            cboEstados.BackColor = Color.FromArgb(255, 255, 255);
            cboEstados.Depth = 0;
            cboEstados.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstados.DropDownHeight = 174;
            cboEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstados.DropDownWidth = 121;
            cboEstados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstados.FormattingEnabled = true;
            cboEstados.Hint = "Estado";
            cboEstados.IntegralHeight = false;
            cboEstados.ItemHeight = 43;
            cboEstados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstados.Location = new Point(215, 167);
            cboEstados.MaxDropDownItems = 4;
            cboEstados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstados.Name = "cboEstados";
            cboEstados.Size = new Size(202, 49);
            cboEstados.StartIndex = 0;
            cboEstados.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(26, 168);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(183, 48);
            txtCidade.TabIndex = 5;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(436, 114);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(250, 48);
            txtBairro.TabIndex = 4;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(26, 114);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(391, 48);
            txtEndereco.TabIndex = 3;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
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
            txtNome.Location = new Point(26, 60);
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
            txtNome.Size = new Size(662, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // mmtbDataNascimento
            // 
            mmtbDataNascimento.AllowPromptAsInput = true;
            mmtbDataNascimento.AnimateReadOnly = false;
            mmtbDataNascimento.AsciiOnly = false;
            mmtbDataNascimento.BackgroundImageLayout = ImageLayout.None;
            mmtbDataNascimento.BeepOnError = false;
            mmtbDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbDataNascimento.Depth = 0;
            mmtbDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mmtbDataNascimento.HidePromptOnLeave = false;
            mmtbDataNascimento.HideSelection = true;
            mmtbDataNascimento.Hint = "Data de Nascimento";
            mmtbDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            mmtbDataNascimento.LeadingIcon = null;
            mmtbDataNascimento.Location = new Point(438, 6);
            mmtbDataNascimento.Mask = "99/99/9999";
            mmtbDataNascimento.MaxLength = 32767;
            mmtbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbDataNascimento.Name = "mmtbDataNascimento";
            mmtbDataNascimento.PasswordChar = '\0';
            mmtbDataNascimento.PrefixSuffixText = null;
            mmtbDataNascimento.PromptChar = '_';
            mmtbDataNascimento.ReadOnly = false;
            mmtbDataNascimento.RejectInputOnFirstFailure = false;
            mmtbDataNascimento.ResetOnPrompt = true;
            mmtbDataNascimento.ResetOnSpace = true;
            mmtbDataNascimento.RightToLeft = RightToLeft.No;
            mmtbDataNascimento.SelectedText = "";
            mmtbDataNascimento.SelectionLength = 0;
            mmtbDataNascimento.SelectionStart = 0;
            mmtbDataNascimento.ShortcutsEnabled = true;
            mmtbDataNascimento.Size = new Size(175, 48);
            mmtbDataNascimento.SkipLiterals = true;
            mmtbDataNascimento.TabIndex = 1;
            mmtbDataNascimento.TabStop = false;
            mmtbDataNascimento.Text = "  /  /";
            mmtbDataNascimento.TextAlign = HorizontalAlignment.Left;
            mmtbDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbDataNascimento.TrailingIcon = null;
            mmtbDataNascimento.UseSystemPasswordChar = false;
            mmtbDataNascimento.ValidatingType = null;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(26, 6);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(391, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            txtMatricula.Click += mtbeMatricula_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(Btn_Remove);
            tabPage2.Controls.Add(Btn_Edit);
            tabPage2.Controls.Add(Btn_new);
            tabPage2.ImageKey = "search.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(762, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // Btn_Remove
            // 
            Btn_Remove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_Remove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn_Remove.Depth = 0;
            Btn_Remove.HighEmphasis = true;
            Btn_Remove.Icon = null;
            Btn_Remove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            Btn_Remove.Location = new Point(607, 375);
            Btn_Remove.Margin = new Padding(4, 6, 4, 6);
            Btn_Remove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            Btn_Remove.Name = "Btn_Remove";
            Btn_Remove.NoAccentTextColor = Color.Empty;
            Btn_Remove.Size = new Size(89, 36);
            Btn_Remove.TabIndex = 12;
            Btn_Remove.Text = "&Excluir";
            Btn_Remove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn_Remove.UseAccentColor = false;
            Btn_Remove.UseVisualStyleBackColor = true;
            Btn_Remove.Click += Btn_Remove_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_Edit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn_Edit.Depth = 0;
            Btn_Edit.HighEmphasis = true;
            Btn_Edit.Icon = null;
            Btn_Edit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            Btn_Edit.Location = new Point(518, 375);
            Btn_Edit.Margin = new Padding(4, 6, 4, 6);
            Btn_Edit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.NoAccentTextColor = Color.Empty;
            Btn_Edit.Size = new Size(81, 36);
            Btn_Edit.TabIndex = 11;
            Btn_Edit.Text = "&Editar";
            Btn_Edit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn_Edit.UseAccentColor = false;
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_new
            // 
            Btn_new.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_new.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn_new.Depth = 0;
            Btn_new.HighEmphasis = true;
            Btn_new.Icon = null;
            Btn_new.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            Btn_new.Location = new Point(439, 375);
            Btn_new.Margin = new Padding(4, 6, 4, 6);
            Btn_new.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            Btn_new.Name = "Btn_new";
            Btn_new.NoAccentTextColor = Color.Empty;
            Btn_new.Size = new Size(71, 36);
            Btn_new.TabIndex = 10;
            Btn_new.Text = "&Novo";
            Btn_new.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn_new.UseAccentColor = false;
            Btn_new.UseVisualStyleBackColor = true;
            Btn_new.Click += materialButton1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form (1).png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FormProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 522);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FormProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Professores";
            Load += FormAluno_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
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