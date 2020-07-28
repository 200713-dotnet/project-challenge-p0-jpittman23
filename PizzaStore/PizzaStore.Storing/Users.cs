using System;
using System.Collections.Generic;

namespace PizzaStore.Storing
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }
    }
}
