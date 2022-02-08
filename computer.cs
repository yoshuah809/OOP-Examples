public abstract class Computer
{ 

    protected string _name = "Unknown";
    public bool isOn { get; private set; }
    public virtual string name { get 
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

    protected void TurnOn()
    {
        isOn=true;
    }
    protected void TurnOff()
    {
        isOn=false;
    }

    public virtual void TogglePower()
    {
        if (isOn) { TurnOff(); } else { TurnOn(); }
    }
    



}