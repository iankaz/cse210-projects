public class User
{
    private string username;
    private string password;
    private string email;
    private Database database;

    public User(string username, string password, string email, Database database)
    {
        this.username = username;
        this.password = password;
        this.email = email;
        this.database = database;
    }

    public void addIncome(double amount, Category category)
    {
        Income income = new Income(amount, category);
        database.AddIncome(income);
        Console.WriteLine($"Income added: {income.Amount} in category: {category.Name}");
    }

    public void addExpense(double amount, Category category)
    {
        Expense expense = new Expense(amount, category);
        database.AddExpense(expense);
        Console.WriteLine($"Expense added: {expense.Amount} in category: {category.Name}");
    }

    public void addSavings(double amount)
    {
        Savings savings = new Savings(amount);
        database.AddSavings(savings);
        Console.WriteLine($"Savings added: {savings.Amount}");
    }

    public void viewReport()
    {
        double totalIncome = database.Incomes.Sum(income => income.Amount);
        double totalExpense = database.Expenses.Sum(expense => expense.Amount);
        double totalSavings = database.Savings.Sum(savings => savings.Amount);
        double balance = totalIncome - totalExpense;

        Console.WriteLine($"Total Income: {totalIncome}");
        Console.WriteLine($"Total Expense: {totalExpense}");
        Console.WriteLine($"Total Savings: {totalSavings}");
        Console.WriteLine($"Balance: {balance}");
    }
}
