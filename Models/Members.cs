using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19078303Homework4.Models
{
    public abstract class Members
    {
        private string _FullName;
        private int _Numbers;
        private string _Date;
        private double _Amount;

        public Members(string fullname, int numbers, string date, double amount)
        {
            _FullName = fullname;
            _Numbers = numbers;
            _Date = date;
            _Amount = amount;
        }

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public int Numbers
        {
            get { return _Numbers; }
            set { _Numbers = value; }
        }
        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public virtual string Decription()
        {
            return FullName + " donated R" + Amount.ToString() + " towards our Organisation ";

        }

        public abstract string participation();
    }
}