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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                ListViewItem item = new ListViewItem("사건"+(i+1));
                item.Checked = true;
                listView1.Items.Add(item);
            }

            richTextBox1.Text = "관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n관련 내용 설명\n";

            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !(groupBox1.Visible);
            listView1.Visible = !(listView1.Visible);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = !(groupBox1.Visible);
            listView1.Visible = !(listView1.Visible);
        }
    }
}
