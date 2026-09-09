int age = 20;
bool hasId = false;
bool isMember = true;
bool hasCoupon = false;
bool isClosed = true;

bool canEnter = age >= 18 && hasId;
bool discount = isMember || hasCoupon;
bool open = !isClosed;


Console.WriteLine(canEnter);
Console.WriteLine(discount);
Console.WriteLine(open);