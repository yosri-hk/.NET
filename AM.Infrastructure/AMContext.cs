﻿using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=NadaHammamiDB;Integrated Security=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Plane> Planes { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet <Passenger> Passengers{ get; set; }

        public DbSet <Traveller> Travellers { get; set; }

        public DbSet <Staff> Staffs{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new PlaneConfiguration());
            modelbuilder.ApplyConfiguration(new FlightConfiguration());
            modelbuilder.ApplyConfiguration(new PassengerConfiguration());
            modelbuilder.Entity<Staff>().ToTable("Staff");
            modelbuilder.Entity<Traveller>().ToTable("Traveler");
            modelbuilder.ApplyConfiguration(new TicketConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder mcb)
        {
            mcb.Properties<DateTime>().HaveColumnType("date");
        }













    }

}