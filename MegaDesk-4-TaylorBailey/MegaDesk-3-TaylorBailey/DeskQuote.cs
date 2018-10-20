using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TaylorBailey
{
    public class DeskQuote
    {
        private string custName;
        private Desk desk;
        private static int costPerSqIn = 1;
        private double cost, addCost, total;
        private DateTime created = DateTime.Now;

        public DeskQuote()
        {

        }

        public DeskQuote(Desk desk, string name)
        {
            this.desk = desk;
            this.custName = name;
            calculateCost();
            calculateAddedCost(desk.getDays());
            calculateTotal();
        }

        public Desk getDesk()
        {
            return this.desk;
        }

        #region DeskQuoteGetters     
        public double getCost()
        {
            return this.cost;
        }

        public double getAddCost()
        {
            return this.addCost;
        }

        public double getTotal()
        {
            return this.total;
        }

        public string getName()
        {
            return this.custName;
        }

        public DateTime getDate()
        {
            return this.created;
        }

        #endregion

        #region DeskQuoteSetters

        public void setDesk(Desk desk)
        {
            if (desk != null)
            {
                this.desk = desk;
            }
        }

        #endregion

        #region DeskQuoteCalculations

        public int calculateArea()
        {
            int area = (int)(this.desk.getDepth() * this.desk.getWidth());
            return area;
        }

        public void calculateCost()
        {
            this.cost = calculateArea() * costPerSqIn;
        }

        public void calculateAddedCost(int days)
        {
            if (calculateArea() < 1000)
            {
                switch (days)
                {
                    case 3:
                        this.addCost = 60;
                        break;
                    case 5:
                        this.addCost = 40;
                        break;
                    case 7:
                        this.addCost = 30;
                        break;
                }
            }
            else if (calculateArea() > 999 && calculateArea() < 2001)
            {
                switch (days)
                {
                    case 3:
                        this.addCost = 70;
                        break;
                    case 5:
                        this.addCost = 50;
                        break;
                    case 7:
                        this.addCost = 35;
                        break;
                }
            }
            else if (calculateArea() > 2000)
            {
                switch (days)
                {
                    case 3:
                        this.addCost = 80;
                        break;
                    case 5:
                        this.addCost = 60;
                        break;
                    case 7:
                        this.addCost = 40;
                        break;
                }
            }
        }

        public void calculateTotal()
        {
            this.total = this.addCost + this.cost;
        }
        #endregion

        #region FileStream

        public void saveQuote()
        {
            string fileName = @"C:\Users\taylo\source\repos\MegaDesk-4-TaylorBailey\quotes.txt";
            if (!File.Exists(fileName))
            {
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(custName + "," + created + "," + desk.getWidth() + "," + desk.getDepth() + "," + (int)desk.GetMaterials() +  "," + desk.getDrawers() + "," + total);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(custName + "," + created + "," + desk.getWidth() + "," + desk.getDepth() + "," +
                                 (int) desk.GetMaterials() + "," + desk.getDrawers() + "," + total);
                    sw.Close();
                }
            }
            
        }

        #endregion
    }
}
