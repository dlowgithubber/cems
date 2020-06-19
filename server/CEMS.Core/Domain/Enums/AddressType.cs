using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CEMS.Core.Domain.Enums
{
    public enum AddressType
    {
        [Display(Name = "Home")]
        Home,
        [Display(Name = "Work")]
        Work,
        [Display(Name = "Other")]
        Other
    }
}
