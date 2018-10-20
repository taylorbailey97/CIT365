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
    public partial class ViewAllQuotes : Form
    {
        Form main;
        Boolean backedOut;
        public ViewAllQuotes(Form mainMenu)
        {
            main = mainMenu;
            backedOut = false;
            InitializeComponent();
            drawLayout();
            loadQuotes();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!backedOut)
            {
                main.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            main.Show();
            backedOut = true;
            Close();
        }
        private void drawLayout()
        {
            allQuotesList.Columns.Add("Name: ", 100, HorizontalAlignment.Center);
            allQuotesList.Columns.Add("Created:", 100, HorizontalAlignment.Center);
            allQuotesList.Columns.Add("Width:", 100, HorizontalAlignment.Center);
            allQuotesList.Columns.Add("Depth:", 100, HorizontalAlignment.Center);
            allQuotesList.Columns.Add("Material:", 150, HorizontalAlignment.Center);
            allQuotesList.Columns.Add("Drawers:", 100, HorizontalAlignment.Center);
            allQuotesList.Columns.Add("Total:", 100, HorizontalAlignment.Center);
        }

        private void loadQuotes()
        {         
            using (StreamReader sr =
                new StreamReader(@"C:\Users\taylo\source\repos\MegaDesk-4-TaylorBailey\quotes.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] result = sr.ReadLine().Split(',');                                            
                    allQuotesList.Items.Add(new ListViewItem(new[] { result[0], result[1], result[2], result[3], result[4], result[5], result[6] }));                    
                }
                sr.Close();
            }
        }
    }
}
