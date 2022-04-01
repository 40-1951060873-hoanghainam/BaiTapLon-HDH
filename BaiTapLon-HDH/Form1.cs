using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_HDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Start
        private void button1_Click(object sender, EventArgs e)
        {
            string text = startTextBox.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
        }

        //List
        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach(Process process in processlist)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = process;
                listView1.Items.Add(item);
            }
        }
    }
}
