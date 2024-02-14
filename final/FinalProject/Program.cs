class Program
{
    static void Main(string[] args)
    {
        // Create a new Database
        Database database = new Database();

        // Create a new User
        User user = new User("username", "password", "email@example.com", database);

        while (true)
        {
            Console.WriteLine("Please enter the type of transaction (income/expense/savings), 'load' to load saved transactions, or 'exit' to quit:");
            string transactionType = Console.ReadLine();

            if (transactionType.ToLower() == "exit")
            {
                break;
            }
            else if (transactionType.ToLower() == "load")
            {
                database.LoadTransactions();
                user.viewReport();
                continue;
            }

            Console.WriteLine("Please enter the amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the category:");
            string categoryName = Console.ReadLine();
            Category category = new Category(categoryName);

            if (transactionType.ToLower() == "income")
            {
                user.addIncome(amount, category);
            }
            else if (transactionType.ToLower() == "expense")
            {
                user.addExpense(amount, category);
            }
            else if (transactionType.ToLower() == "savings")
            {
                user.addSavings(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Please enter 'income', 'expense', 'savings', or 'load'.");
            }
        }

        // Save transactions
        database.SaveTransactions();

        // View report
        user.viewReport();
    }
}
