using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.BugTracker
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            customTextBox1.LabelText = "Username";
            customTextBox1.TextBoxText = "Some values";
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
