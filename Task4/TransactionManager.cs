namespace Task4;

public class TransactionManager
{
    private List<Transaction> _list = new List<Transaction>();

    public void Add(Transaction transaction)
    {
        var t = new Transaction();
        transaction.Id = 1;
        transaction.Amount = 233;
        transaction.Start = DateTime.Now;
        transaction.MyEnum = EnumTransaction.Return;
    }

    public List<Transaction> GetTransactions(DateTime dateTime)
    {
        if (DateTime.Now.Year == dateTime.Year)
        {
            foreach (var dates in _list)
            {
                Console.WriteLine(dates.Id + " " + dates.Amount + " " + dates.Start + " " + dates.MyEnum);
            }
        }
        else
        {
            Console.WriteLine("There is no DateTime like that");
        }

        return null;
    }

    public void Period(DateTime start, DateTime finish)
    {
        var q = _list.FindAll(x => x.Start > start && start < finish);
        
    }
}