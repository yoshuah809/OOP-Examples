class Laptop : Computer, ISleep
{   
    public Display display { get; private set; }

    public bool isSleeping => throw new NotImplementedException();

    public Laptop(string name, int width, int height) : base(name)
    {
        display = new Display(width, height);
    }

    public void ToggleSleep()
    {
        throw new NotImplementedException();
    }
}