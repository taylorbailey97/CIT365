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
            materials = Materials.Select;
        }

        #region DeskSetters
                
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
            this.width = width;
        }

        public void setDepth(int depth)
        {
            this.depth = depth;
        }

        #endregion

        #region DeskGetters
        
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

        public int getDrawers()
        {
            return this.drawer;
        }

        public Materials GetMaterials()
        {
            return this.materials;
        }
        #endregion
    }
}
