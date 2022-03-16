using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace EncryptionCompare
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength == 0) { label2.Text = "Введите путь к файлу"; return; }
            string path = textBox1.Text;
            string fileContent = "";
            try
            {
                fileContent = File.ReadAllText(path);
                BindingList<Row> data = new(Benchmark.AlgorithmsBenchmark(fileContent));
                dataGridView1.DataSource = data;
            }
            catch(Exception ex)
            {
                label2.Text = "Файл не найден";
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
