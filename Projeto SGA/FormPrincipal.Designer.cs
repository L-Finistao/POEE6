﻿namespace SGA
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem2,
            this.cursoToolStripMenuItem2,
            this.professorToolStripMenuItem1});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.opçõesToolStripMenuItem.Text = "Cadastros";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem1,
            this.cursoToolStripMenuItem1,
            this.professoresToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // alunosToolStripMenuItem1
            // 
            this.alunosToolStripMenuItem1.Name = "alunosToolStripMenuItem1";
            this.alunosToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.alunosToolStripMenuItem1.Text = "Alunos";
            this.alunosToolStripMenuItem1.Click += new System.EventHandler(this.alunosToolStripMenuItem1_Click);
            // 
            // cursoToolStripMenuItem1
            // 
            this.cursoToolStripMenuItem1.Name = "cursoToolStripMenuItem1";
            this.cursoToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.cursoToolStripMenuItem1.Text = "Curso";
            this.cursoToolStripMenuItem1.Click += new System.EventHandler(this.cursoToolStripMenuItem1_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem2
            // 
            this.alunosToolStripMenuItem2.Name = "alunosToolStripMenuItem2";
            this.alunosToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.alunosToolStripMenuItem2.Text = "Alunos";
            this.alunosToolStripMenuItem2.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem2
            // 
            this.cursoToolStripMenuItem2.Name = "cursoToolStripMenuItem2";
            this.cursoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cursoToolStripMenuItem2.Text = "Curso";
            this.cursoToolStripMenuItem2.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.professorToolStripMenuItem1.Text = "Professor";
            this.professorToolStripMenuItem1.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGA.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1062, 660);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "IFSP - Sistema de Gerenciamento Acadêmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem1;
        private ToolStripMenuItem cursoToolStripMenuItem1;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem2;
        private ToolStripMenuItem cursoToolStripMenuItem2;
        private ToolStripMenuItem professorToolStripMenuItem1;
    }
}