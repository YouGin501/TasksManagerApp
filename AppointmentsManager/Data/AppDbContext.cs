﻿using AppointmentsManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentsManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MyTask> Appointments { get; set; }
    }
}
