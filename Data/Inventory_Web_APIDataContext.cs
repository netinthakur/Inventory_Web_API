using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory_Web_API.Model;

namespace Inventory_Web_API.Models
{
    //Connects the model to the  database table
    public class Inventory_Web_APIDataContext : DbContext
    {
        public Inventory_Web_APIDataContext (DbContextOptions<Inventory_Web_APIDataContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory_Web_API.Model.Item> Item { get; set; }
    }
}
