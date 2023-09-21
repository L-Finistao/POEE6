using SGA.Properties;
using ReaLTaiizor.Forms;

namespace SGA
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
            //  this.Icon = new Icon("D:\\Lucas\\projeto3CadastroAluno\\ifsp_icon.ico");
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { e.Cancel = true; }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                FormAluno formAluno = new FormAluno();
                formAluno.MdiParent = this;//o cadastro de aluno está contido no pricipal
                formAluno.Show();//permite abrir varios formulario, diferente do dialog ele trava em um formulario até ele ser fechado
                                 //drawerTabControl para colocar o roda pe
                                 //para adiionar uma imagem como icone:
                /*na senha:
                 LeadingIcon -> adiciona imagem

                colocar a imagem do ladinho:
                adicionar uma componente imageList -> adiciono as imagens neles
                clico no tab e seleciono o ImageList que foi adicionada
                depois vou em image key e coloco as imagens em cada um dos tabs
                depois clico no form e seleciono DrawerShowIcon... -> true

                 */
            }
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                FormCurso formCurso = new FormCurso();
                formCurso.MdiParent = this;
                formCurso.Show();
                                 
                                 
               
            }
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                FormProfessor formProfessor= new FormProfessor();
                formProfessor.MdiParent = this;
                formProfessor.Show();
                               
            }
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.MdiParent = this;
            formReport.Show();
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReportCurso formReportCurso = new FormReportCurso();
            formReportCurso.MdiParent = this;   
            formReportCurso.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportProfessor formReportProfessor= new FormReportProfessor();
            formReportProfessor.MdiParent= this;
            formReportProfessor.Show();
        }
    }
}