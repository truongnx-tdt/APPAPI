using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySystem.Data.Entites
{
    public class Cookies : BaseEntity
    {
        [Key]
        public string CUser { get; set; }
        public string CookieData { get; set; }
    }
}
