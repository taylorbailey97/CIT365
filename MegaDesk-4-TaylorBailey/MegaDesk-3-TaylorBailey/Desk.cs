using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TaylorBailey
{
    public class Desk
    {
        private int width, depth, height, drawer, material;

        public Desk()
        {
            width = 0;
            depth = 0;
            height = 0;
            drawer = 0;
            material = 0;
        }

        public enum Materials {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        };

        public void setDrawers(int drawers)
        {
            this.drawer = drawers;
        }

        public void setMaterial(int material)
        {
            this.material = material;
        }

        public void setWidth(int width)
        {
            if (width > 0 && width < 100)
            {
                this.width = width;
            }
        }

        public void setHeight(int height)
        {
            if (height > 0 && height < 50)
            {
                this.height = height;
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

        public int getHeight()
        {
            return this.height;
        }
}
}
