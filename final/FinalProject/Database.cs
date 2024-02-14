public class Database
{
    public List<Income> Incomes { get; set; }
    public List<Expense> Expenses { get; set; }
    public List<Savings> Savings { get; set; }

    public Database()
    {
        Incomes = new List<Income>();
        Expenses = new List<Expense>();
        Savings = new List<Savings>();
    }

    public void AddIncome(Income income)
    {
        Incomes.Add(income);
    }

    public void AddExpense(Expense expense)
    {
        Expenses.Add(expense);
    }

    public void AddSavings(Savings savings)
    {
        Savings.Add(savings);
    }

    public void SaveTransactions()
    {
        using (StreamWriter file = new StreamWriter(@"transactions.txt"))
        {
            foreach (Income income in Incomes)
            {
                file.WriteLine($"Income,{income.Amount},{income.Category.Name}");
            }

            foreach (Expense expense in Expenses)
            {
                file.WriteLine($"Expense,{expense.Amount},{expense.Category.Name}");
            }

            foreach (Savings savings in Savings)
            {
                file.WriteLine($"Savings,{savings.Amount}");
            }
        }
    }

    public void LoadTransactions()
    {
        using (StreamReader file = new StreamReader(@"transactions.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts[0] == "Income")
                {
                    AddIncome(new Income(double.Parse(parts[1]), new Category(parts[2])));
                }
                else if (parts[0] == "Expense")
                {
                    AddExpense(new Expense(double.Parse(parts[1]), new Category(parts[2])));
                }
                else if (parts[0] == "Savings")
                {
                    AddSavings(new Savings(double.Parse(parts[1])));
                }
            }
        }
    }
}
