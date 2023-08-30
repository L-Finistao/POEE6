using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
namespace projeto3CadastroAluno
{
    public partial class FormAluno : MaterialForm
    {
        bool isAlteracao = false;

        int IndexSelect = 0;
        string cs = @"server=localhost;" +
                     "uid=root;" +
                     "pws=;" + 
                     "database=academico";
        public FormAluno()
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
            if (!isAlteracao)
            {
                var sql = "INSERT INTO aluno" +
                          "(matricula,dt_nascimento,nome,endereco,bairro,cidade,estado,senha)" +
                          "VALUES" + "(@matricula,@dt_nascimento,@nome,@endereco,@bairro,@cidade,@estado,@senha)";
                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@matricula",txtMatricula.Text);
                DateTime.TryParse(mmtbDataNascimento.Text, out var datanascimento);
                cmd.Parameters.AddWithValue("@dt_nascimento", datanascimento);
                cmd.Parameters.AddWithValue("@nome",txtNome.Text);
                cmd.Parameters.AddWithValue("@endereco",txtEndereco.Text);
                cmd.Parameters.AddWithValue("@bairro",txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade",txtCidade.Text);
                cmd.Parameters.AddWithValue("@estado",cboEstados.Text);
                cmd.Parameters.AddWithValue("@senha",txtSenha.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            else
            {
                
            }
            Limpa_Campos();
        }


        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereco é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            if (!DateTime.TryParse(mmtbDataNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de nascimento é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mmtbDataNascimento.Focus();
                return false;
            }

            return true;
        }

        private void CarregaGrid()
        {

            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var cmd = new MySqlCommand(sql, con);
            cmd.CommandText = sql;
            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void listViewAlunos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if(e.ItemIndex %2 != 0)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            materialTabControl1.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        private void Limpa_Campos()
        {
            isAlteracao = false;
            foreach(var controls in tabPage1.Controls)
            {
                if(controls is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)controls).Clear();
   
                }
                if(controls is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)controls).Clear();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Cancelar", "IFSP",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
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
            
    
        }

        private void listViewAlunos_MouseClick(object sender, MouseEventArgs e)
        {
            Edit();
        }

        private void Deletar()
        {
        }
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
          
        }

        private void listViewAlunos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault= true;
        }
    }
}
