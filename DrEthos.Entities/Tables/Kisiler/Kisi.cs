using DrEthos.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DrEthos.Entities.Kisiler
{
    [Table("Kisi", Schema = "DrEthos")]
    public class Kisi : EntityBase<Guid>
    {
        public Kisi()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        public string Adi { get; set; }

        [Required]
        public string Soyadi { get; set; }

        [Required]
        public string Telefon { get; set; }

        public string AdiSoyadi
        {
            get { return Adi + " " + Soyadi; }
        }
        public DateTime DogumTarihi { get; set; }
        public string DogumTarihiTxt
        {
            get { return DogumTarihi.ToString("d"); }
        }
    }
}
