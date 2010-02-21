// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Pinta {
    
    
    public partial class MainWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FileAction;
        
        private Gtk.Action EditAction;
        
        private Gtk.Action ViewAction;
        
        private Gtk.Action ImageAction;
        
        private Gtk.Action LayersAction;
        
        private Gtk.Action AdjustmentsAction;
        
        private Gtk.Action EffectsAction;
        
        private Gtk.Action WindowAction;
        
        private Gtk.Action HelpAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.Toolbar toolbar1;
        
        private Gtk.Toolbar tooltoolbar;
        
        private Gtk.HBox hbox1;
        
        private Gtk.HBox hbox2;
        
        private Gtk.VBox vbox3;
        
        private Pinta.ColorPaletteWidget colorpalettewidget1;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Toolbar toolbox1;
        
        private Gtk.Toolbar toolbox2;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.DrawingArea drawingarea1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private Pinta.LayersListWidget layerslistwidget1;
        
        private Gtk.Toolbar toolbar4;
        
        private Gtk.ScrolledWindow GtkScrolledWindow1;
        
        private Gtk.TreeView treeview1;
        
        private Gtk.Toolbar toolbar2;
        
        private Gtk.Statusbar statusbar1;
        
        private Gtk.Label label5;
        
        private Gtk.Label CursorPositionLabel;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Pinta.MainWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("File"), null, null);
            this.FileAction.HideIfEmpty = false;
            this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
            w1.Add(this.FileAction, null);
            this.EditAction = new Gtk.Action("EditAction", Mono.Unix.Catalog.GetString("Edit"), null, null);
            this.EditAction.HideIfEmpty = false;
            this.EditAction.ShortLabel = Mono.Unix.Catalog.GetString("Edit");
            w1.Add(this.EditAction, null);
            this.ViewAction = new Gtk.Action("ViewAction", Mono.Unix.Catalog.GetString("View"), null, null);
            this.ViewAction.HideIfEmpty = false;
            this.ViewAction.ShortLabel = Mono.Unix.Catalog.GetString("View");
            w1.Add(this.ViewAction, null);
            this.ImageAction = new Gtk.Action("ImageAction", Mono.Unix.Catalog.GetString("Image"), null, null);
            this.ImageAction.HideIfEmpty = false;
            this.ImageAction.ShortLabel = Mono.Unix.Catalog.GetString("Image");
            w1.Add(this.ImageAction, null);
            this.LayersAction = new Gtk.Action("LayersAction", Mono.Unix.Catalog.GetString("Layers"), null, null);
            this.LayersAction.HideIfEmpty = false;
            this.LayersAction.ShortLabel = Mono.Unix.Catalog.GetString("Layers");
            w1.Add(this.LayersAction, null);
            this.AdjustmentsAction = new Gtk.Action("AdjustmentsAction", Mono.Unix.Catalog.GetString("Adjustments"), null, null);
            this.AdjustmentsAction.HideIfEmpty = false;
            this.AdjustmentsAction.ShortLabel = Mono.Unix.Catalog.GetString("Adjustments");
            w1.Add(this.AdjustmentsAction, "<Control>a");
            this.EffectsAction = new Gtk.Action("EffectsAction", Mono.Unix.Catalog.GetString("Effects"), null, null);
            this.EffectsAction.HideIfEmpty = false;
            this.EffectsAction.ShortLabel = Mono.Unix.Catalog.GetString("Effects");
            w1.Add(this.EffectsAction, null);
            this.WindowAction = new Gtk.Action("WindowAction", Mono.Unix.Catalog.GetString("Window"), null, null);
            this.WindowAction.ShortLabel = Mono.Unix.Catalog.GetString("Window");
            this.WindowAction.Visible = false;
            w1.Add(this.WindowAction, null);
            this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("Help"), null, null);
            this.HelpAction.HideIfEmpty = false;
            this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("Help");
            w1.Add(this.HelpAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "Pinta.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("Pinta!");
            this.WindowPosition = ((Gtk.WindowPosition)(1));
            this.AllowShrink = true;
            this.DefaultWidth = 1100;
            this.DefaultHeight = 750;
            // Container child Pinta.MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            // Container child vbox1.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'/><menu name='EditAction' action='EditAction'/><menu name='ViewAction' action='ViewAction'/><menu name='ImageAction' action='ImageAction'/><menu name='LayersAction' action='LayersAction'/><menu name='AdjustmentsAction' action='AdjustmentsAction'/><menu name='EffectsAction' action='EffectsAction'/><menu name='WindowAction' action='WindowAction'/><menu name='HelpAction' action='HelpAction'/></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.vbox1.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'/></ui>");
            this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.ShowArrow = false;
            this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.toolbar1.IconSize = ((Gtk.IconSize)(2));
            this.vbox1.Add(this.toolbar1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.toolbar1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='tooltoolbar'/></ui>");
            this.tooltoolbar = ((Gtk.Toolbar)(this.UIManager.GetWidget("/tooltoolbar")));
            this.tooltoolbar.HeightRequest = 28;
            this.tooltoolbar.Name = "tooltoolbar";
            this.tooltoolbar.ShowArrow = false;
            this.tooltoolbar.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.tooltoolbar.IconSize = ((Gtk.IconSize)(2));
            this.vbox1.Add(this.tooltoolbar);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.tooltoolbar]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            // Container child vbox3.Gtk.Box+BoxChild
            this.colorpalettewidget1 = new Pinta.ColorPaletteWidget();
            this.colorpalettewidget1.Name = "colorpalettewidget1";
            this.vbox3.Add(this.colorpalettewidget1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.colorpalettewidget1]));
            w5.PackType = ((Gtk.PackType)(1));
            w5.Position = 0;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            // Container child hbox3.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='toolbox1'/></ui>");
            this.toolbox1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbox1")));
            this.toolbox1.Name = "toolbox1";
            this.toolbox1.Orientation = ((Gtk.Orientation)(1));
            this.toolbox1.ShowArrow = false;
            this.toolbox1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.toolbox1.IconSize = ((Gtk.IconSize)(2));
            this.hbox3.Add(this.toolbox1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox3[this.toolbox1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='toolbox2'/></ui>");
            this.toolbox2 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbox2")));
            this.toolbox2.Name = "toolbox2";
            this.toolbox2.Orientation = ((Gtk.Orientation)(1));
            this.toolbox2.ShowArrow = false;
            this.toolbox2.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.toolbox2.IconSize = ((Gtk.IconSize)(2));
            this.hbox3.Add(this.toolbox2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox3[this.toolbox2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox3.Add(this.hbox3);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
            w8.PackType = ((Gtk.PackType)(1));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.hbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            Gtk.Viewport w10 = new Gtk.Viewport();
            w10.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.drawingarea1 = new Gtk.DrawingArea();
            this.drawingarea1.Events = ((Gdk.EventMask)(13062));
            this.drawingarea1.Name = "drawingarea1";
            w10.Add(this.drawingarea1);
            this.GtkScrolledWindow.Add(w10);
            this.hbox2.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox2[this.GtkScrolledWindow]));
            w13.Position = 1;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Layers:");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.layerslistwidget1 = new Pinta.LayersListWidget();
            this.layerslistwidget1.Name = "layerslistwidget1";
            this.vbox2.Add(this.layerslistwidget1);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox2[this.layerslistwidget1]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='toolbar4'/></ui>");
            this.toolbar4 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar4")));
            this.toolbar4.Name = "toolbar4";
            this.toolbar4.ShowArrow = false;
            this.toolbar4.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.toolbar4.IconSize = ((Gtk.IconSize)(1));
            this.vbox2.Add(this.toolbar4);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox2[this.toolbar4]));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.GtkScrolledWindow1 = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
            this.GtkScrolledWindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
            this.treeview1 = new Gtk.TreeView();
            this.treeview1.CanFocus = true;
            this.treeview1.Name = "treeview1";
            this.GtkScrolledWindow1.Add(this.treeview1);
            this.vbox2.Add(this.GtkScrolledWindow1);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow1]));
            w18.Position = 3;
            // Container child vbox2.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='toolbar2'/></ui>");
            this.toolbar2 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar2")));
            this.toolbar2.Name = "toolbar2";
            this.toolbar2.ShowArrow = false;
            this.toolbar2.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
            this.toolbar2.IconSize = ((Gtk.IconSize)(1));
            this.vbox2.Add(this.toolbar2);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox2[this.toolbar2]));
            w19.Position = 4;
            w19.Expand = false;
            w19.Fill = false;
            this.hbox2.Add(this.vbox2);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox2]));
            w20.Position = 2;
            w20.Expand = false;
            w20.Fill = false;
            this.hbox1.Add(this.hbox2);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
            w21.Position = 0;
            this.vbox1.Add(this.hbox1);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w22.Position = 3;
            // Container child vbox1.Gtk.Box+BoxChild
            this.statusbar1 = new Gtk.Statusbar();
            this.statusbar1.Name = "statusbar1";
            this.statusbar1.Spacing = 6;
            // Container child statusbar1.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString(" Paintbrush: Left click to draw with primary color, right click to draw with secondary color");
            this.label5.Justify = ((Gtk.Justification)(3));
            this.label5.SingleLineMode = true;
            this.statusbar1.Add(this.label5);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.statusbar1[this.label5]));
            w23.Position = 0;
            w23.Expand = false;
            w23.Fill = false;
            // Container child statusbar1.Gtk.Box+BoxChild
            this.CursorPositionLabel = new Gtk.Label();
            this.CursorPositionLabel.Name = "CursorPositionLabel";
            this.CursorPositionLabel.LabelProp = Mono.Unix.Catalog.GetString("0, 0");
            this.statusbar1.Add(this.CursorPositionLabel);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.statusbar1[this.CursorPositionLabel]));
            w24.Position = 3;
            w24.Expand = false;
            w24.Fill = false;
            this.vbox1.Add(this.statusbar1);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
            w25.Position = 4;
            w25.Expand = false;
            w25.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.drawingarea1.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnDrawingarea1ButtonPressEvent);
            this.drawingarea1.ButtonReleaseEvent += new Gtk.ButtonReleaseEventHandler(this.OnDrawingarea1ButtonReleaseEvent);
            this.drawingarea1.MotionNotifyEvent += new Gtk.MotionNotifyEventHandler(this.OnDrawingarea1MotionNotifyEvent);
            this.drawingarea1.ExposeEvent += new Gtk.ExposeEventHandler(this.OnDrawingarea1ExposeEvent);
            this.drawingarea1.KeyPressEvent += new Gtk.KeyPressEventHandler(this.OnDrawingarea1KeyPressEvent);
            this.drawingarea1.KeyReleaseEvent += new Gtk.KeyReleaseEventHandler(this.OnDrawingarea1KeyReleaseEvent);
        }
    }
}
