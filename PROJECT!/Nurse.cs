using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_
{
    class Nurse : employee
    {
        internal Nurse(string name, string surname, string pesel, string usern, string password) : base(name, surname, pesel, usern, password)
        {
        }
        public override void getstandartdlist(employee x, Hospital host)
        {
            Console.WriteLine("Welcome Nurse Here is The list");
            foreach (employee emp in host.Hospitalemployee)
                base.getstandartdlist(emp, host);

        }
    }
}
