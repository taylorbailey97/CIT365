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
            dateLabel.Text = quote.getDate().ToString("D");
            nameLabel.Text = quote.getName();            
            widthLabel.Text = quote.getDesk().getWidth().ToString();            
            depthLabel.Text = quote.getDesk().getDepth().ToString();
            drawerLabel.Text = quote.getDesk().getDrawers().ToString();
            switch ((int)quote.getDesk().GetMaterials())
            {
                case 200:
                    materialsLabel.Text = "Oak";
                    break;
                case 100:
                    materialsLabel.Text = "Laminate";
                    break;
                case 50:
                    materialsLabel.Text = "Pine";
                    break;
                case 300:
                    materialsLabel.Text = "Rosewood";
                    break;
                case 125:
                    materialsLabel.Text = "Veneer";
                    break;
                default:
                    break;
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            addForm.Show();
            backedOut = true;
            this.Close();
        }
    }
}
