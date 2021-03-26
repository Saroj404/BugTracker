using Broadway.BugTracker.Model;
using Broadway.BugTracker.Service;
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
    public partial class Dashboard : Form
    {
        private WorkItemservice workItemservice = new WorkItemservice();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Refreshworkitems();
        }

        void Refreshworkitems()
        {
            dataGridView1.DataSource = workItemservice.GetAll();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new WorkItems()
            {
                Title = textBox1.Text,
                Description = textBox2.Text,
                //AssigneeId = (int)comboBox1.SelectedValue
            };
            var result=   workItemservice.CreateWorkItem(item);
            if(result.Item1)
            {
                Refreshworkitems();
                textBox1.Text = "";
                textBox2.Text = "";
                //comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
                       
        }
    }
}
