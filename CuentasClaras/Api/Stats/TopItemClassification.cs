﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuentasClaras.Api.Stats
{
    public class TopItemClassification
    {
        public int ReleaseItemClassificationId { get; set; }
        public string Description { get; set; }
        public double TotalAmount { get; set; }
    }
}
