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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurso));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtDataCriacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.TxtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            this.tabPage1.Controls.Add(this.TxtDataCriacao);
            this.tabPage1.Controls.Add(this.TxtID);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.cboTipo);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.ImageKey = "form (1).png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtDataCriacao
            // 
            this.TxtDataCriacao.AnimateReadOnly = false;
            this.TxtDataCriacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtDataCriacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtDataCriacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDataCriacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDataCriacao.Depth = 0;
            this.TxtDataCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDataCriacao.HideSelection = true;
            this.TxtDataCriacao.Hint = "Data de Criação";
            this.TxtDataCriacao.LeadingIcon = null;
            this.TxtDataCriacao.Location = new System.Drawing.Point(524, 59);
            this.TxtDataCriacao.MaxLength = 32767;
            this.TxtDataCriacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtDataCriacao.Name = "TxtDataCriacao";
            this.TxtDataCriacao.PasswordChar = '\0';
            this.TxtDataCriacao.PrefixSuffixText = null;
            this.TxtDataCriacao.ReadOnly = false;
            this.TxtDataCriacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDataCriacao.SelectedText = "";
            this.TxtDataCriacao.SelectionLength = 0;
            this.TxtDataCriacao.SelectionStart = 0;
            this.TxtDataCriacao.ShortcutsEnabled = true;
            this.TxtDataCriacao.Size = new System.Drawing.Size(206, 48);
            this.TxtDataCriacao.TabIndex = 11;
            this.TxtDataCriacao.TabStop = false;
            this.TxtDataCriacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDataCriacao.TrailingIcon = null;
            this.TxtDataCriacao.UseSystemPasswordChar = false;
            // 
            // TxtID
            // 
            this.TxtID.AnimateReadOnly = false;
            this.TxtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtID.Depth = 0;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtID.HideSelection = true;
            this.TxtID.Hint = "ID";
            this.TxtID.LeadingIcon = null;
            this.TxtID.Location = new System.Drawing.Point(615, 6);
            this.TxtID.MaxLength = 32767;
            this.TxtID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.PrefixSuffixText = null;
            this.TxtID.ReadOnly = true;
            this.TxtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtID.SelectedText = "";
            this.TxtID.SelectionLength = 0;
            this.TxtID.SelectionStart = 0;
            this.TxtID.ShortcutsEnabled = true;
            this.TxtID.Size = new System.Drawing.Size(115, 48);
            this.TxtID.TabIndex = 10;
            this.TxtID.TabStop = false;
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtID.TrailingIcon = null;
            this.TxtID.UseSystemPasswordChar = false;
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
            this.btnCancelar.Size = new System.Drawing.Size(85, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Salvar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnSalvar.Size = new System.Drawing.Size(105, 36);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Cancelar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.AutoResize = false;
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTipo.Depth = 0;
            this.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipo.DropDownHeight = 174;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DropDownWidth = 121;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Hint = "Tipo";
            this.cboTipo.IntegralHeight = false;
            this.cboTipo.ItemHeight = 43;
            this.cboTipo.Items.AddRange(new object[] {
            "Técnico",
            "Tecnólogo",
            "Bacharelado",
            "Licenciatura",
            "Pós-Graduação"});
            this.cboTipo.Location = new System.Drawing.Point(32, 59);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(486, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 6;
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
            this.txtNome.Location = new System.Drawing.Point(32, 6);
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
            this.txtNome.Size = new System.Drawing.Size(577, 48);
            this.txtNome.TabIndex = 2;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(762, 150);
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
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 522);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Curso";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

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