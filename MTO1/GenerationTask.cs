namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenerationTask")]
    public partial class GenerationTask
    {
        [Key]
        [StringLength(50)]
        public string StudentLogin { get; set; }

        public int GenerationID1 { get; set; }

        public int GenerationID2 { get; set; }
    }
}
