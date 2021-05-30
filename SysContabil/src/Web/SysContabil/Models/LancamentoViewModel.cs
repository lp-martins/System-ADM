﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SysContabil.Models
{
    public class LancamentoViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [DisplayName("Data:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public DateTime DataDoPlano { get; set; }

        [DisplayName("Débito:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Debito { get; set; }

        [DisplayName("Crédito:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Credito { get; set; }

        [DisplayName("Valor:")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public double Valor { get; set; }
    }
}
