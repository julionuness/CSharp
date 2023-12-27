using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_SistemaGestao
{
    class PessoaFisica : Pessoa
    {
        private string cpf;
        private int qtdFilhos;
        private double salario;

        public string Cpf { get => cpf; set => cpf = value; }
        public int QtdFilhos { get => qtdFilhos; set => qtdFilhos = value; }
        public double Salario { get => salario; set => salario = value; }

        public PessoaFisica(string cpf, int qtdFilhos, double salario, string nome, string cidade) : base (nome, cidade)
        {
            Cpf = cpf;
            QtdFilhos = qtdFilhos;
            Salario = salario;
        }

        public override double CalcCredito()
        {
            return Salario * 12 - QtdFilhos * 10;
        }
    }
}
