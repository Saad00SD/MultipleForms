using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public ListBox lb1;
        public TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            lb1 = listBox1;
            tb1 = textBox1;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string items= this.additemtxt.Text.ToString();

            listBox1.Items.Add(items);
            this.additemtxt.Clear();
            this.additemtxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.additemtxt.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            this.additemtxt.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string listBoxItemText= listBox1.SelectedItem.ToString();
            if (index>0)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index-1, listBoxItemText);
                listBox1.SetSelected(index - 1, true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string listBoxItemText = listBox1.SelectedItem.ToString();
            if (index < listBox1.Items.Count-1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index + 1, listBoxItemText);
                listBox1.SetSelected(index + 1, true);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           int index= listBox1.FindString(additemtxt.Text);
            if (index>-1)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("Item Not Found!!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
