using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SelectingFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            // open dialog to select the file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // user selected a file
                // create the input stream and open file 
                try
                {
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    string contents = "";
                    while (!inputFile.EndOfStream)
                    {
                        contents += inputFile.ReadLine() + "\n";
                    }
                    MessageBox.Show(contents);
                    // close the stream/file
                    inputFile.Close();
                }
                catch
                {
                    MessageBox.Show("Error reading the file \" + openFileDialog1.FileName + \".");
                }
            } else
            {
                MessageBox.Show("User cancelled the operation.");
            }
        }
    }
}
