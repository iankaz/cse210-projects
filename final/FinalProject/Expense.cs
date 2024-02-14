public class Expense
{
    public double Amount { get; set; }
    public Category Category { get; set; }

    public Expense(double amount, Category category)
    {
        this.Amount = amount;
        this.Category = category;
    }
}
