using System;
using System.Linq;
using System.Windows.Forms;
using System.Management.Automation;

namespace WindowsDefenderExclusionsEditor
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddCommand("Get-MpPreference");
                var results = ps.Invoke();
                if (results.Any())
                {
                    PSObject r = results.First();

                    string[] exclusionPath = (string[])r.Properties["ExclusionPath"].Value ?? new string[0];
                    string[] exclusionProcess = (string[])r.Properties["ExclusionProcess"].Value ?? new string[0];
                    string[] exclusionExtension = (string[])r.Properties["ExclusionExtension"].Value ?? new string[0];

                    exclusionPathList.Items.AddRange(exclusionPath);
                    exclusionProcessList.Items.AddRange(exclusionProcess);
                    exclusionExtensionList.Items.AddRange(exclusionExtension);
                }
            }
        }

        private void deletePathButton_Click(object sender, EventArgs e)
        {
            performDelete(exclusionPathList, "ExclusionPath");
        }

        private void deleteProcessButton_Click(object sender, EventArgs e)
        {
            performDelete(exclusionProcessList, "ExclusionProcess");
        }

        private void deleteExtensionButton_Click(object sender, EventArgs e)
        {
            performDelete(exclusionExtensionList, "ExclusionExtension");
        }

        private void performDelete(ListBox listBox, string param)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                using (PowerShell ps = PowerShell.Create())
                {
                    ps.AddCommand("Remove-MpPreference");
                    ps.AddParameter(param, listBox.SelectedItems.Cast<string>().ToArray());
                    ps.Invoke();
                }

                foreach (int index in listBox.SelectedIndices.Cast<int>().Select(x => x).Reverse())
                    listBox.Items.RemoveAt(index);
            }
        }
    }
}
