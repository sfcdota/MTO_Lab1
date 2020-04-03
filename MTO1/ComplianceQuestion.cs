namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComplianceQuestion")]
    public partial class ComplianceQuestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Question1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Question2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Question3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Question4 { get; set; }

        [Required]
        [StringLength(50)]
        public string Answer1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Answer2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Answer3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Answer4 { get; set; }

        public int CorrectAnswer1 { get; set; }

        public int CorrectAnswer2 { get; set; }

        public int CorrectAnswer3 { get; set; }

        public int CorrectAnswer4 { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
