using EliteMMO.API;
using FFXI.MainUI.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FFXI.MainUI
{
    public partial class MainForm : Form
    {
        private IEnumerable<Process> Processes;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            Processes = Process.GetProcessesByName("pol").Union(Process.GetProcessesByName("xiloader"));
            cbxProcesses.Items.Clear();
            if (Processes.Count() < 1)
            {
                MessageBox.Show("FFXI Not Found");
            }
            else
            {
                for (int i = 0; i < Processes.Count(); i++)
                {
                    cbxProcesses.Items.Add(Processes.ElementAt(i).MainWindowTitle);
                }

                cbxProcesses.SelectedIndex = 0;
            }           
        }

        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            int processId = Processes.ElementAt(cbxProcesses.SelectedIndex).Id;
            ApiController.Api = new EliteAPI(processId);
            lblMainStatus.BackColor = Color.Green;
            lblMainStatus.Text = "Connected: " + ApiController.PlayerName;
            tcMain.Enabled = true;
        }        
    }
}
