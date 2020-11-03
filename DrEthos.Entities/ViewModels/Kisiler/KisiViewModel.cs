using DrEthos.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DrEthos.Entities.Kisiler
{
    public class KisiModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Adi { get; set; }

        [Required]
        public string Soyadi { get; set; }

        [Required]
        public string Telefon { get; set; }

        public DateTime DogumTarihi { get; set; }
    }
    public class KisiCreateModel
    {
        [Required]
        public string Adi { get; set; }

        [Required]
        public string Soyadi { get; set; }

        [Required]
        public string Telefon { get; set; }

        public DateTime DogumTarihi { get; set; }
    }
}
