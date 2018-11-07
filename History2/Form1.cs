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
    public partial class Form1 : Form
    {
        ListViewItem[] list;
        public Form1()
        {
            InitializeComponent();
        }
        //폼이 불러와 질때 실행한다.
        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] index = {
                { "1대", "태조", "1392 - 1398" },
                { "2대", "정종", "1398 - 1400" },
                { "3대", "태종", "1400 - 1418" },
                { "4대", "세종", "1418- 1450" },
                { "5대", "문종", "1450 - 1452" }
            };
            list = new ListViewItem[index.GetLength(0)];
            for(int i=0; i < index.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(index[i,0]);
                item.Checked = true;
                item.SubItems.Add(index[i, 1]);
                item.SubItems.Add(index[i, 2]);
                list[i] = item;
            }

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(List_search(textBox_search.Text));
        }
        private ListViewItem[] List_search(string text)
        {
            ListViewItem[] temp = new ListViewItem[list.Length];
            ListViewItem[] search_list;
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (list[i].SubItems[j].Text.Contains(text))
                    {
                        temp[count++] = list[i];
                        break;
                    }
                }
                //if (list[i].SubItems[1].Text.Contains(text))
                //{
                //    temp[count++] = list[i];
                //}
            }
            search_list = new ListViewItem[count];
            for(int a = 0; a < count; a++)
            {
                search_list[a] = temp[a];
            }
            return search_list;
        }

        //private void button_select_Click(object sender, EventArgs e)
        //{
        //    this.Visible = false;
        //    Form2 form2 = new Form2();
        //    form2.Show();
        //}

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
