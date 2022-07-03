using VisitorExample;

var dot = new Dot();
var circle = new Circle();
var compoundGraphic = new CompoundGraphic();
var rectangle = new Rectangle();

var xmlExporter  = new XMLExportVisitor();

var shapes = new List<IShape>();
shapes.Add(dot);
shapes.Add(circle);
shapes.Add(compoundGraphic);
shapes.Add(rectangle);

foreach(var shape in shapes)
{
    shape.Accept(xmlExporter);
}