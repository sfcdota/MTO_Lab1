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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Surname { get; set; }

        [StringLength(25)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(25)]
        public string Password { get; set; }

        public DateTime? Last_Test_Date { get; set; }

        public int? Mark { get; set; }
    }
}
