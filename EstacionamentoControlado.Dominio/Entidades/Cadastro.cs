﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoControlado.Dominio.Entidades
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }

       
    }
}