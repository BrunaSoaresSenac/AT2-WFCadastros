using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public class Categorias
    {
        public int Codigo { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public char Status { get; set; }
        public DateTime DtCadastro { get; set; }

        private static List<Categorias>
            ListaCategorias = new List<Categorias>();

        public void Cadastrar()
        {
            ListaCategorias.Add(this);
        }

        public static List<Categorias> TodosOsUsuarios()
        {
            return ListaCategorias;
        }
    }
}
