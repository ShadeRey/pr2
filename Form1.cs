using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        List<Line> lines = new List<Line>();
        private void button1_Click(object sender, EventArgs e)
        {
            lines.Add(new Line(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)));
            dataGridView1.DataSource = lines.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            int lll = lines.Count;
            for (int i = 0; i < lll; i++)
            {
                string str = $"Линия {i + 1}";
                chart1.Series.Add(str);
                chart1.Series[i].ChartType = FastReport.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[i].Points.AddXY(lines[i].X1, lines[i].Y1);
                chart1.Series[i].Points.AddXY(lines[i].X2, lines[i].Y2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text)) { dataGridView1.DataSource = lines.ToList(); return; }
            var x1 = lines.Where(s => s.X1 == Convert.ToDouble(textBox5.Text)).ToList();
            dataGridView1.DataSource = x1;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text)) { dataGridView1.DataSource = lines.ToList(); return; }
            var y1 = lines.Where(s => s.Y1 == Convert.ToDouble(textBox6.Text)).ToList();
            dataGridView1.DataSource = y1;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                dataGridView1.DataSource = lines.ToList();
                return;
            }
            var x2 = lines.Where(s => s.X2 == Convert.ToDouble(textBox7.Text)).ToList();
            dataGridView1.DataSource = x2;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                dataGridView1.DataSource = lines.ToList();
                return;
            }
            var y2 = lines.Where(s => s.Y2 == Convert.ToDouble(textBox8.Text)).ToList();
            dataGridView1.DataSource = y2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sortup = lines.OrderBy(s => s.X1).ToList();
            dataGridView1.DataSource = sortup;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sortdown = lines.OrderByDescending(s => s.X1).ToList();
            dataGridView1.DataSource = sortdown;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sortup = lines.OrderBy(s => s.Y1).ToList();
            dataGridView1.DataSource = sortup;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sortdown = lines.OrderByDescending(s => s.Y1).ToList();
            dataGridView1.DataSource = sortdown;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sortup = lines.OrderBy(s => s.X2).ToList();
            dataGridView1.DataSource = sortup;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sortdown = lines.OrderByDescending(s => s.X2).ToList();
            dataGridView1.DataSource = sortdown;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sortup = lines.OrderBy(s => s.Y2).ToList();
            dataGridView1.DataSource = sortup;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var sortdown = lines.OrderByDescending(s => s.Y2).ToList();
            dataGridView1.DataSource = sortdown;
        }
    }
}
