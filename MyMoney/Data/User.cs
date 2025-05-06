namespace Data
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public string password_salt { get; set; }

        public ICollection<ExpenseCategory> expenses { get; set; } = new HashSet<ExpenseCategory>();

    }
}
