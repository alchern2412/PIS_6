using Models;
using System.Data.Entity;

namespace SqlRepo
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }
}