﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class Seat : IInventory
    {
        private DateTime _buyDate;
        public DateTime buyDate
        {
            get
            {
                return _buyDate;
            }

            set
            {
                this._buyDate = value;
            }
        }

        private string _iID;
        public string iID
        {
            get
            {
                return _iID;
            }

            set
            {
                this._iID = value;
            }
        }

        private Point _largeMeter;
        public Point largeMeter
        {
            get
            {
                return _largeMeter;
            }

            set
            {                
                value.X = Math.Ceiling(value.X);
                value.Y = Math.Ceiling(value.Y);
                this._largeMeter = value;
            }
        }

        private int _warrant;
        public int warrant
        {
            get
            {
                return _warrant;
            }

            set
            {
                this._warrant = value;
            }
        }
    }
}
