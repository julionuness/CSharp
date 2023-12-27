using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_SistemaGestao
{
    class PessoaJuridica : Pessoa
    {
        private string cnpj;
        private int qtdFuncionarios;
        private double faturamento;
        private string nomeFantasia;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public int QtdFuncionarios { get => qtdFuncionarios; set => qtdFuncionarios = value; }
        public double Faturamento { get => faturamento; set => faturamento = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }

        public PessoaJuridica(string cnpj, int qtdFuncionarios, double faturamento, string nomeFantasia, string nome, string cidade) : base(nome, cidade)
        {
            Cnpj = cnpj;
            QtdFuncionarios = qtdFuncionarios;
            Faturamento = faturamento;
            NomeFantasia = nomeFantasia;
        }

        public override double CalcCredito()
        {
            return Faturamento * 12 + QtdFuncionarios * 10;
        }
    }
}
