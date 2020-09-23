namespace WindowsFormsApp7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hal2EllenallasTemp
    {
        [Key]
        [StringLength(20)]
        public string MertErtek { get; set; }
    }
}
