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

        [Required]
        [StringLength(70)]
        public string Answer_1 { get; set; }

        [StringLength(70)]
        public string Answer_2 { get; set; }

        [StringLength(70)]
        public string Answer_3 { get; set; }

        [StringLength(70)]
        public string Answer_4 { get; set; }
    }
}
