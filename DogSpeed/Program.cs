double distance0 = 10;
double firstFriendSpeed = 5;
double secondFriendsSpeed = 6;
double dogSpeed = 10;
double distance = 1000;
double time = 0;
int friend = 2;
int count = 0;

while(distance > distance0)
{
if(friend == 2)
{
 time = distance/(secondFriendsSpeed + dogSpeed);
 friend = 1;
 
}
else
{
 time = distance/(firstFriendSpeed + dogSpeed);
 friend = 2;
 
}
distance = distance - (firstFriendSpeed + secondFriendsSpeed) * time;
Console.Write($"Собака пробежала {count + 1} раз | ");
Console.WriteLine($"Дистанция = {distance:F2}");
count++;
}
