namespace SGA
{
    partial class FormCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurso));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            TxtDataCriacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TxtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabPage1.Controls.Add(TxtDataCriacao);
            tabPage1.Controls.Add(TxtID);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(cboTipo);
            tabPage1.Controls.Add(txtNome);
            tabPage1.ImageKey = "form (1).png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtDataCriacao
            // 
            TxtDataCriacao.AnimateReadOnly = false;
            TxtDataCriacao.AutoCompleteMode = AutoCompleteMode.None;
            TxtDataCriacao.AutoCompleteSource = AutoCompleteSource.None;
            TxtDataCriacao.BackgroundImageLayout = ImageLayout.None;
            TxtDataCriacao.CharacterCasing = CharacterCasing.Normal;
            TxtDataCriacao.Depth = 0;
            TxtDataCriacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtDataCriacao.HideSelection = true;
            TxtDataCriacao.Hint = "Data de Criação";
            TxtDataCriacao.LeadingIcon = null;
            TxtDataCriacao.Location = new Point(524, 59);
            TxtDataCriacao.MaxLength = 32767;
            TxtDataCriacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtDataCriacao.Name = "TxtDataCriacao";
            TxtDataCriacao.PasswordChar = '\0';
            TxtDataCriacao.PrefixSuffixText = null;
            TxtDataCriacao.ReadOnly = false;
            TxtDataCriacao.RightToLeft = RightToLeft.No;
            TxtDataCriacao.SelectedText = "";
            TxtDataCriacao.SelectionLength = 0;
            TxtDataCriacao.SelectionStart = 0;
            TxtDataCriacao.ShortcutsEnabled = true;
            TxtDataCriacao.Size = new Size(206, 48);
            TxtDataCriacao.TabIndex = 11;
            TxtDataCriacao.TabStop = false;
            TxtDataCriacao.TextAlign = HorizontalAlignment.Left;
            TxtDataCriacao.TrailingIcon = null;
            TxtDataCriacao.UseSystemPasswordChar = false;
            // 
            // TxtID
            // 
            TxtID.AnimateReadOnly = false;
            TxtID.AutoCompleteMode = AutoCompleteMode.None;
            TxtID.AutoCompleteSource = AutoCompleteSource.None;
            TxtID.BackgroundImageLayout = ImageLayout.None;
            TxtID.CharacterCasing = CharacterCasing.Normal;
            TxtID.Depth = 0;
            TxtID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtID.HideSelection = true;
            TxtID.Hint = "ID";
            TxtID.LeadingIcon = null;
            TxtID.Location = new Point(615, 6);
            TxtID.MaxLength = 32767;
            TxtID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtID.Name = "TxtID";
            TxtID.PasswordChar = '\0';
            TxtID.PrefixSuffixText = null;
            TxtID.ReadOnly = true;
            TxtID.RightToLeft = RightToLeft.No;
            TxtID.SelectedText = "";
            TxtID.SelectionLength = 0;
            TxtID.SelectionStart = 0;
            TxtID.ShortcutsEnabled = true;
            TxtID.Size = new Size(115, 48);
            TxtID.TabIndex = 10;
            TxtID.TabStop = false;
            TxtID.TextAlign = HorizontalAlignment.Left;
            TxtID.TrailingIcon = null;
            TxtID.UseSystemPasswordChar = false;
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
            // cboTipo
            // 
            cboTipo.AutoResize = false;
            cboTipo.BackColor = Color.FromArgb(255, 255, 255);
            cboTipo.Depth = 0;
            cboTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipo.DropDownHeight = 174;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.DropDownWidth = 121;
            cboTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Hint = "Estado";
            cboTipo.IntegralHeight = false;
            cboTipo.ItemHeight = 43;
            cboTipo.Items.AddRange(new object[] { "Técnico", "Tecnólogo", "Bacharelado", "Licenciatura", "Pós-Graduação" });
            cboTipo.Location = new Point(32, 59);
            cboTipo.MaxDropDownItems = 4;
            cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(486, 49);
            cboTipo.StartIndex = 0;
            cboTipo.TabIndex = 6;
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
            txtNome.Location = new Point(32, 6);
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
            txtNome.Size = new Size(577, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 522);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FormCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
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

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton Btn_Remove;
        private ReaLTaiizor.Controls.MaterialButton Btn_Edit;
        private ReaLTaiizor.Controls.MaterialButton Btn_new;
        private DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtID;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtDataCriacao;
    }
}