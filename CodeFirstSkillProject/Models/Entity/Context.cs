using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstSkillProject.Models.Entity
{
    public class Context:DbContext
    {
        public DbSet<Yetenek> Yeteneks { get; set; }
    }
}