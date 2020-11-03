using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrEthos.Entities.Enums
{
    public enum State : byte
    {
        [Display(Name = "Aktif")]
        Active = 0,
        [Display(Name = "Pasif")]
        Passive = 1,
        [Display(Name = "Silinmiş")]
        Deleted = 2
    }
}
