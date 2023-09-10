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

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent= this;//o cadastro de aluno está contido no pricipal
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall) { e.Cancel = true; }
        }
    }
}