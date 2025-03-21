using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
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
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            int qtdePessoas = Pessoa.PessoasGeral().Count;
            int novoCodigo = qtdePessoas + 1;
            mtbCodigo.Text = novoCodigo.ToString("D4");
        }
        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(mtbCpf.Text))
                return true;
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
                return true;
            if (string.IsNullOrEmpty(txtEmail.Text))
                return true;
            if (string.IsNullOrEmpty(mtbCelular.Text))
                return true;
            return false;
        }
        private void LimparCampos()
        {
            mtbCodigo.Clear();
            mtbCpf.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            mtbCelular.Clear();
            chkFilhos.Checked = false;
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string semMaskTelefone = mtbCelular.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");


            if (CamposNaoPreenchidos() == true)
            {
                Erro("Os Campos Obrigatórios devem ser Preenchidos");
                return;
            }

            Pessoa pess = new Pessoa();
            pess.Codigo = int.Parse(mtbCodigo.Text);
            pess.Cpf = mtbCpf.Text;
            pess.NomeCompleto = txtNomeCompleto.Text;
            pess.Email = txtEmail.Text;
            pess.Ddd = semMaskTelefone.Substring(0, 2);
            pess.Telefone = semMaskTelefone.Substring(2);
            if (chkFilhos.CheckState == CheckState.Checked)
            {
                pess.PossuiFilhos = true;
            }
            else if (chkFilhos.CheckState == CheckState.Unchecked)
            {
                pess.PossuiFilhos = false;
            }
                pess.Cadastrar();

            Info("Cadastro Efetuado com Sucesso!");

            LimparCampos();
            int qtdePessoas = Pessoa.PessoasGeral().Count;
            int novoCodigo = qtdePessoas + 1;
            mtbCodigo.Text = novoCodigo.ToString("D4");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
