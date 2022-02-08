class Desktop : Computer { 
    
    
    public enum CaseType
    {   
        Tower,
        MiniTower

    }
    public CaseType caseType { get; private set; }
    public bool isSleeping { get; private set; }
    public override string name { get
        {
            return base.name + " " + caseType;
        }
      }
    public Desktop (string name, CaseType caseType): base(name) 
    {
        this.caseType = caseType;
        
    }

    public void ToggleSleept()
    {
        if (!isOn) { return; }
        isSleeping = !isSleeping;
    }
    public override void TogglePower()
    {
        if (isSleeping) { return; }
        base.TogglePower();
    }

}