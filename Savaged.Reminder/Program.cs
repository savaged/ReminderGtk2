using System;
using Gtk;

namespace Savaged.Reminder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();

            var text = "supply command line arg (in quotes) to go here";

            if (args != null 
                && args.Length > 0 
                && !string.IsNullOrEmpty(args[0]))
            {
                text = args[0];
            }

            MainWindow win = new MainWindow(text);
            win.Show();
            Application.Run();
        }
    }
}
