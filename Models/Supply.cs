namespace Graduation_project3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supply
    {
        public int ID { get; set; }

        public int NO_Donators { get; set; }

        public int NO_Blood_Bags { get; set; }

        public int NO_Blood_Bags_used { get; set; }
    }
}
