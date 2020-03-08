namespace MTO1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
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
    }
}
