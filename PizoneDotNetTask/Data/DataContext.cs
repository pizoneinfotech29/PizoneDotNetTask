
using PizoneDotNetTask.Model;
using System.Security.Claims;



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


//namespace task.Data
//{
//    public class DataContext : DbContext
//    {
//        public DataContext(DbContextOptions options) : base(options)
//        {

//        }
//        public DbSet<School> Schools { get; set; }
//        public DbSet<Class> Classes { get; set; }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<School>().HasData(
//                new School { Id = 1, Name = "Little Kingdom School", Location = "Uday Marg Tilak Nagar Jaipur" },
//                new School { Id = 2, Name = "VSI International School", Location = "Sanganer Bazar Jaipur" },
//                new School { Id = 3, Name = "Gyan Jyoti Vidyapeeth", Location = "Jagatpura Getor Jaipur" });

//            modelBuilder.Entity<Class>().HasData(
//               new Class { Id = 1, Name = "ClassA", NumberOfStudents = 35, SchoolId = 1 },
//               new Class { Id = 2, Name = "ClassB", NumberOfStudents = 40, SchoolId = 2 },
//               new Class { Id = 3, Name = "ClassC", NumberOfStudents = 39, SchoolId = 1 }
//               );
//        }
//    }
//}

