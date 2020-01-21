using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Models;
using WebTetris.Models;
using System.Text.RegularExpressions;


namespace WebTetris.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Message> Messages {get;set;}

        public DbSet<Statistic> Statictic { get; set; } // наша база данных
             

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
