using System.Diagnostics;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string text = startTextbox.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
            loadProcessList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProcessList();
           

        }

        private void loadProcessList()
        {
            listView1.Items.Clear();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.Tag = process;
                listView1.Items.Add(item);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
           ListViewItem item = listView1.SelectedItems[0];
           Process process = (Process)item.Tag;
           process.Kill();
           loadProcessList();
        }
    }
}