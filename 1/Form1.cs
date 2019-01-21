using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)
            {
                case Keys.NumPad2:
                    this.Top += 10;
                    label1.Text = "↓";
                    break;
            }

            switch (e.KeyCode.ToString())
            {
                case "Up":
                    this.Top -= 10;
                    label1.Text = "↑";
                    break;
            }
            switch (e.KeyCode.ToString())
            {
                case "Left":
                    this.Left -= 10;
                    label1.Text = "←";
                    break;
            }
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    this.Left += 10;
                    label1.Text = "→";
                    break;
            }
        }
    }
}

