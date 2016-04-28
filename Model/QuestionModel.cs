namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuestionModel : DbContext
    {
        public QuestionModel()
            : base("name=QuestionModel")
        {
        }

        public virtual DbSet<Questions> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
