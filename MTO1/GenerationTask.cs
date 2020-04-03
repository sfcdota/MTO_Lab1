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
        [Column(Order = 0)]
        [StringLength(50)]
        public string StudentLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenerationID1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenerationID2 { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Finished { get; set; }
    }
}
