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
    public partial class DisplayQuote : Form
    {
        private bool backedOut;
        private Form addForm;
        private Form main;
        private DeskQuote quote;

        public DisplayQuote(Form addQuoteForm, Form main, DeskQuote quote1)
        {
            addForm = addQuoteForm;
            this.main = main;
            this.quote = quote1;
            backedOut = false;
            InitializeComponent();
            formStart();
        }

        private void formStart()
        {
            widthLabel.Text = quote.getDesk().getWidth().ToString();
            updateCosts();
        }

        public void updateCosts()
        {
            costLabel.Text = quote.getCost().ToString();
            addedCostLabel.Text = quote.getAddCost().ToString();
            totalLabel.Text = quote.getTotal().ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!backedOut)
            {
                addForm.Show();
            }
        }
    }
}
