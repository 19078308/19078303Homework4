using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19078303Homework4.Models
{
    public class Individuals : Members
    {
        private bool _Volunteer;
        public Individuals(string fullname, string numbers, string date, double amount, bool volunteer) : base(fullname, numbers, date, amount)
        {
            _Volunteer = volunteer;
        }
        public bool Volunteer
        {
            get { return _Volunteer; }
            set { _Volunteer = value; }
        }
        public override string Decription()
        {
            return Volunteer ? base.Decription() + " And they also agreed to volunteer. " : " but they do not offer volunteering";
        }

        public override string participation()
        {
            return "Yes they participate in our programs";
        }
    }
}