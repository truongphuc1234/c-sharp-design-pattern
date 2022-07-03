namespace CORExample;
interface ComponentWithContextualHelper
{
    void ShowHelp();
}

abstract class Component : ComponentWithContextualHelper
{
    public Container Container;
    public string TooltipText { get; set; } = string.Empty;
    public void ShowHelp()
    {
        if (TooltipText != string.Empty)
        {
            Console.WriteLine(TooltipText);
        }
        else
        {
            Container.ShowHelp();
        }
    }
}

class Container : Component
{
    protected List<Component> _childrens;
    public virtual void Add(Component child)
    {
        _childrens.Add(child);
        child.Container = this;
    }
}

class Panel : Container
{
    public string ModalHelpText { get; set; } = string.Empty;


    public override void Add(Component child)
    {
        if (ModalHelpText != string.Empty)
        {
            Console.WriteLine(ModalHelpText);
        }
        else
        {
            base.ShowHelp();
        }
    }
}

class Dialog : Container
{
    public string WikiPageUrl = string.Empty;

    public override void Add(Component child)
    {
        if (WikiPageUrl != string.Empty)
        {
            Console.WriteLine(WikiPageUrl);
        }
        else
        {
            base.ShowHelp();
        }
    }
}

class Button : Component
{
}