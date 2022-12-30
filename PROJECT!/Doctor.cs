using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_
{
    abstract class Doctor: employee //second abstract class
    {
        private string PwzNumber { get; set; }
        internal Doctor(string name,string surname,string pesel,string usern,string password,string pwz ):base(name,surname,pesel,usern,password)
        {
            this.PwzNumber = pwz;
        }
        public override void getstandartdlist(employee x, Hospital host)
        {
            Console.WriteLine("Welcome Doctor here is the List:");
            foreach ( employee emp in host.Hospitalemployee)
                base.getstandartdlist(emp, host);
        }
    }
}
