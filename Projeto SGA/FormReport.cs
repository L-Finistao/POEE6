using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;

namespace SGA
{
    public partial class FormReport : MaterialForm
    {

        string cs = @"server=localhost;" +
                 "uid=root;" +
                 "pws=;" +
                 "database=academico";
        public FormReport()
        {
            InitializeComponent();
            Carrega_Impressora();
        }

        string TempPrint;
        private void Carrega_Impressora()
        {
            foreach(string print in PrinterSettings.InstalledPrinters)
            {
                CboImpressora.Items.Add(print);
            }
            CboImpressora.SelectedIndex= 0;
        }


        private void Monta_Relatorio()
        {

            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno where 1 = 1 ";
            if (cboEstados.Text != "")
                sql += "and estado = @estado";
            if (TxtCidade.Text != "")
                sql += "and cidade = @cidade";
            
            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);
            if (cboEstados.Text != "")
                sqlad.SelectCommand.Parameters.AddWithValue("@estado", cboEstados.Text);
            if (TxtCidade.Text != "")
                sqlad.SelectCommand.Parameters.AddWithValue("@cidade", TxtCidade.Text);
           
            var dt = new DataTable();
            sqlad.Fill(dt);
            con.Close();
            //Iniico Geração PDF

            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush = PdfBrushes.Black;
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Ariel", 16f, FontStyle.Bold));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatorio de Alunos", font, brush, page.Canvas.ClientSize.Width / 2, y,format);
            
            PdfTable table= new PdfTable(); 
            table.Style.CellPadding= 2;
            table.Style.BorderPen = new PdfPen(brush, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.ShowHeader= true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.DataSource = dt;
            foreach(PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center,PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(1,y+font.Size + 10));
            
            doc.SaveToFile("Relatorio_Alunos.pdf");

        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Monta_Relatorio();

            Process.Start(new ProcessStartInfo { FileName = @"Relatorio_Alunos.pdf", UseShellExecute = true });


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno where 1 = 1 ";
            if (cboEstados.Text != "")
                sql += "and estado = @estado";
            if (TxtCidade.Text != "")
                sql += "and cidade = @cidade";

            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);
            if (cboEstados.Text != "")
                sqlad.SelectCommand.Parameters.AddWithValue("@estado", cboEstados.Text);
            if (TxtCidade.Text != "")
                sqlad.SelectCommand.Parameters.AddWithValue("@cidade", TxtCidade.Text);

            var dt = new DataTable();
            sqlad.Fill(dt);
            con.Close();
            //Iniico Geração PDF

            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush = PdfBrushes.Black;
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Ariel", 16f, FontStyle.Bold));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatorio de Alunos", font, brush, page.Canvas.ClientSize.Width / 2, y, format);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(1, y + font.Size + 10));

            doc.LoadFromFile("Relatorio_Alunos.pdf");
            doc.PrintSettings.PrinterName = CboImpressora.Text;

            doc.LoadFromFile(@"Relatorio_Alunos.pdf");
            doc.PrintSettings.PrintController = new StandardPrintController();
            doc.Print();



        }

        private void CboImpressora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
