

using Task1;

EventList eventList = new EventList();

Event event1 = new Event();
event1.Name = "Joe";
event1.Description = "Bob";
event1.StartTime = DateTime.Now;
event1.EndTime = DateTime.Now;
eventList.Add(event1);

Event event2 = new Event();
event2.Name = "Gaga";
event2.Description = "Ojsd";
event2.StartTime = DateTime.Now.AddDays(5);
event2.EndTime = DateTime.Now;
eventList.Add(event2);

eventList.Search(DateTime.Now.AddHours(12));


