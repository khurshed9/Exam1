namespace Task1;

public class EventList : Event
{
    private List<Event> _list = new List<Event>();

    public bool Add(Event _event)
    {
        if (_event != null)
        {
            _list.Add(_event);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Delate(string _name)
    {
        var del = _list.Find(x => x.Name == _name);
        if (del != null)
        {
            _list.Remove(del);
            return true;
        }
        else
        {
            return false;
        }
    }


    public void Search(DateTime dateTime)
    {
        foreach (var data in _list)
        {
            int cnt = 0;
            if (data.StartTime.Day == dateTime.Day && data.StartTime.Month == dateTime.Month && data.StartTime.Year == dateTime.Year)
            {
                cnt++;
                Console.WriteLine(data.Name + " " + data.Description + " " + data.StartTime + " " + data.EndTime);
            }
            else if(cnt == 0)
            {
                Console.WriteLine("There is not DateTime like that");
            }
        }
    }
}