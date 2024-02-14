// Transaction.cs
public class Transaction
{
    private int transactionId;
    private double amount;
    private string date;
    private string category;

    public Transaction(int transactionId, double amount, string date, string category)
    {
        this.transactionId = transactionId;
        this.amount = amount;
        this.date = date;
        this.category = category;
    }

    public void createTransaction()
    {
        // To be implemented
    }

    public void editTransaction()
    {
        // To be implemented
    }

    public void deleteTransaction()
    {
        // To be implemented
    }
}
