using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow(string text) : base(Gtk.WindowType.Toplevel)
    {
        Build();

        label1.Text = text;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
