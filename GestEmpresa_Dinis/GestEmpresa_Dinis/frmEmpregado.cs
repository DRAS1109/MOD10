using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEmpresa_Dinis
{
    public partial class frmEmpregado : Form
    {
        public Empregado Emp { get; private set; }

        public frmEmpregado(Empregado _emp)
        {
            InitializeComponent();

            Emp = _emp;
            // Ver/Editar o empregado
            if (Emp != null)
            {
                Text = "Ver/Editar Empregado";
                chkEditar.Enabled = true;
                chkEditar.Checked = false;
                updateChkEditar(false);
            }

            // Novo empregado porque Emp não foi ainda inicializado
            else
            {
                Text = "Novo Empregado";
                chkEditar.Enabled = false;
                chkEditar.Checked = true;
                updateChkEditar(true);
            }

            // Se clicar ENTER ou no botão OK, assume a ação OK (Aceitar os dados de formulario)
            AcceptButton = btnOk;

            // Se clicar ESQ ou no botão Cancelar, assume a ação Cancel (Ignorar os dados de )
            CancelButton = btnCancel;

            // Ignorar a validação dos dados caso click no botão cancelar
            btnCancel.CausesValidation = false;

            // Fecha a janela e retorna a mensagem da ação correspondente
            btnCancel.DialogResult = DialogResult.Cancel;
            btnOk.DialogResult = DialogResult.OK;

            cmbCargo.DataSource = Empresa.cargos;
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void updateChkEditar(bool chk)
        {
            cmbCargo.Enabled = chk;
            dtpDataNasc.Enabled = chk;

            // Enabled de todas as TextBox do formulário
            foreach (Control c in Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            // Enabled de todas as TextBox dos paineis
            foreach (Control c in pnlAnalista.Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            foreach (Control c in pnlAnalista.Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            // Enabled de todas as TextBox do grupo da morada
            foreach (Control c in grpMorada.Controls)
                if (c is TextBox)
                    c.Enabled = chk;

            // O ID é de numeração automática. Não pode ter permissão para o editar
            txtID.Enabled = false;
        }

        private void frmEmpregado_Load(object sender, EventArgs e)
        {
            if (Emp is Programador)
                cmbCargo.SelectedIndex = Empresa.CARGO_PROGRAMADOR;

            else if (Emp is Analista)
                cmbCargo.SelectedIndex = Empresa.CARGO_ANALISTA;

            else
                cmbCargo.SelectedIndex = Empresa.CARGO_EMPREGADO;

            pnlProgramador.Visible = (Emp is Programador) || (Emp == null);
            pnlAnalista.Visible = Emp is Analista;

            if (Emp != null)
            {
                txtNome.Text = Emp.Nome;
                txtID.Text = Emp.ValorID.ToString();
                txtEmail.Text = Emp.EMail;
                txtTelefone.Text = Emp.Telefone;

                if (Emp.DatNasc == new System.DateTime())
                    // Neste caso não podemos igualar value com 01/01/0001 por ser uma data inválida
                    dtpDataNasc.Value = DateTime.Now.Date;

                else
                    dtpDataNasc.Value = Emp.DatNasc.Date;

                txtRua.Text = Emp.MoradaAtual.Rua;
                txtCodPostal.Text = Emp.MoradaAtual.CodPostal;
                txtLocalidade.Text = Emp.MoradaAtual.Localidade;

                if (Emp is Programador)
                    txtEspecialidade.Text = ((Programador)Emp).Especialidade;

                else if (Emp is Analista)
                    txtProjeto.Text = ((Analista)Emp).Projeto;
            }

        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            updateChkEditar(chkEditar.Checked);
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlProgramador.Visible = cmbCargo.SelectedIndex == Empresa.CARGO_PROGRAMADOR;
            pnlAnalista.Visible = cmbCargo.SelectedIndex == Empresa.CARGO_ANALISTA;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Cria uma nova instancia da classe se for um novo empregado ou se foi alterado
            // na edição o cargo do empregado (neste caso, é incrementado o valor do ID)

            if (cmbCargo.SelectedIndex == Empresa.CARGO_PROGRAMADOR)
            {
                if (Emp == null || !(Emp is Programador))
                    Emp = new Programador(txtEspecialidade.Text, txtNome.Text, dtpDataNasc.Value, txtEmail.Text, 
                        txtTelefone.Text, new Morada(txtRua.Text, txtLocalidade.Text, txtCodPostal.Text));
            }

            else if (cmbCargo.SelectedIndex == Empresa.CARGO_ANALISTA)
            {
                if (Emp == null || !(Emp is Analista))
                    Emp = new Analista(txtProjeto.Text, txtNome.Text, dtpDataNasc.Value, txtEmail.Text, 
                        txtTelefone.Text, new Morada(txtRua.Text, txtLocalidade.Text, txtCodPostal.Text));
            }

            else
            {
                // if (Emp == null || !(Emp is Empregado))
                // A instrução anterior não funciona porque o Programador e o anailsta também são empregados

                if (Emp == null || !(Emp is Programador) || !(Emp is Analista))
                    Emp = new Empregado(txtNome.Text, dtpDataNasc.Value, txtEmail.Text,
                        txtTelefone.Text, new Morada(txtRua.Text, txtLocalidade.Text, txtCodPostal.Text));
            }

            updateDataEmp();
        }

        private void updateDataEmp()
        {
            if (Emp == null) return;

            // Atualizar os dados comuns do empregado
            Emp.Nome = txtNome.Text;
            Emp.EMail = txtEmail.Text;
            Emp.Telefone = txtTelefone.Text;
            Emp.DatNasc = dtpDataNasc.Value;
            Emp.MoradaAtual = new Morada(txtRua.Text, txtLocalidade.Text, txtCodPostal.Text);

            if (Emp is Programador)
            {
                // Atualiza os dados especificos do programnador
                // Nota: primeiro é necessario converter o Empregado para programador com o cast (programador)
                // ((Programador.Emp).Especialidade não é o mesmo que (Programador)Emp.Especialidade, Porquê?
                ((Programador)Emp).Especialidade = txtEspecialidade.Text;
            }

            else if (Emp is Analista)
            {
                ((Analista)Emp).Projeto = txtProjeto.Text;
            }
        }
    }
}
