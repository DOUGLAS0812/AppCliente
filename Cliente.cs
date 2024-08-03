﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateTime CadastradoEm { get; set; }
        
        public Decimal Desconto { get; set; } 
    }
}
