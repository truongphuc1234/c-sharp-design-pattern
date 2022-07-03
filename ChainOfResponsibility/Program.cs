using CORExample;

var dialog = new Dialog { TooltipText = "Budget Reports", WikiPageUrl = "http://..." };
var panel = new Panel { ModalHelpText ="Modal Help", TooltipText = "This cancel panel"};

var btn = new Button{TooltipText = "Cancel Button"};
var okBtn = new Button{TooltipText = "Ok Button"};

panel.Add(btn);
panel.Add(okBtn);
dialog.Add(panel);

panel.ShowHelp();
