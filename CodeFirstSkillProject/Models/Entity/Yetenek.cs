using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstSkillProject.Models.Entity
{
    public class Yetenek
    {
        [Key]
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public int Deger { get; set; }
    }
}