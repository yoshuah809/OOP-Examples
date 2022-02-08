// See https://aka.ms/new-console-template for more information


var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
comp.TogglePower();



System.Console.WriteLine("Computer Name is: " + comp.name);
System.Console.WriteLine("Computer  is On: " + comp.isOn);
comp.TogglePower();
System.Console.WriteLine("Computer  is On: " + comp.isOn);
System.Console.WriteLine("Computer  case: " + comp.caseType);