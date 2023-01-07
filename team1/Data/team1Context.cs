using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using team1.Models;

namespace team1.Data
{
    public class team1Context : DbContext
    {
        public team1Context (DbContextOptions<team1Context> options)
            : base(options)
        {
        }

        public DbSet<team1.Models.Customers> Customers { get; set; } = default!;

        public DbSet<team1.Models.GroupProduct> GroupProduct { get; set; } = default!;

        public DbSet<team1.Models.Order> Order { get; set; } = default!;

        public DbSet<team1.Models.OrderDetail> OrderDetail { get; set; } = default!;

        public DbSet<team1.Models.Product> Product { get; set; } = default!;

        public DbSet<team1.Models.Users> Users { get; set; } = default!;
    }
}
