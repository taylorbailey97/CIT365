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

namespace MegaDesk_3_TaylorBailey
{
    public partial class SearchQuotes : Form
    {
        private Form main;
        private Boolean backedOut;
        public SearchQuotes(Form mainMenu)
        {
            main = mainMenu;
            backedOut = false;
            InitializeComponent();
            materialSearch.DataSource = Enum.GetValues(typeof(Materials));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!backedOut)
            {
                main.Show();
            }
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            drawLayout();
        }

        private void drawLayout()
        {
            quoteList.Columns.Add("Name: ", 100, HorizontalAlignment.Center);
            quoteList.Columns.Add("Created:", 100, HorizontalAlignment.Center);
            quoteList.Columns.Add("Width:", 100, HorizontalAlignment.Center);
            quoteList.Columns.Add("Depth:", 100, HorizontalAlignment.Center);
            quoteList.Columns.Add("Material:", 150, HorizontalAlignment.Center);
            quoteList.Columns.Add("Drawers:", 100, HorizontalAlignment.Center);
            quoteList.Columns.Add("Total:", 100, HorizontalAlignment.Center);
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            main.Show();
            backedOut = true;
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            quoteList.Clear();
            drawLayout();
            using (StreamReader sr =
                new StreamReader(@"C:\Users\taylo\source\repos\MegaDesk-4-TaylorBailey\quotes.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] result = sr.ReadLine().Split(',');
                    if (int.Parse(result[4]) == (int)materialSearch.SelectedItem)
                    {
                        // ListViewItem item =
                        quoteList.Items.Add(new ListViewItem(new[]{ result[0], result[1], result[2], result[3], result[4], result[5], result[6]}));
                    }
                }
                sr.Close();
            }
        }
    }
}

