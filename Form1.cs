using System;
using System.Windows.Forms;

using System.Diagnostics;

namespace lqwl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int count = 0;
            Timer t = new Timer
            {
                Interval = 1000,
                Enabled = true
            };

            t.Tick += delegate
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.MainWindowTitle.Length != 0 && p.ProcessName == "LINE")
                    {
                        p.CloseMainWindow();
                        Application.Exit();
                    }
                }

                ++count;
                if (count > 1 * 60)
                {  // 1 min
                    Application.Exit();
                }
            };
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
