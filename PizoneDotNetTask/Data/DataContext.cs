
using PizoneDotNetTask.Model;



namespace PizoneDotNetTask.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<SchoolModel> Schools { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<StudentsModel> Students { get; set; }

    }
}



