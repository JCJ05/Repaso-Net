﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repaso_Net.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

          public DbSet<Repaso_Net.Models.Usuario> DataUsuarios {get; set; }
          public DbSet<Repaso_Net.Models.Curso> DataUsuarios {get; set; }
    }
}
