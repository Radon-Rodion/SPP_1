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
//using static SortLibrary.Class1;

namespace SPP1_Visual
{
    public partial class Form1 : Form
    {
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
            inputAddress.Text = filename;
        }

        private void BtnChooseOutpt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            outputAddress.Text = filename;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {

        }
    }

}
