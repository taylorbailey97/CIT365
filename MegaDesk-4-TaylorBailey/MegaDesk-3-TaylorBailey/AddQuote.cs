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
        private const int MAX_WIDTH = 96;
        private const int MIN_WIDTH = 24;
        private const int MAX_DEPTH = 48;
        private const int MIN_DEPTH = 12;
        private const int MAX_DRAWERS = 7;

        public AddQuote(Form mainMenu)
        {
            main = mainMenu;
            desk = new Desk();
            backedOut = false;
            InitializeComponent();
            materialBox.DataSource = Enum.GetValues(typeof(Materials));
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
            #region ValidationForAddQuote

            if (widthUpDown.Value < MIN_WIDTH || widthUpDown.Value > MAX_WIDTH)
            {
                MessageBox.Show("Please enter a value for desk width between 24 and 96");
                return;
            }
            else if (depthUpDown.Value < MIN_DEPTH || depthUpDown.Value > MAX_DEPTH)
            {
                MessageBox.Show("Please enter a value for desk depth between 12 and 48");
                return;
            }
            else if ((int) drawers.Value > MAX_DRAWERS)
            {
                MessageBox.Show("Please select a number of drawers between 0 and 7");
            }
            else if (materialBox.SelectedValue.ToString() == "Select")
            {
                MessageBox.Show("Please select a material");
            }
            else if (!(rush3.Checked || rush5.Checked || rush7.Checked || noRush.Checked))
            {
                MessageBox.Show("Please select rush preferences");
            }
            else if (custName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a name for the customer");
            }
            #endregion
            else
            {
                if (desk != null)
                {
                    if (rush7.Checked)
                    {
                        desk.setDays(7);
                    }
                    else if (rush5.Checked)
                    {
                        desk.setDays(5);
                    }
                    else if (rush3.Checked)
                    {
                        desk.setDays(3);
                    }

                    desk.setDrawers((int)drawers.Value);
                    desk.setDepth((int)depthUpDown.Value);
                    desk.setWidth((int)widthUpDown.Value);
                    desk.setMaterial((Materials)materialBox.SelectedValue);

                    DeskQuote newQuote = new DeskQuote(this.desk, custName.Text);
                    newQuote.saveQuote();
                    DisplayQuote newDisplayQuote = new DisplayQuote(this, main, newQuote);
                    newDisplayQuote.Tag = this;
                    newDisplayQuote.Show(this);
                    Hide();
                }
            }

        }

    }
}
