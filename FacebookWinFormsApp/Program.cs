using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

// $G$ RUL-003 (-10) Diagram document should be attached to the solution.
// $G$ RUL-005 (-20) Wrong zip folder structure
// $G$ RUL-004 (-20) Wrong diagram document name.
// $G$ RUL-006 (-40) Late submission (-1 days)
// $G$ THE-001 (-19) your grade on diagrams document - 81. please see comments inside the document. 40% of your grade).
namespace BasicFacebookFeatures
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
