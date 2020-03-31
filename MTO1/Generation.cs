namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Generation")]
    public partial class Generation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int a11 { get; set; }

        public int a12 { get; set; }

        public int a21 { get; set; }

        public int a22 { get; set; }

        public int? Answer { get; set; }

        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
    }
}
