namespace DamThanhNgan_17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLop { get; set; }
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenLop { get; set; }
    }
}
