using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        { // C:\Users\shannon\Programming\Solutions to Programming Problems\chapter07\Program7_1\Program7_1\Sales.txt
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string input = null;
            double total = 0; 
            using (StreamReader Sales = File.OpenText(@"C:\\users\shannon\Programming\Solutions to Programming Problems\chapter07\Program7_1\Program7_1\Sales.txt"))
            {
                while ((input = Sales.ReadLine()) != null)
                {
                    listBox1.Items.Add(input);
                    total += Convert.ToDouble(input);
                }
                Sales.Close();
            }
            label1.Text = total.ToString();
            string[] salesArray = new string[7];
            listBox1.Items.CopyTo(salesArray,0);
            averageLabel.Text = Average(salesArray).ToString("C");

            minLabel.Text = salesArray.Min();
            maxLabel.Text = salesArray.Max();
        }

        public double Average(string[] array)
        {
            double total = 0;
            foreach (string s in array)
            {
                total += Convert.ToDouble(s);              
            }

            double average = total/array.Length;
            return average;
        }

    }
}
