using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLocadora.wwwroot.Model;

namespace WebAppLocadora.Data
{
    public class WebAppLocadoraContext : DbContext
    {
        public WebAppLocadoraContext (DbContextOptions<WebAppLocadoraContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppLocadora.wwwroot.Model.Movie> Movie { get; set; }
    }
}
