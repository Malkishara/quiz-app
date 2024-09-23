using Microsoft.EntityFrameworkCore;

namespace quiz_app.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
