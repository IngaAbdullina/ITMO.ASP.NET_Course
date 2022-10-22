using System.Data.Entity;

namespace FinalTask.Models
{
    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}