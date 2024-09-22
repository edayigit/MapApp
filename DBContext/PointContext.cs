using MapApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace MapApp.DBContext
{
    public class PointContext : DbContext
    {
        public PointContext(DbContextOptions options) : base(options)
        {
            //options ile bağlantı dizesi alınmış olacak
        }
        public DbSet<Point> Points { get; set; }

    }
}

