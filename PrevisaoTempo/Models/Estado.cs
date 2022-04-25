﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrevisaoTempo.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public List<Cidade> Cidade { get; set; }
    }
}