using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Entitites
{
    public class Funcionario
    {
        public int idFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        //Relacionamento de Associação (TER-1)
        public Setor Setor { get; set; }
        

        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario, DateTime dataAdmissao)
        {
            this.idFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }
    }
}
