﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Lancamento
    {
        public Lancamento(DateTime data, string debito, string credito, double valor)
        {
            Data = data;
            Debito = debito;
            Credito = credito;
            Valor = valor;
        }
        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Debito { get; private set; }
        public string Credito { get; private set; }
        public double Valor { get; private set; }

        public string PlanoDeContaID { get; private set; }
        public PlanoDeConta PlanoDeConta { get; private set; }

        public void AtualizarLancamento(DateTime data, string debito, string credito, double valor)
        {
            this.Data = data;
            this.Debito = debito;
            this.Credito = credito;
            this.Valor = valor;
        }
    }
}