using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace IsKeyDowndOn4k
{
    public partial class Form1 : Form
    {
        // YOU MUST RUN THIS APPLICATION ON A 4K SCREEN!!!!
        //
        // This sample shows how, in Windows 10, if you call Keyboard.IsKeyDown(Key.A) in the Form.Load event, on a 4K screen, the window size will be smaller.
        //
        // Depending on user settings, applications should be scaled, usually at 250% (the default option), but this does not happen if Keyboard.IsKeyDown is called on Form.Load.
        //
        // Although it's not really a problem at all, in most cases, it might reveal some imperfection that would be great to fix, in order to prevent side effects.

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Keyboard.IsKeyDown(Key.A);
            // This problem even occurs when running Keyboard.IsKeyDown on a separate thread:
            /*System.Threading.Thread t = new System.Threading.Thread(delegate ()
            {
                Keyboard.IsKeyDown(Key.A);
            });
            t.IsBackground = true;
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();*/
        }
    }
}
