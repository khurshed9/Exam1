namespace Task2;

public class Inventor<T> where T: Item
{
    private List<Item> list = new List<Item>();

    public bool Add(T item)
    {
        if (item != null)
        {
            list.Add(item);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Remove(T item)
    {
        var rem = list.Find(x => x.Name == item.Name);
        if (rem != null)
        {
            list.Remove(rem);
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<T> GetItemsBycategory(string category)
    {
        var categ = list.Find(x => x.Category == category);
        if (categ != null)
        {
            foreach (var a in list)
            {
                Console.WriteLine(a.Name + " " + a.Category);
            }
        }
        else
        {
            Console.WriteLine("This category doesn't exist");
        }

        return null;
    }

    public List<T> GetItemsByType(ItemEnum type)
    {
        var _type = list.Find(x => x.MyEnum == type);
        if (_type != null)
        {
            foreach (var b in list)
            {
                Console.WriteLine(b.Name + " " + b.Category + " " + b.MyEnum);
            }
        }
        else
        {
            Console.WriteLine("There is no type like that");
        }

        return null;
    }

    public List<T> GetAllItems()
    {
        if (list.Count != 0)
        {
            foreach (var VARIABLE in list)
            {
                Console.WriteLine($"Name: {VARIABLE.Name}, Category: {VARIABLE.Category}, Enum: {VARIABLE.MyEnum}");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }

        return null;
    }
}