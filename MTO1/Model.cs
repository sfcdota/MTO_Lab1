namespace MTO1
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model : DbContext
	{
		public Model()
			: base("name=Model_MTO")
		{
		}

		public virtual DbSet<ChoiceQuestion> ChoiceQuestion { get; set; }
		public virtual DbSet<ComplianceQuestion> ComplianceQuestion { get; set; }
		public virtual DbSet<Generation> Generation { get; set; }
		public virtual DbSet<MultipleChoiceQuestion> MultipleChoiceQuestion { get; set; }
		public virtual DbSet<NumberQuestion> NumberQuestion { get; set; }
		public virtual DbSet<Student> Student { get; set; }
		public virtual DbSet<Teacher> Teacher { get; set; }
		public virtual DbSet<TextQuestion> TextQuestion { get; set; }
		public virtual DbSet<GenerationTask> GenerationTask { get; set; }

	}
}
