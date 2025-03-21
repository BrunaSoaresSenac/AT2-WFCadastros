using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }

    public class Pessoa
    {
        public int Codigo { get; set; }
        public string? Cpf { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Email { get; set; }
        public string? Ddd { get; set; }
        public string? Telefone { get; set; }
        public bool PossuiFilhos { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }

        private static List<Pessoa>
            ListaPessoas = new List<Pessoa>();

        public void Cadastrar()
        {
            ListaPessoas.Add(this);
        }

        public static List<Pessoa> PessoasGeral()
        {
            return ListaPessoas;
        }
    }
}
