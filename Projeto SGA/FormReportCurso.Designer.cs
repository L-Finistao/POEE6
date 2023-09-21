namespace SGA
{
    partial class FormReportCurso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TxtAgrupamento = new System.Windows.Forms.GroupBox();
            this.CboAgrupa = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TxtDataCriacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TxtAgrupamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtAgrupamento);
            this.groupBox1.Controls.Add(this.TxtDataCriacao);
            this.groupBox1.Location = new System.Drawing.Point(19, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVisualizar.Depth = 0;
            this.btnVisualizar.HighEmphasis = true;
            this.btnVisualizar.Icon = null;
            this.btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVisualizar.Location = new System.Drawing.Point(523, 290);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVisualizar.Size = new System.Drawing.Size(112, 36);
            this.btnVisualizar.TabIndex = 13;
            this.btnVisualizar.Text = "&VISUALIZAR";
            this.btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVisualizar.UseAccentColor = false;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(647, 290);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(97, 36);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "&IMPRIMIR";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.cboTipo.Location = new System.Drawing.Point(259, 20);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(474, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboImpressora);
            this.groupBox2.Location = new System.Drawing.Point(18, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impressora";
            // 
            // CboImpressora
            // 
            this.CboImpressora.AutoResize = false;
            this.CboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboImpressora.Depth = 0;
            this.CboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CboImpressora.DropDownHeight = 174;
            this.CboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboImpressora.DropDownWidth = 121;
            this.CboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CboImpressora.FormattingEnabled = true;
            this.CboImpressora.Hint = "Impressora";
            this.CboImpressora.IntegralHeight = false;
            this.CboImpressora.ItemHeight = 43;
            this.CboImpressora.Location = new System.Drawing.Point(6, 33);
            this.CboImpressora.MaxDropDownItems = 4;
            this.CboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CboImpressora.Name = "CboImpressora";
            this.CboImpressora.Size = new System.Drawing.Size(709, 49);
            this.CboImpressora.StartIndex = 0;
            this.CboImpressora.TabIndex = 9;
            // 
            // TxtAgrupamento
            // 
            this.TxtAgrupamento.Controls.Add(this.CboAgrupa);
            this.TxtAgrupamento.Location = new System.Drawing.Point(17, 89);
            this.TxtAgrupamento.Name = "TxtAgrupamento";
            this.TxtAgrupamento.Size = new System.Drawing.Size(721, 94);
            this.TxtAgrupamento.TabIndex = 9;
            this.TxtAgrupamento.TabStop = false;
            this.TxtAgrupamento.Text = "Agrupamento";
            // 
            // CboAgrupa
            // 
            this.CboAgrupa.AutoResize = false;
            this.CboAgrupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboAgrupa.Depth = 0;
            this.CboAgrupa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CboAgrupa.DropDownHeight = 174;
            this.CboAgrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAgrupa.DropDownWidth = 121;
            this.CboAgrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CboAgrupa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CboAgrupa.FormattingEnabled = true;
            this.CboAgrupa.Hint = "Agrupamento";
            this.CboAgrupa.IntegralHeight = false;
            this.CboAgrupa.ItemHeight = 43;
            this.CboAgrupa.Items.AddRange(new object[] {
            "Nenhum",
            "Data de Criação",
            "Tipo"});
            this.CboAgrupa.Location = new System.Drawing.Point(6, 33);
            this.CboAgrupa.MaxDropDownItems = 4;
            this.CboAgrupa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CboAgrupa.Name = "CboAgrupa";
            this.CboAgrupa.Size = new System.Drawing.Size(709, 49);
            this.CboAgrupa.StartIndex = 0;
            this.CboAgrupa.TabIndex = 9;
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
            this.TxtDataCriacao.Location = new System.Drawing.Point(24, 21);
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
            this.TxtDataCriacao.Size = new System.Drawing.Size(224, 48);
            this.TxtDataCriacao.TabIndex = 7;
            this.TxtDataCriacao.TabStop = false;
            this.TxtDataCriacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDataCriacao.TrailingIcon = null;
            this.TxtDataCriacao.UseSystemPasswordChar = false;
            // 
            // FormReportCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cursos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TxtAgrupamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox CboImpressora;
        private GroupBox TxtAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox CboAgrupa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtDataCriacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
    }
}