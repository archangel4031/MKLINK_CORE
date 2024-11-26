using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MkLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseSource_Click(object sender, EventArgs e)
        {

            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = folderDialog.SelectedPath;
                }
            }

            //For Old Version
            //using (var folderPicker = new CommonOpenFileDialog())
            //{
            //    folderPicker.IsFolderPicker = true;

            //    if (folderPicker.ShowDialog() == CommonFileDialogResult.Ok)
            //    {
            //        txtSource.Text = folderPicker.FileName;
            //    }
            //}
        }

        private void browseDestination_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = folderDialog.SelectedPath;
                }
            }

            //For Old Version
            //using (var folderPicker = new CommonOpenFileDialog())
            //{
            //    folderPicker.IsFolderPicker = true;

            //    if (folderPicker.ShowDialog() == CommonFileDialogResult.Ok)
            //    {
            //        txtDestination.Text = folderPicker.FileName;
            //    }
            //}
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // Validate input paths
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Source and destination paths cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if paths are empty
            }

            if (!Directory.Exists(txtSource.Text))
            {
                MessageBox.Show("The source path does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if source path does not exist
            }

            if (chkRename.Checked && !Directory.Exists(txtDestination.Text))
            {
                MessageBox.Show("The destination path does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if destination path does not exist
            }

            // If validation passes, show preview
            string commandPreview = "=====PREVIEW ONLY=====" + Environment.NewLine;

            if (chkRename.Checked)
            {
                string sourceFolderName = Path.GetFileName(txtSource.Text.TrimEnd(Path.DirectorySeparatorChar));
                commandPreview += $"mklink /J \"{txtDestination.Text}\\{sourceFolderName}\" \"{txtSource.Text}\"";
            }
            else
            {
                commandPreview += $"mklink /J \"{txtDestination.Text}\" \"{txtSource.Text}\"";
            }

            txtOutput.Text = commandPreview;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // Validate input paths
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Source and destination paths cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if paths are empty
            }

            if (!Directory.Exists(txtSource.Text))
            {
                MessageBox.Show("The source path does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if source path does not exist
            }

            if (chkRename.Checked && !Directory.Exists(txtDestination.Text))
            {
                MessageBox.Show("The destination path does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if destination path does not exist
            }

            // If validation passes, execute the command
            string command;
            if (chkRename.Checked)
            {
                string sourceFolderName = Path.GetFileName(txtSource.Text.TrimEnd(Path.DirectorySeparatorChar));
                command = $"mklink /J \"{txtDestination.Text}\\{sourceFolderName}\" \"{txtSource.Text}\"";
            }
            else
            {
                command = $"mklink /J \"{txtDestination.Text}\" \"{txtSource.Text}\"";
            }

            try
            {
                // Start a process to execute the command
                var processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + command)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = System.Diagnostics.Process.Start(processInfo))
                {
                    // Read the output and error streams
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    // Display the output and error in the text box
                    txtOutput.Text = output + (string.IsNullOrEmpty(error) ? string.Empty : "\nError: " + error);

                    if (string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Link created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Command executed with errors.", "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing command: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
