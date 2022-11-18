using GLC.Cores.Models;
using Microsoft.EntityFrameworkCore;

namespace GLC.EF
{
    public class GLCDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Group> Groups { set; get; }
        public virtual DbSet<Video>Videos { set; get; }
        public virtual DbSet<StudentQuizeQuestionBank> QuizeQuestions { set; get; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<QuestionCategory>questionCategories { set; get; }
        public virtual DbSet<Quiz> Quizes { get; set; }
        public virtual DbSet<QuestionBank> questionBanks { get; set; }
        public virtual DbSet<ChatingDetails> ChatingDetails { set; get; }
        public virtual DbSet<GroupChat> GroupChats { set; get; }
        public GLCDbContext(DbContextOptions<GLCDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChatingDetails>().HasKey(table => new
            {
                table.StId,
                table.GroupChatId,
                table.GroupId,
                table.TeacherId,
            });

            builder.Entity<StudentQuizeQuestionBank>().HasKey(table => new
            {
                table.StudentId,
                table.QuizeId,
                table.QuestionId
            }) ;

        }
    }
}
