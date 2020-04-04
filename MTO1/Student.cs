namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Patromymic { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? Last_Test_Date { get; set; }

        public int? Mark { get; set; }

        public bool Finished { get; set; }
    }
}
