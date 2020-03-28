namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Question_1 { get; set; }

        [StringLength(250)]
        public string Question_2 { get; set; }

        [StringLength(250)]
        public string Question_3 { get; set; }

        [StringLength(250)]
        public string Question_4 { get; set; }

        [StringLength(70)]
        public string AnswerDescription1 { get; set; }

        public int? Answer_1 { get; set; }

        [StringLength(70)]
        public string AnswerDescription2 { get; set; }

        public int? Answer_2 { get; set; }

        [StringLength(70)]
        public string AnswerDescription3 { get; set; }

        public int? Answer_3 { get; set; }

        [StringLength(70)]
        public string AnswerDescription4 { get; set; }

        public int? Answer_4 { get; set; }

        public int Type { get; set; }

        [StringLength(400)]
        public string Description { get; set; }
    }
}
