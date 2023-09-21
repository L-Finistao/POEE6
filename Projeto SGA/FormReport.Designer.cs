namespace SGA
{
    partial class FormReport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TxtAgrupamento = new System.Windows.Forms.GroupBox();
            this.CboAgrupa = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboEstados = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TxtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TxtAgrupamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtAgrupamento);
            this.groupBox1.Controls.Add(this.cboEstados);
            this.groupBox1.Controls.Add(this.TxtCidade);
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
            this.btnVisualizar.Location = new System.Drawing.Point(517, 290);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVisualizar.Size = new System.Drawing.Size(112, 36);
            this.btnVisualizar.TabIndex = 15;
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
            this.btnSalvar.Location = new System.Drawing.Point(641, 290);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(97, 36);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "&IMPRIMIR";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.CboImpressora.SelectedIndexChanged += new System.EventHandler(this.CboImpressora_SelectedIndexChanged);
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
            "Cidade",
            "Estado"});
            this.CboAgrupa.Location = new System.Drawing.Point(6, 33);
            this.CboAgrupa.MaxDropDownItems = 4;
            this.CboAgrupa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CboAgrupa.Name = "CboAgrupa";
            this.CboAgrupa.Size = new System.Drawing.Size(709, 49);
            this.CboAgrupa.StartIndex = 0;
            this.CboAgrupa.TabIndex = 9;
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
            "",
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
            this.cboEstados.Location = new System.Drawing.Point(523, 21);
            this.cboEstados.MaxDropDownItems = 4;
            this.cboEstados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(202, 49);
            this.cboEstados.StartIndex = 0;
            this.cboEstados.TabIndex = 8;
            // 
            // TxtCidade
            // 
            this.TxtCidade.AnimateReadOnly = false;
            this.TxtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCidade.Depth = 0;
            this.TxtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCidade.HideSelection = true;
            this.TxtCidade.Hint = "Cidade";
            this.TxtCidade.LeadingIcon = null;
            this.TxtCidade.Location = new System.Drawing.Point(17, 22);
            this.TxtCidade.MaxLength = 32767;
            this.TxtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.PasswordChar = '\0';
            this.TxtCidade.PrefixSuffixText = null;
            this.TxtCidade.ReadOnly = false;
            this.TxtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCidade.SelectedText = "";
            this.TxtCidade.SelectionLength = 0;
            this.TxtCidade.SelectionStart = 0;
            this.TxtCidade.ShortcutsEnabled = true;
            this.TxtCidade.Size = new System.Drawing.Size(500, 48);
            this.TxtCidade.TabIndex = 7;
            this.TxtCidade.TabStop = false;
            this.TxtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCidade.TrailingIcon = null;
            this.TxtCidade.UseSystemPasswordChar = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Alunos";
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
        private ReaLTaiizor.Controls.MaterialComboBox cboEstados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtCidade;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
    }
}