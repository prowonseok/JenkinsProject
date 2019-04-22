using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JenkinsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "HelloJenkins";
            label1.Text = "JenkisnFailTest";
        }
        public int Method(int x) {
            if (x==100)
            {
                x *= 999999999;
            }
            return x * 2;
        }
    }
}
