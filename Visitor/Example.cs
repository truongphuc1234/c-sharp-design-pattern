namespace VisitorExample;

interface IShape
{
    void Accept(IVisitor visitor);

}

interface IVisitor
{
    void VisitDot(Dot d);
    void VisitCircle(Circle circle);
    void VisitRectangle(Rectangle rectangle);
    void VisitCompoundGraphic(CompoundGraphic d);
}

class Dot : IShape
{
    public int CoorX { get; set; }
    public int CoorY { get; set; }
    public void Accept(IVisitor visitor)
    {
        visitor.VisitDot(this);
    }
}
class Circle : IShape
{

    public int CoorX { get; set; }
    public int CoorY { get; set; }
    public int Radius { get; set; }
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCircle(this);
    }
}
class Rectangle : IShape
{
    public int CoorX { get; set; }
    public int CoorY { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public void Accept(IVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }
}
class CompoundGraphic : IShape
{
    public List<IShape> Childs { get; set; } = new();
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCompoundGraphic(this);
    }
}

class XMLExportVisitor : IVisitor
{
    public void VisitCircle(Circle circle)
    {
        Console.WriteLine("Print Circle");
    }

    public void VisitCompoundGraphic(CompoundGraphic d)
    {
        Console.WriteLine("Print Compound Graphic");
    }

    public void VisitDot(Dot d)
    {
        Console.WriteLine("Print Dot");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        Console.WriteLine("Print Rectangle");
    }
}