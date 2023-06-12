﻿using System.ComponentModel.DataAnnotations;

namespace TaskManagment.Web.Models
{
    public class PasoCrearDTO
    {
        [Required]
        public string Descripcion { get; set; }

        public bool Realizado { get; set; }
    }
}
