using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using System.Globalization;

namespace IFSPStore.App.Cadastros
{
    public partial class LocacaoForm : BaseForm
    {
        private List<CarrosAlugadosModel> _aluguelItens = new List<CarrosAlugadosModel>();

        private readonly IBaseService<Locacao> _locacaoServico;
        private readonly IBaseService<Funcionario> _funcionarioServico;
        private readonly IBaseService<Cliente> _clienteServico;
        private readonly IBaseService<Carro> _carroServico;
        private readonly IBaseService<Categoria> _categoriaServico;

        private List<LocacaoModel>? locacoes;
        public LocacaoForm(IBaseService<Locacao> locacaoServico,
                           IBaseService<Funcionario> funcionarioServico,
                           IBaseService<Cliente> clienteServico,
                           IBaseService<Carro> carroServico,
                           IBaseService<Categoria> categoriaServico)
        {
           _locacaoServico = locacaoServico;
           _funcionarioServico = funcionarioServico;
           _clienteServico = clienteServico;
           _carroServico = carroServico;
           _categoriaServico = categoriaServico;
           InitializeComponent();
           locacoes = new List<LocacaoModel>();
           loadCombo();
           CarregaGridItens();
            New();
           txtDataLocacao.Text = DateTime.Now.ToString("d");
        }
        private void loadCombo()
        {
            // cboFuncionário
            cboFuncionario.ValueMember = "Id";
            cboFuncionario.DisplayMember = "Nome";
            cboFuncionario.DataSource = _funcionarioServico.Get<Funcionario>().ToList();

            // cboCliente
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteServico.Get<Cliente>().ToList();

            //cboCarro
            cboCarro.ValueMember = "Id";
            cboCarro.DisplayMember = "Nome";
            cboCarro.DataSource = _carroServico.Get<Carro>().ToList();

            //cboCategoria
            //cboCategoria.ValueMember = "Id";
            //cboCategoria.DisplayMember = "Nome";
            //cboCategoria.DataSource = _categoriaServico.Get<Categoria>().ToList();
        }
        private void PreencheObject(Locacao locacao)
        {
            if (DateTime.TryParse(txtDataLocacao.Text, out var dataLoc))//converte a data para salvar no objeto do banco
                locacao.DataLocacao = dataLoc;

            if (DateTime.TryParse(txtDataDevolucao.Text, out var dataDev))
                locacao.DataDevolucao = dataDev;

            if (cboFuncionario.SelectedValue != null && int.TryParse(cboFuncionario.SelectedValue.ToString(), out var idFunc))
            {
                locacao.FuncionarioId = idFunc;
                locacao.Funcionario = null;
            }

            if (cboCliente.SelectedValue != null && int.TryParse(cboCliente.SelectedValue.ToString(), out var idCli))
            {
                locacao.ClienteId = idCli;
                locacao.Cliente = null;
            }

            // valor total da locação
            locacao.ValorTotal = _aluguelItens.Sum(x => x.ValorTotalLoc);
            // soma o total de diárias
            locacao.NumDiarias = (int)_aluguelItens.Sum(x => x.Quantidade);

            // limpa a lista (do objeto) de itens para salvar
            locacao.CarrosAlugados.Clear();
            foreach (var item in _aluguelItens)
            {
                var itemLocacao = new CarrosAlugados
                {
                    Locacao_ = locacao,
                    CarroId = item.CarroId,
                    Carro = null,
                    ValorDiaria = item.ValorDiaria,
                    Quantidade = item.Quantidade,
                    ValorTotalLoc = item.ValorTotalLoc
                };
                locacao.CarrosAlugados.Add(itemLocacao);
            }
        }
        protected override void New()
        {
            base.New();
            _aluguelItens.Clear();
            CarregaGridItens();
            txtDataLocacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDataDevolucao.Text = string.Empty;
        }
        protected override void Save()
        {
            try
            {
                
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var idLoc))
                    {
                        var locacao = _locacaoServico.GetById<Locacao>(idLoc, new List<string> { "CarrosAlugados" }); 
                        PreencheObject(locacao);
                        _locacaoServico.Update<Locacao, Locacao, LocacaoValidator>(locacao);
                    }
                }
                else
                {
                    var locacao = new Locacao();
                    PreencheObject(locacao);
                    _locacaoServico.Add<Locacao, Locacao, LocacaoValidator>(locacao);
                }

                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Delete(int id)
        {
            try
            {
                _locacaoServico.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            // trazos dados relacionados da grid principal
            var includes = new List<string>() { "Cliente", "Funcionario", "CarrosAlugados" };
            locacoes = _locacaoServico.Get<LocacaoModel>(includes).ToList();

            dataGridViewList.DataSource = locacoes;
            dataGridViewList.Columns["FuncionarioId"].Visible = false;
            dataGridViewList.Columns["ClienteId"].Visible = false;

            dataGridViewList.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewList.Columns["DataLocacao"].HeaderText = "Data de locação";
            dataGridViewList.Columns["DataDevolucao"].HeaderText = "Data de devolução";
            dataGridViewList.Columns["ValorTotal"].HeaderText = "Valor Total";
            dataGridViewList.Columns["NumDiarias"].HeaderText = "Número de diarias";
        }
        protected override void loadList(DataGridViewRow? linha)
        {
            if (linha == null) return;

            int.TryParse(linha.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha.Cells["Id"].Value.ToString();

            cboFuncionario.SelectedValue = linha.Cells["FuncionarioId"].Value;
            cboCliente.SelectedValue = linha.Cells["ClienteId"].Value;

            txtDataLocacao.Text = DateTime.TryParse(linha.Cells["DataLocacao"].Value?.ToString(), out var dataLoc)
               ? dataLoc.ToString("dd/MM/yyyy") : "";

            txtDataDevolucao.Text = DateTime.TryParse(linha.Cells["DataDevolucao"].Value?.ToString(), out var dataDev)
               ? dataDev.ToString("dd/MM/yyyy") : "";

            //itens da locação para a grid de itens
            var includes = new List<string>() { "CarrosAlugados", "CarrosAlugados.Carro" };
            var locacaoFull = _locacaoServico.GetById<Locacao>(id, includes);

            _aluguelItens = new List<CarrosAlugadosModel>();
            foreach (var item in locacaoFull.CarrosAlugados)
            {
                var itemModel = new CarrosAlugadosModel
                {
                    CarroId = item.CarroId,
                    ValorDiaria = item.ValorDiaria,
                    Quantidade = item.Quantidade,
                    ValorTotalLoc = item.ValorTotalLoc,
                    CarroNome = item.Carro?.Nome
                };
                itemModel.Carro = item.Carro;

                _aluguelItens.Add(itemModel);
            }
            CarregaGridItens();
            CalculateTotalLocacao();
        }
        private void CarregaGridItens()
        {
            var source = new BindingSource();
            source.DataSource = _aluguelItens.ToArray();
            dataGridViewItens.DataSource = source;

            dataGridViewItens.Columns["LocacaoId"].Visible = false;
            dataGridViewItens.Columns["Locacao_"].Visible = false;
            dataGridViewItens.Columns["Carro"].Visible = false;

            dataGridViewItens.Columns["ValorDiaria"].HeaderText = "Valor Diária";
            dataGridViewItens.Columns["ValorDiaria"].DefaultCellStyle.Format = "C2";

            dataGridViewItens.Columns["ValorTotalLoc"].DefaultCellStyle.Format = "C2";

            dataGridViewItens.Columns["Quantidade"].HeaderText = "Diarias"; //mudar no model depois
            dataGridViewItens.Columns["ValorTotalLoc"].HeaderText = "Valor total da locação"; 
            dataGridViewItens.Columns["CarroNome"].HeaderText = "Nome do veiculo";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(txtDataLocacao.Text, out var dataLocacao);
            DateTime.TryParse(txtDataDevolucao.Text, out var dataDevolucao);

            if (dataDevolucao < dataLocacao)
            {
                MessageBox.Show("A data de devolução não pode ser menor que a data de locação.", "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ID do Carro selecionado no cbo
            if (cboCarro.SelectedValue == null)
            {
                MessageBox.Show("Selecione um carro.", "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(cboCarro.SelectedValue.ToString(), out var idCarro);
            // VERIFICAÇÃO LOCAL
            if (_aluguelItens.Any(x => x.CarroId == idCarro))
            {
                MessageBox.Show("Este carro já foi adicionado na lista!", "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VERIFICAÇÃO NO BANCO
            int? idAtual = null;
            if (IsEditMode && int.TryParse(txtId.Text, out var id))
            {
                idAtual = id;
            }

            bool disponivel = VerificarDisponibilidade(idCarro, dataLocacao, dataDevolucao, idAtual);

            if (!disponivel)
            {
                MessageBox.Show($"O veículo selecionado já está alugado neste período!",
                                "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Se chegou aqui, pode adiionar kkkkkk

            var item = new CarrosAlugadosModel();
            var carroObj = _carroServico.GetById<Carro>(idCarro); // Busca o objeto completo para preencher o model

            item.CarroId = carroObj.Id;
            item.Carro = carroObj; // Preenche objeto
            item.CarroNome = cboCarro.Text;  
            // Preenche Quantidade (Diárias)
            if (decimal.TryParse(txtDiarias.Text, out var dias))
            {
                item.Quantidade = dias;
            }
            else
            {
                item.Quantidade = 1;
            }

            // Preenche Valor da Diária
            string precoLimpo = txtPreco.Text.Replace("R$", "").Trim();
            if (decimal.TryParse(precoLimpo, NumberStyles.Currency, CultureInfo.CurrentCulture, out var valorDiaria))
            {
                item.ValorDiaria = valorDiaria;
            }

            // Calcula Total do Item
            item.ValorTotalLoc = item.Quantidade * item.ValorDiaria;

            // Adiciona na lista e atualiza a tela
            _aluguelItens.Add(item);

            CarregaGridItens();
            CalculateTotalLocacao();
            LimparCamposItem();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                var index = dataGridViewItens.SelectedRows[0].Index;
                _aluguelItens.RemoveAt(index);
                CarregaGridItens();
                CalculateTotalLocacao();
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.", "DriveNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimparCamposItem()
        {
            txtDiarias.Text = "";
            txtPreco.Text = "";
            txtPrecoTotal.Text = "";
            cboCarro.SelectedIndex = -1;
            //cboCategoria.SelectedIndex = -1;
        }
        private void txtDiarias_Leave(object sender, EventArgs e)
        {
            CalculateTotalItem();
        }
        private void txtDiarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            // para filtrar apenas números  
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CalculateTotalItem()
        {
            
            string precoLimpo = txtPreco.Text.Replace("R$", "").Trim();
            decimal.TryParse(precoLimpo, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal vlDiaria);
            decimal.TryParse(txtDiarias.Text, out decimal dias);
            var valorTotal = dias * vlDiaria;
            txtPrecoTotal.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            
        }
        private void CalculateTotalLocacao()
        {
            decimal totalValor = _aluguelItens.Sum(x => x.ValorTotalLoc);
            lblTotalPrice.Text = string.Format(CultureInfo.CurrentCulture, "Valor Total: {0:C2}", totalValor);

            decimal totalCarros = _aluguelItens.Count;
            lblQtdItens.Text = $"Qantidade de Veículos: {totalCarros}";
        }

        private void cboCarro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCarro.SelectedValue != null && cboCarro.SelectedItem is Carro carro)
            {
                // preenche a diaria
                txtPreco.Text = carro.Diaria.ToString("C2");
                var categorria = _categoriaServico.GetById<Categoria>(carro.CategoriaId);
                txtCategoria.Text = categorria.Nome;
                // Preenche a categoria
                //cboCategoria.SelectedValue = carro.CategoriaId;

                CalculateTotalItem();
            }
        }
        private bool VerificarDisponibilidade(int carroId, DateTime dataInicio, DateTime dataFim, int? locacaoIdAtual = null)
        {
            //carrega as locações do banco
            var locacoesFeitas = _locacaoServico.Get<Locacao>(new List<string> { "CarrosAlugados" });

            foreach (var locacao in locacoesFeitas)
            {
                //nao pode ser a locacao atual e se estiver editando ignora tambem
                if (!locacaoIdAtual.HasValue || locacao.Id != locacaoIdAtual.Value)
                {
                    // verifica comflito de datas
                    // (InicioA < FimB) E (InicioB < FimA)
                    bool datasCruzam = dataInicio < locacao.DataDevolucao && locacao.DataLocacao < dataFim;

                    if (datasCruzam)
                    {
                        // aqui as  datas cruzam, entao veerifiar se o carro está alugado nesse periodo
                        if (locacao.CarrosAlugados.Any(c => c.CarroId == carroId))
                        {
                            return false; // carro ja alugado
                        }
                    }
                }
            }

            return true; 
        }
        private void txtDataLocacao_Leave(object sender, EventArgs e)
        {
            DateTime.TryParse(txtDataLocacao.Text, out var dataInicio);
            DateTime.TryParse(txtDataDevolucao.Text, out var dataFim);

            // data de devolução anterior a de locação
            if (dataFim < dataInicio)
            {
                txtDiarias.Text = "1";//adotaremos eesse cenario como 1 diaria
            }
            else
            {
                TimeSpan diferenca = dataFim - dataInicio;
                int dias = diferenca.Days;

                // nao vamos ter a opção de menos de uma diaria (devolver no mesmo dia)
                if (dias < 1) dias = 1;

                txtDiarias.Text = dias.ToString();
            }

            CalculateTotalItem();
        }

        private void txtDataLocacao_Click(object sender, EventArgs e)
        {
            var calendario = new CalendarioForm();
            {
                if (calendario.ShowDialog() == DialogResult.OK)//trava o resto
                {
                    txtDataLocacao.Text = calendario.DataSelecionada;
                    txtDataLocacao_Leave(sender, e);//para funcionar a logica anterior
                }
            }
        }
        private void txtDataDevolucao_Click(object sender, EventArgs e)
        {
            var calendario = new CalendarioForm();
            {
                if (calendario.ShowDialog() == DialogResult.OK)
                {
                    txtDataDevolucao.Text = calendario.DataSelecionada;
                    txtDataLocacao_Leave(sender, e);
                }
            }
        }
        private void DeslligaTeclado(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true; // Cancela a entrada do teclado
        }

    }
}
