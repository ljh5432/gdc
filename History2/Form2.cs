using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History2
{
    public partial class Form2 : Form
    {
        string king;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string king)
        {
            InitializeComponent();
            this.king = king;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "왕이름~~";//"태조"부분에 Form1에서 넘어온 데이터를 넘겨준다.
        }

        private void button_incident_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button_character_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button_cultural_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
