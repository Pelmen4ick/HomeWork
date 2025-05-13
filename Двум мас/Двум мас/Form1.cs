using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Двум_мас
{
    public partial class Form1 : Form
    {
        float[,] a = new float[10, 10];
        int i, j, z, y;
        int Min = 0;
        Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                for (j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(textBox2.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(textBox3.Text);
            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                for (j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    a[i, j] = rnd.Next(0, 10);
                    dataGridView1 [j, i].Value = Convert.ToString(a[i, j]);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
