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
        private LoginService loginService = new LoginService();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Refreshworkitems();
        }

        void PopulateComboBox()
        {
            //comboBox1.Items = loginService.GetAll().
        }

        void Refreshworkitems()
        {
            //dataGridView1.DataSource = workItemservice.GetAll();
            //dataGridView1.Refresh();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            var data = workItemservice.GetAll();
            var todoitem = data.Where(p => p.Status == WorkItemStatus.ToDo).ToArray();
            var Inprogressitem = data.Where(p => p.Status == WorkItemStatus.InProgress).ToArray();
            var doneitem = data.Where(p => p.Status == WorkItemStatus.Done).ToArray();

            listBox1.Items.AddRange(todoitem);
            listBox2.Items.AddRange(Inprogressitem);
            listBox3.Items.AddRange(doneitem);

            listBox1.Refresh();
            listBox2.Refresh();
            listBox3.Refresh();
        }

        void ResetForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
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
                ResetForm();
                //comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            if(item!=null)
            {

            var itemArray = item.ToString().Split(':');
            var id = Convert.ToInt32(itemArray[0]);
            workItemservice.ChangestateofWorkItem(id, WorkItemStatus.InProgress);
            Refreshworkitems(); 

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            if (item != null)
            {

                var itemArray = item.ToString().Split(':');
                var id = Convert.ToInt32(itemArray[0]);
                workItemservice.ChangestateofWorkItem(id, WorkItemStatus.ToDo);
                Refreshworkitems();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            if (item != null)
            {

                var itemArray = item.ToString().Split(':');
                var id = Convert.ToInt32(itemArray[0]);
                workItemservice.ChangestateofWorkItem(id, WorkItemStatus.Done);
                Refreshworkitems();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var item = listBox3.SelectedItem;
            if (item != null)
            {

                var itemArray = item.ToString().Split(':');
                var id = Convert.ToInt32(itemArray[0]);
                workItemservice.ChangestateofWorkItem(id, WorkItemStatus.InProgress);
                Refreshworkitems();

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            if (item != null)
            {

                var itemArray = item.ToString().Split(':');
                var id = Convert.ToInt32(itemArray[0]);
                var workitem = workItemservice.Getbyid(id);
                textBox1.Text = workitem.Title;
                textBox2.Text = workitem.Description;

            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            if (item != null)
            {

                var itemArray = item.ToString().Split(':');
                var id = Convert.ToInt32(itemArray[0]);
                var workitem = workItemservice.Getbyid(id);
                textBox1.Text = workitem.Title;
                textBox2.Text = workitem.Description;

            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            var item = listBox3.SelectedItem;
            if (item != null)
            {

                var itemArray = item.ToString().Split(':');
                var id = Convert.ToInt32(itemArray[0]);
                var workitem = workItemservice.Getbyid(id);
                textBox1.Text = workitem.Title;
                textBox2.Text = workitem.Description;

            }
        }
    }
}
