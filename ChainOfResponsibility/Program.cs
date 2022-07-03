using CORExample;
using CORStructure;

var dialog = new Dialog { TooltipText = "Budget Reports", WikiPageUrl = "http://..." };
var panel = new Panel { ModalHelpText ="Modal Help", TooltipText = "This cancel panel"};

var btn = new Button{TooltipText = "Cancel Button"};
var okBtn = new Button{TooltipText = "Ok Button"};

panel.Add(btn);
panel.Add(okBtn);
dialog.Add(panel);

panel.ShowHelp();

// Handler
var handler1 = new ConcreteHandlerA();
var handler2 = new ConcreteHandlerB();
var handler3 = new COncreteHandlerC();

handler1.SetNext(handler2);
handler2.SetNext(handler3);

handler1.Handle("abc");
