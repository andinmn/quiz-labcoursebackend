using Microsoft.EntityFrameworkCore;

namespace quizapp_backend.Models
{
    public class QuizDbContext:DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options):base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
