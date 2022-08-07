using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GServerExecuter
{
    public partial class SaveConfigWindow : Form
    {
        public SaveConfigWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            mainwindow.SaveConfig(this.textBox1.Text);
            this.Close();
        }

        public ServerWindow mainwindow;
    }
}
