using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Greet : Form
    {
        public Greet(string[] args)
        {
            InitializeComponent();
            lblGreet.Text = string.Join(" ", args);
        }
    }
}
