using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TaylorBailey
{
    public partial class SearchQuotes : Form
    {
        Form main;
        Boolean backedOut;
        public SearchQuotes(Form mainMenu)
        {
            main = mainMenu;
            backedOut = false;
            InitializeComponent();
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
    }
}
