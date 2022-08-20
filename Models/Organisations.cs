using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19078303Homework4.Models
{
    public class Organisations : Members
    {
        private string _Type;
        private bool _Status;

        public Organisations(string fullname, int numbers, string date, double amount, bool status) : base(fullname, numbers, date, amount)
        {
            _Status = status;
        }

        
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public override string Decription()
        {
            return Status ?  base.Decription() + "They are Active members who donate and support our Organisation " : " They are not one of our members" ;
        }

        public override string participation()
        {
            return "They are also our members";
        }
    }
}