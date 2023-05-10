﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.PassengerId, t.FlightId });
            builder.HasOne(t => t.Flight).WithMany(f => f.Tickets).HasForeignKey(t => t.FlightId);
            builder.HasOne(t => t.Passenger).WithMany(f => f.Tickets).HasForeignKey(t => t.PassengerId);
        }
    }
}
