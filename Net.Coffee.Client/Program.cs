using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Net.Coffee.Library.Core;

namespace Net.Coffee.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Platform.InitializeWithCoreServices<Startup>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var viewMain = ServiceLocator.GetService<ViewMain>();
            Application.Run(viewMain);
        }
    }
}
