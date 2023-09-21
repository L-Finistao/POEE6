using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace SGA
{
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;

        string IndexSelect = "1";

        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pws=;" +
                    "database=academico";

        public FormCurso()
        {
            InitializeComponent();
        }

        private void mtbeMatricula_Click(object sender, EventArgs e)
        {

        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }




        private void Salvar()
        {

            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (!isAlteracao)
            {
                sql = "INSERT INTO Curso" +
                     "(nome, tipo, ano_criacao)" +
                     "VALUES" + "(@nome, @tipo,@ano_criacao)";

            }
            else
            {
                sql = "UPDATE Curso SET `nome` = @nome, `tipo` = @tipo, `ano_criacao` = @ano_criacao WHERE `id` = @id;";

            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tipo", cboTipo.Text);
            cmd.Parameters.AddWithValue("@ano_criacao", TxtDataCriacao.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", TxtID.Text);

            }

            
            if (!isAlteracao)
            {
               
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@tipo", cboTipo.Text);
                cmd.Parameters.AddWithValue("@ano_criacao", TxtDataCriacao.Text);
            }

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Limpa_Campos();
        }



        private bool ValidarFormulario()
        {

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtDataCriacao.Text))
            {
                MessageBox.Show("Ano de Criação é Obrigatorio", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }



            return true;
        }

        private void CarregaGrid()
        {

            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM Curso";
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandText = sql;
            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void listViewAlunos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.ItemIndex % 2 != 0)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            materialTabControl1.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void Limpa_Campos()
        {
            isAlteracao = false;
            foreach (var controls in tabPage1.Controls)
            {
                if (controls is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)controls).Clear();

                }

                if (controls is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)controls).Clear();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Cancelar", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpa_Campos();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                isAlteracao = true;
                var item = dataGridView1.SelectedRows[0];
                TxtID.Text = item.Cells["id"].Value.ToString();
                txtNome.Text = item.Cells["nome"].Value.ToString();
                TxtDataCriacao.Text = item.Cells["ano_criacao"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione Algum Curso", "IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void listViewAlunos_MouseClick(object sender, MouseEventArgs e)
        {
            Edit();
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            if (!isAlteracao)
            {
                var sql = "DELETE FROM Curso WHERE id = @id";

                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja Realmente Cancelar", "IFSP", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }


            void listViewAlunos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
            {
                e.DrawDefault = true;
            }


            void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                Edit();
            }

        }

        private void dataGridView1_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }
    }
}
