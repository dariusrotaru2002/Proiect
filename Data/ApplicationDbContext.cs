﻿using System;
using ProiectDarius.Models;
using Microsoft.EntityFrameworkCore;

namespace ProiectDarius.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
