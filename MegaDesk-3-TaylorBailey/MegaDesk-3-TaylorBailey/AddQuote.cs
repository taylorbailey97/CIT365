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
    public partial class AddQuote : Form
    {
        Desk desk;
        Boolean backedOut;
        Form main;
        const int MAX_WIDTH = 200;
        const int MAX_HEIGHT = 50;
        const int MAX_DEPTH = 50;
        public AddQuote(Form mainMenu)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            main.Show();
            backedOut = true;
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (heightUpDown.Value < 10 || heightUpDown.Value > MAX_HEIGHT)
            {
                MessageBox.Show("Please enter a value for desk height between 10 and 50");
                return;
            }
            else if (widthUpDown.Value < 1 || widthUpDown.Value > MAX_WIDTH)
            {
                MessageBox.Show("Please enter a value for desk width between 1 and 200");
                return;
            }
            else if (depthUpDown.Value < 1 || depthUpDown.Value > 50)
            {
                MessageBox.Show("Please enter a value for desk depth between 1 and 50");
                return;
            }
            else if (selectDrawers.Text == string.Empty)
            {
                MessageBox.Show("Please select how many drawers you would like");
                return;
            }
        }
    }
}
