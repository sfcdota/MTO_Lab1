namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TextQuestion")]
    public partial class TextQuestion
    {
        public int ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Question { get; set; }

        [Required]
        [StringLength(50)]
        public string Answer { get; set; }
    }
}
