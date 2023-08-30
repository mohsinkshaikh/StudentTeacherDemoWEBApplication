using Microsoft.EntityFrameworkCore;
using StudentTeacherDemoWEBApplication.Models;


namespace StudentTeacherDemoWEBApplication.Data
{
    public class StudCourseDBContext : DbContext
    {
        public StudCourseDBContext(DbContextOptions<StudCourseDBContext> options) :base(options)
        {
            
        }
        public DbSet<Student> tbl_student { get; set; }
        public DbSet<Courses> tbl_course { get; set; }
        public DbSet<Teacher> tbl_teacher { get; set; }
        public DbSet<Country> tbl_country { get; set; }
        public DbSet<State> tbl_state { get; set; }
        public DbSet<City> tbl_city { get; set; }
        public DbSet<Graduation> tbl_graduation { get; set; }
        public DbSet<PostGraduation> tbl_post_graduation { get; set; }
        public DbSet<Product> tbl_product { get; set; }
        public DbSet<Category> tbl_category { get; set; }
    }
}
