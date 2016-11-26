namespace WhoWantsToBeACodeWizard.Data
{
    using Models.Models;
    using System.Data.Entity;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>().HasOptional(a => a.Question).WithOptionalPrincipal(q => q.Answer);
            modelBuilder.Entity<Answer>().HasOptional(a => a.RelatedQuestion).WithMany(q => q.Answers);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Question> Questions { get; set; }

        public virtual DbSet<Answer> Answers { get; set; }
    }
}