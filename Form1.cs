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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {

            if (Derectory.Text.Length > 0)
            {
                string directoryPath = Derectory.Text;
                string filePath = Path.Combine(directoryPath, $"{FileName.Text}.txt");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.WriteAllText(filePath, richTextBox1.Text);

            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string directoryPath = Derectory.Text;
            string filePath = Path.Combine(directoryPath, $"{FileName.Text}.txt");

            if (File.Exists(filePath))
            {
                string fileText = File.ReadAllText(filePath);

                richTextBox1.Text = fileText;
            }
            else
            {
                MessageBox.Show("Файл не найден по указанному пути!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
