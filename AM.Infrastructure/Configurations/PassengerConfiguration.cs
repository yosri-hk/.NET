using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PassengerConfiguration: IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.Fullname, s => {
                s.Property(f => f.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                s.Property(e => e.LastName).HasColumnName("PassLastName").IsRequired();
                //builder.HasDiscriminator<string>("IsTraveler")
                //.HasValue<Traveller>("1")
                //.HasValue<Staff>("2")
                //.HasValue<Passenger>("0");


            });

        }
    }
}
