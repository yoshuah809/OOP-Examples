// See https://aka.ms/new-console-template for more information


var comp = new Computer("Generic Computer");
comp.TogglePower();



System.Console.WriteLine("Computer Name is: " + comp.name);
System.Console.WriteLine("Computer  is On: " + comp.isOn);
comp.TogglePower();
System.Console.WriteLine("Computer  is On: " + comp.isOn);