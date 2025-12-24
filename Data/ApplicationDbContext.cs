using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;

namespace StudentPortal.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
}