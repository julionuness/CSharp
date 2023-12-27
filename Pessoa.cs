﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_SistemaGestao
{
 public abstract class Pessoa
      {

        protected string nome;
        protected string cidade;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        protected Pessoa(string nome, string cidade)
        {
            Nome = nome;
            Cidade = cidade;
        }

        public abstract double CalcCredito();

      }


}
