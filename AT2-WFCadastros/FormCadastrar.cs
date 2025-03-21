using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Atencao(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Info(string mensagem)
        {
            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            int qtdeCategorias = Categorias.TodasCategorias().Count;
            int novoCodigo = qtdeCategorias + 1;
            mtbCodigo.Text = novoCodigo.ToString("D4");
            dtpDataCadastro.Value = DateTime.Today;
        }
        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
                return true;
            if (string.IsNullOrEmpty(rtbDescricao.Text))
                return true;
            return false;
        }
        private void LimparCampos()
        {
            mtbCodigo.Clear();
            txtCategoria.Clear();
            rtbDescricao.Clear();
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
            dtpDataCadastro.Value = DateTime.Today;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposNaoPreenchidos() == true)
            {
                Erro("Os Campos Obrigatórios devem ser Preenchidos");
                return;
            }

            Categorias cat = new Categorias();
            cat.Codigo = int.Parse(mtbCodigo.Text);
            cat.Categoria = txtCategoria.Text;
            cat.Descricao = rtbDescricao.Text;
            cat.DtCadastro = dtpDataCadastro.Value;
            if (rdbAtivo.Checked)
            {
                cat.Status = 'A';
            }
            else if (rdbInativo.Checked)
            {
                cat.Status = 'I';
            }

            cat.Cadastrar();

            Info("Cadastro Efetuado com Sucesso!");

            LimparCampos();
            int qtdeCategorias = Categorias.TodasCategorias().Count;
            int novoCodigo = qtdeCategorias + 1;
            mtbCodigo.Text = novoCodigo.ToString("D4");

        }
    }
}
