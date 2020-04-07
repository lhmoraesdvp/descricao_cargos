namespace App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("unidade")]
    public partial class unidade
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
