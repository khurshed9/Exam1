namespace Task4;

public class Transaction
{
    public int Id { get; set; }

    public DateTime Start { get; set; }

    public decimal Amount { get; set; }

    public EnumTransaction MyEnum { get; set; }
}