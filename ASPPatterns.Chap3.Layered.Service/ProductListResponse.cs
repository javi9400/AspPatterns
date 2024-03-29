﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Service
{
   public class ProductListResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public IList<ProductViewModel> products { get; set; }
    }
}
