namespace DamThanhNgan_17.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaSinhVien { get; set; }
        [Column(Order = 1)]
        [StringLength(50)]
        public string HoTen { get; set; }
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLop { get; set; }
    }
}
