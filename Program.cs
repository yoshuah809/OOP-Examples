// See https://aka.ms/new-console-template for more information


//var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
var comp = new Laptop("Generic Computer", 1024, 768);



System.Console.WriteLine("Computer Name is: " + comp.name);
System.Console.WriteLine("Computer  is On: " + comp.isOn);

comp.TogglePower();
System.Console.WriteLine("Computer  is On: " + comp.isOn);
//System.Console.WriteLine("Computer  case: " + comp.caseType);

var sleeppingComp = comp as ISleep;

if(sleeppingComp != null)
{
    sleeppingComp.ToggleSleep();
    System.Console.WriteLine("Computer  is Sleeping: " + sleeppingComp.isSleeping);

    comp.TogglePower();
    System.Console.WriteLine("Computer  is On: " + comp.isOn);

}
