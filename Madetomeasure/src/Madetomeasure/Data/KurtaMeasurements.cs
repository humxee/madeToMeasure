﻿using System;
using System.Collections.Generic;

namespace Madetomeasure.Data
{
    public partial class KurtaMeasurements
    {
        public int StitchingJobId { get; set; }
        public double? Length { get; set; }
        public double? Chest { get; set; }
        public double? Shoulder { get; set; }
        public double? Sleeve { get; set; }
        public double? Collar { get; set; }
        public double? Daman { get; set; }
        public string OtherDetails { get; set; }
        public virtual StitchingJob StitchingJob { get; set; }
    }
}
