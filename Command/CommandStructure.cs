interface ICommand
{
    void Execute();
}

class Invoker
{
    public ICommand Command { get; set; }
    public void ExecuteCommand()
    {
        Command.Execute();
    }

}

class ConcreteCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Command 1 Execute");
    }
}
class ConcreteCommand2 : ICommand
{
    public Receiver Receiver { get; set; }
    public string Message { get; set; }
    public void Execute()
    {
        Receiver.Operate(Message);
    }
}

class Receiver
{
    public void Operate(string msg)
    {
        Console.WriteLine($"Receive do acton by {msg}");
    }
}