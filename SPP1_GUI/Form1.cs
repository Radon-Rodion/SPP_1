using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SortLibrary;


namespace SPP1_GUI
{
    public partial class Form1 : Form
    {
        string inputFileAddr, outputFileAddr;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = FILE_CHOOSER_FILTER;
            saveFileDialog1.Filter = FILE_CHOOSER_FILTER;
        }

        private const string FILE_CHOOSER_FILTER = "All files(*.*)|*.*";

        private void BtnChooseInpt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            inputFileAddr = inputAddress.Text = filename;
        }

        private void BtnChooseOutpt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            outputFileAddr = outputAddress.Text = filename;
        }

        private void inputAddress_TextChanged(object sender, EventArgs e)
        {
            inputFileAddr = inputAddress.Text;
        }

        private void outputAddress_TextChanged(object sender, EventArgs e)
        {
            outputFileAddr = outputAddress.Text;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Class1.ProcessFile(inputFileAddr, outputFileAddr);
        }
    }
}
