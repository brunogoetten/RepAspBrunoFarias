﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEP.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]

        public int id { get; set; }
        public string cep { get; set; }

        public string logradouro { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string localidade { get; set; }
        public string uf { get; set; }

        public string unidade { get; set; }

        public string ibge { get; set; }

        public string gia { get; set; }
    }
}
