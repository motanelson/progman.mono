using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace progman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String s = File.ReadAllText("progman.txt");
            String[] ss=s.Split('\n');
            foreach (var lines in ss) 
            {
                listBox1.Items.Add(lines);
            
            
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            try
            {
                s = listBox1.Text.Trim();
                
                if (s!= "") Process.Start(s);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }
    }
}
