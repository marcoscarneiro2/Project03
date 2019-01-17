using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Entitites
{
   public class Setor
    {   //prop + 2x(tab)
        public int IdSetor { get; set; }
        public int Nome { get; set; }

        //Relacionamento de Associação(TER-MUITOS)
        public List<Funcionario> Funcionarios { get; set; }

        public Setor()
        {

        }

        public Setor(int idSetor, int nome)
        {
            IdSetor = idSetor;
            Nome = nome;
        }
    }
}
