using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_cadastro
{
    internal class produtos
    {
        string nome, categoria;
        float precoCusto, precoVenda;

        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public float PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public float PrecoVenda { get => precoVenda; set => precoVenda = value; }
    }
}
