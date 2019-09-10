namespace FIRMA_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KATEGORI")]
    public partial class KATEGORI
    {
        [Key]
        public int KATEGORI_REFNO { get; set; }

        [StringLength(50)]
        public string KATEGORI_ADI { get; set; }
    }
}
