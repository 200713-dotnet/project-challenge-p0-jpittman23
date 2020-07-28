using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Store
    {
        public int Storeid { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }
    }
}
