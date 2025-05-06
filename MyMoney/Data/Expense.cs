using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Expense
    {
        public int id {  get; set; }
        public float amount { get; set; }
        public string description { get; set; }
        public int user_id { get; set; }
        public User user { get; set; }
        public int expenseCategory_id { get; set; }
        public ExpenseCategory expenseCategory { get; set; }
    }
}
