using Un_métier_de_précision;

Console.WriteLine("Please enter how many floors are required in your building");
int floorLevels = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of your building");
int heightOfBuilding = int.Parse(Console.ReadLine());   

Building building1 = new Building(floorLevels,heightOfBuilding);


Console.WriteLine($"Building 1 size = {building1.GetSize()} meters");

Console.WriteLine("Please enter the number of floors required");
int floorlevelbuilding2 = int.Parse(Console.ReadLine());

Building building2 = new Building(floorlevelbuilding2);
Console.WriteLine($"Building 2 size = {building2.GetFloorCount()} meters");

Console.WriteLine("Please enter height of building");
int heightMaxSize = int.Parse(Console.ReadLine());
Console.WriteLine("Now enter the floor level");
int floorMaxSize = int.Parse(Console.ReadLine());

Building building3 = new Building(heightMaxSize, floorMaxSize);
Console.WriteLine($"The maximum size of A floor level is {building3.GetFloorMaxSize()}  meters");




