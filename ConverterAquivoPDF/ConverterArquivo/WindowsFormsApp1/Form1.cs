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

namespace ConverterArquivo
{
    public partial class Form1 : Form
    {
        public ConverterPdf Arquivo;
        public string NomeArquivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arquivo = new ConverterPdf(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                NomeArquivo = openFileDialog1.SafeFileName.Substring(0, openFileDialog1.SafeFileName.Length - 4);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arquivo.Converter(textBox1.Text, textBox2.Text, NomeArquivo);
        }
    }
}
