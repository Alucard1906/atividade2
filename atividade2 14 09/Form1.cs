using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade2_14_09
{
    public partial class Form1 : Form
    {
        string id;
        int clear;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
      
            
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
    
            
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txb1.Clear();  
            txb2.Clear();
            txb3.Clear();
            txb4.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            id = txb1.Text;
            cb1.Items.Add(id);
            txb1.Clear();
            
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("pos:" + cb1.SelectedIndex);
            txb2.Text = cb1.SelectedIndex.ToString();
            txb3.Text = cb1.SelectedItem.ToString();
            txb4.Text = cb1.Items.Count.ToString();

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            cb1.Items.RemoveAt(clear);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            cb1.Items.Clear();
        }
    }
}
