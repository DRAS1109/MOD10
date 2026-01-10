namespace GestEmpresa_Dinis
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Alterar o tipo de janela
            Text = Empresa.appNome + " " + Empresa.appVer;
            dgvDados.DataSource = Empresa.emp;

            // ***** Alterar algumas propriedades da DataGridView
            // Aplica a seleção para toda a linha
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Desativar seleção multipla de linhas
            dgvDados.MultiSelect = false;

            // Esconder o cabeçalho da linha
            dgvDados.RowHeadersVisible = false;

            // Aplicar a DataGridView apenas para leitura
            // Não permite a edição das células
            // Como as propriedades ValorId, Nome abreviado, Localidade e Cargo são propriedades
            // somente de leitura (get) não faz sentido permitir a escrita da DataGrigdView
            dgvDados.ReadOnly = true;

            // Não tem permissão para adicionar uma nova linha
            dgvDados.AllowUserToAddRows = false;

            // Não tem permissão para remover uma linha
            dgvDados.AllowUserToDeleteRows = false;

            // Não permite redimensionar a altura das linhas
            dgvDados.AllowUserToResizeRows = false;

            // Não permite redimensionar a largura das colunas
            dgvDados.AllowUserToResizeColumns = false;

            // dgvDados.AllowUserToOrderColumns = false;

            // Associar e vincular a lista de empregos na DataGridView
            dgvDados.DataSource = Empresa.emp;

            // Mostrar apenas as 4 primeiras propriedades da classe Empregado na DataGridView
            // Por defeito todas as colunas da  têm a propriedade Visible
            for (int i = 4; i < dgvDados.ColumnCount; i++)
                dgvDados.Columns[i].Visible = false;

            // Posso aceder à coluna pelo seu indice ou pelo nome da coluna / nome da propriedade
            // Alterar o nome do cabeçalho da coluna 
            dgvDados.Columns["ValorID"].HeaderText = "ID";
            dgvDados.Columns["NomeAbreviado"].HeaderText = "Nome";

            // Alterar a largura da coluna
            dgvDados.Columns["ValorID"].Width = 50;
            dgvDados.Columns["NomeAbreviado"].Width = 150;

            // Alterar a cor de fundo da coluna
            dgvDados.Columns["ValorID"].DefaultCellStyle.BackColor = Color.LightBlue;

            // Formatar o texto da coluna
            dgvDados.Columns["ValorID"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dgvDados.Columns["Cargo"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Sair da aplicação
            Application.Exit();
        }

        /// <summary>
        /// Devolve o empregado atualmente selecionado na datagrindvew
        /// </summary>
        /// <returns></returns>
        private Empregado GetAtualDataRown()
        {
            if (dgvDados.SelectedRows.Count > 0)
                // Aceder aos dados associados à linha selecionada
                //e converter esses dados para Empregado
                return (Empregado)dgvDados.CurrentRow.DataBoundItem;
            else return null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum empregado na lista de dados...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Empregado dados = GetAtualDataRown();
            if (dados != null)
            {
                // Guarda a posição dos dados do empregado na BindingList
                int i = Empresa.emp.IndexOf(dados);

                // Abre o formulário com uma cópia dos dados
                // A clonagem garante a proteção dos dados originais do empregado
                frmEmpregado form = new frmEmpregado((Empregado)Empresa.emp[i].Clone());
                DialogResult res = form.ShowDialog();

                // Se clicou OK ao fechar a janela deve-se atualizar os dados da BindingList
                if (res == DialogResult.OK)
                {
                    // Atualiza os dados na lista
                    Empresa.emp[i] = form.Emp;
                    MessageBox.Show("Empregado atualizado com sucesso...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Não existe o empregado na lista...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Como queremos adicionar um novo empregado, basta indicar null ao empregado
            frmEmpregado form = new frmEmpregado(null);

            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                Empresa.emp.Add(form.Emp);
                MessageBox.Show("Novo empregado adicionado com sucesso", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {

            if (dgvDados.Rows.Count > 0)

            {

                Empregado dados = GetAtualDataRown();

                int i = Empresa.emp.IndexOf(dados);

                //Não encontrou o empregado na BindingList?

                if (i < 0)

                {

                    MessageBox.Show("Empregado não encontrado na lista de dados...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return; //sai da função

                }

                // em vez de dados podia também Empresa.emp[i]

                string msg = "Remover o " + dados.GetCargo() + " " + dados.Nome + "?";

                DialogResult res = MessageBox.Show(msg, Empresa.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)

                    Empresa.emp.RemoveAt(i);
            }

            else

                MessageBox.Show("Não existem empregados na lista de dados...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //Caso seja eliminado o ultimo da lista, nenhum empregado fica automaticamente  selecionado na DataGridView

            //É preciso, neste caso , selecionar o ultimo da lista

            //Nota: é necessario testar se existem empregados primeiro para não ocorrer caso a lista esteja vazia

            if (dgvDados.Rows.Count > 0 && dgvDados.SelectedRows.Count == 0)

                dgvDados.Rows[dgvDados.Rows.Count - 1].Selected = true;

        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnRemover.PerformClick(); // Chama o método btRemover_Click(object sender, KeyEventArgs e)

            else if (e.KeyCode == Keys.Enter)

                btnEditar.PerformClick();

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

                btnEditar.PerformClick();
        }
    }
}
