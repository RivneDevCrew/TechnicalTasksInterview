using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectInputFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                inputFolderTextBox.Text = fbd.SelectedPath;
            
        }

        private void serializeButton_Click(object sender, EventArgs e)
        {
            string inputPath = inputFolderTextBox.Text;
            string outputPath = "content.bin";

            string[] dirs = Directory.GetDirectories(inputPath, "*", SearchOption.AllDirectories).Select(Path.GetFullPath).ToArray();
            string[] files = Directory.GetFiles(inputPath, "*", SearchOption.AllDirectories).Select(Path.GetFullPath).ToArray();

            Folder folder = new Folder(dirs, files);

            using (Stream stream = File.Open(outputPath, FileMode.Create))
            {
                var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    bFormatter.Serialize(stream, folder);
                    MessageBox.Show("Success! Result binary file is: " + outputPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void selectOutputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "(*.bin)|*.bin";

            DialogResult result = opd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(opd.FileName))
                outputFileTextBox.Text = opd.FileName;
        }

        private void selectOutputFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                outputFolderTextBox.Text = fbd.SelectedPath;
        }

        private void deserializeButton_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open(outputFileTextBox.Text, FileMode.Open))
            {
                var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                try
                {
                    Folder sourceFolder = (Folder)bFormatter.Deserialize(stream);
                    MessageBox.Show(sourceFolder.ToString());
                    sourceFolder.Unpack(outputFolderTextBox.Text);

                    MessageBox.Show("Folder was successfully unpacked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
