public class Computer
{ 

    protected string _name = "Unknown";
    public string name { get 
        {
        return _name;
        }
        private set {
            _name = value;
        }
    }

    public Computer(string name)
    {
        this.name = name;
    }

}