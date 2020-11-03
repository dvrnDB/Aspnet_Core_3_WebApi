using DrEthos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DrEthos.Entities.Abstract
{
    public abstract class EntityBase<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public T Id { get; set; }
        public State State { get; set; } = State.Active;

        public DateTime OlusturmaZamani { get; set; } = DateTime.Now;
        public DateTime DuzenlenmeZamani { get; set; } = DateTime.Now;
        public Guid OlusturanKullanici { get; set; }
        public string DuzenleyenKullanici { get; set; }
    }
}
