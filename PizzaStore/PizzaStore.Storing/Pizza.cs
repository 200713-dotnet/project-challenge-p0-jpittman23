﻿using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Pizza
    {
        public int PizzaId { get; set; }
        public int? CrustId { get; set; }
        public int? SizeId { get; set; }
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public bool? IsValid { get; set; }

        public virtual Crust Crust { get; set; }
        public virtual Size Size { get; set; }
    }
}
