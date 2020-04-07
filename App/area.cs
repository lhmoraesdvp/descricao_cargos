namespace App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("area")]
    public partial class area
    {
        public int? int3 { get; set; }

        public int id { get; set; }

        public string Decricao { get; set; }

        public string nv1 { get; set; }

        public string nv2 { get; set; }

        public string mv3 { get; set; }

        public int? int1 { get; set; }

        public int? int2 { get; set; }
    }
}
