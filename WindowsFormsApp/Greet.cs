using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Greet : Form
    {
        public Greet(string[] args)
        {
            InitializeComponent();

            var message = "";
            Array.ForEach(args, (arg) => { message += arg; });
            lblGreet.Text = message;
        }
    }
}
