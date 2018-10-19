using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TaylorBailey
{
    public enum Materials
    {
        Select = 0,
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    public class Desk
    {
        private int width, depth, drawer, days;
        private Materials materials;

        public Desk()
        {
            days = 0;
            width = 0;
            depth = 0;
            drawer = 0;
            materials = Materials.Select;
        }


        public void setDrawers(int drawers)
        {
            this.drawer = drawers;
        }

        public void setDays(int days)
        {
            this.days = days;
        } 

        public void setMaterial(Materials material)
        {
            this.materials = material;
        }

        public void setWidth(int width)
        {
            if (width > 0 && width < 100)
            {
                this.width = width;
            }
        }

        public void setDepth(int depth)
        {
            if (depth > 0 && depth < 25)
            {
                this.depth = depth;
            }
        }

        public int getDepth()
        {
            return this.depth;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getDays()
        {
            return this.days;
        }
}
}
