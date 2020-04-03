namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MultipleChoiceQuestion")]
    public partial class MultipleChoiceQuestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(400)]
        public string Question { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer2 { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer3 { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer4 { get; set; }

        public bool CorrectAnswer1 { get; set; }

        public bool CorrectAnswer2 { get; set; }

        public bool CorrectAnswer3 { get; set; }

        public bool CorrectAnswer4 { get; set; }
    }
}
