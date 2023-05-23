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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Add("Shoes");
            this.checkedListBox1.Items.Add("Socks");
            this.checkedListBox1.Items.Add("Shirt");
            this.checkedListBox1.Items.Add("T-Shirt");
            this.checkedListBox1.Items.Add("Denium");
            this.checkedListBox1.Items.Add("Jogger");
            this.checkedListBox1.Items.Add("Shorts");
            this.checkedListBox1.Items.Add("Cap");

            label5.Text = Form1.instance.tb1.Text;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue==CheckState.Checked)
                Form1.instance.lb1.Items.Add(checkedListBox1.SelectedItem.ToString());
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added To the Cart");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
