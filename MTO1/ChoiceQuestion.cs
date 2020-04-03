namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChoiceQuestion")]
    public partial class ChoiceQuestion
    {
        public int ID { get; set; }

        [Required]
        [StringLength(400)]
        public string Question { get; set; }

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

        public int CorrectAnswer { get; set; }
    }
}
