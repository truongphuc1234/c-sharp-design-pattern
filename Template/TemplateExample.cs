abstract class GameAI
{
    public void TakeTurn()
    {
        CollectResource();
        BuildStructures();
        BuildUnits();
        Actack();
    }

    public void CollectResource()
    {

    }
    public abstract void BuildStructures();
    public abstract void BuildUnits();

    public void Actack()
    {
        SendScouts();
        SendWarriors();
    }

    public abstract void SendScouts();

    public abstract void SendWarriors();

}

class OrcsAI : GameAI
{
    public override void BuildStructures()
    {
        Console.WriteLine("Orc build structures");
    }

    public override void BuildUnits()
    {
        Console.WriteLine("Create 100 Orcs ");
    }

    public override void SendScouts()
    {
        Console.WriteLine("Send orc scout ");
    }

    public override void SendWarriors()
    {
        Console.WriteLine("Send warrior to front");
    }
}