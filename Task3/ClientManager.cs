namespace Task3;

public class ClientManager<T> where T: Client
{
    private List<T> list = new List<T>();
    
    public bool Add(T client)
    {
        if (client != null)
        {
            list.Add(client);
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Delate(string _name)
    {
        var del = list.Find(x => x.Name == _name);
        if (del != null)
        {
            list.Remove(del);
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public T GetById(int id)
    {
        var categ = list.Find(x => x.ClientId == id);
        if (categ != null)
        {
            foreach (var a in list)
            {
                Console.WriteLine(a.Name + " " + a.ClientId + " " + a.ContactInfo);
            }
        }
        else
        {
            Console.WriteLine("This id doesn't exist");
        }

        return null;
    }
    
    public List<T> GetAllItems()
    {
        if (list.Count != 0)
        {
            foreach (var VARIABLE in list)
            {
                Console.WriteLine($"Name: {VARIABLE.Name}, ClientId: {VARIABLE.ClientId}, ContactInfo: {VARIABLE.ContactInfo}");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }

        return null;
    }
}