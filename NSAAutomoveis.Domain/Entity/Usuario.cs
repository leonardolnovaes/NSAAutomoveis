﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NSAAutomoveis.Domain.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
