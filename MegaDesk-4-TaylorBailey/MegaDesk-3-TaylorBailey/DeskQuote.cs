using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TaylorBailey
{
    public class DeskQuote
    {
        private Desk desk;
        private double cost, addCost, total;
        private DateTime created;

        public DeskQuote()
        {
            cost = 0;
            addCost = 0;
        }

        public DeskQuote(Desk desk)
        {
            cost = 0;
            addCost = 0;
            this.desk = desk;
            created = DateTime.Now;
        }

        public Desk getDesk()
        {
            return this.desk;
        }

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

        public void setDesk(Desk desk)
        {
            if (desk != null)
            {
                this.desk = desk;
            }
        }

        public int calculateArea()
        {
            int area = (int)(this.desk.getDepth() * this.desk.getWidth());
            return area;
        }

        public void calculateCost()
        {
            this.cost = calculateArea();
        }

        public void calculateAddedCost(bool rushed, int days)
        {
            if (rushed)
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
        }

        public void calculateTotal()
        {
            this.total = this.addCost + this.cost;
        }

    }
}
