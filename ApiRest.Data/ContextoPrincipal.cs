using ApiRest.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiRest.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
