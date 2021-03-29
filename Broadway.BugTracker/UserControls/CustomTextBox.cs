using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.BugTracker.UserControls
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        private void CustomTextBox_Load(object sender, EventArgs e)
        {

        }

        public string LabelText
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        
        }

        public string TextBoxText
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

    }
}
