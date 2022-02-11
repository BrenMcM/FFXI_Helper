using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FFXI.Entourage_2
{
    public partial class MemberSelector : Form
    {
        private IEnumerable<Process> Processes;
        private DialogResult Result;
        public int SelectedProcess;

        public MemberSelector()
        {
            InitializeComponent();
            btnSelect.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void MemberSelector_Load(object sender, EventArgs args)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedProcess = Processes.ElementAt(cbxProcesses.SelectedIndex).Id;
        }
    }
}
