public class Income
{
    public double Amount { get; set; }
    public Category Category { get; set; }

    public Income(double amount, Category category)
    {
        this.Amount = amount;
        this.Category = category;
    }
}
