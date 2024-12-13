namespace Lab3_03_Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSo { get; set; }

        [Required]
        [StringLength(100)]
        public string Ten { get; set; }

        [Required]
        [StringLength(100)]
        public string Khoa { get; set; }

        public double Diem { get; set; }
    }
}
