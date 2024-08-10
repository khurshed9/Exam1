
using Task2;

Inventor<Item> inventor = new Inventor<Item>();

Item item1 = new Item();
item1.Name = "Lo";
item1.Category = "POP";
item1.MyEnum = ItemEnum.HomeItem;
inventor.Add(item1);


Item item2 = new Item();
item1.Name = "Hid";
item1.Category = "Jns";
item1.MyEnum = ItemEnum.OfficeItem;
inventor.Add(item2);

inventor.Remove(new Item{Name = "Hid",Category = "Jns",MyEnum = ItemEnum.OfficeItem});


