namespace BigSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string LeturerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Place { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Datetime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        public string Name;

        public List<Category> ListCategory = new List<Category>();
        public virtual Category Category { get; set; }

    }
}
