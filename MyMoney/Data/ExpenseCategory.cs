﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ExpenseCategory
    {
        public int id {get; set;}
        public string category_name {get; set;}  

        public ICollection<User> users {get; set;} = new HashSet<User>();
    }
}
