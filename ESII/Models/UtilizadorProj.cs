﻿using System.ComponentModel.DataAnnotations.Schema;
using ESII.Models;

namespace ESII.Models
{
    public class UtilizadorProjeto
    {
        public int UtilizadorId { get; set; }
        public Utilizador Utilizador { get; set; }

        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
    }
}