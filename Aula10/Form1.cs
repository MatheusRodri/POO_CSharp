namespace Aula10
{
    public partial class Form1 : Form
    {
        SistemaCaixa sistema = new SistemaCaixa();
        public Form1()
        {
            InitializeComponent();
            foreach (Produto produto in sistema.produtos)
            {
                cmbProdutos.Items.Add(produto.nome);
            }
            foreach (Funcionario funcionario in sistema.funcionarios)
            {
                cmbFuncionarios.Items.Add(funcionario.nome);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKg.Text == "")
            {
                MessageBox.Show("É nessario colocar o kg");
                txtKg.Focus();
                return;
            }
            dynamic produto = sistema.produtos[cmbProdutos.SelectedIndex];

            if (produto.GetType() == typeof(ProdutoKG))
            {
                sistema.carrinho.Add(new ProdutoKG(produto.nome, produto.valor, float.Parse(txtKg.Text)));
            }
            else
            {
                sistema.carrinho.Add(produto);
            }
            txtKg.Text = "";
            AtualizaTela();

        }
        public void AtualizaTela()
        {
            lstCarrinho.Items.Clear();
            foreach (dynamic produto in sistema.carrinho)
            {
                lstCarrinho.Items.Add(produto.Descricao());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic produto = sistema.produtos[cmbProdutos.SelectedIndex];

            if (produto.GetType() == typeof(ProdutoKG))
            {
                txtKg.Visible = true;
                label3.Visible = true;
            }
            else
            {
                txtKg.Visible = false;
                label3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic funcionario = sistema.funcionarios[cmbFuncionarios.SelectedIndex];

            remove(funcionario);

        }

        public void remove(Caixa caixa)
        {
            MessageBox.Show("Você não tem permissão");
        }
        public void remove(Gerente gerente)
        {
            sistema.carrinho.RemoveAt(lstCarrinho.SelectedIndex);
            AtualizaTela();
        }
    }
}