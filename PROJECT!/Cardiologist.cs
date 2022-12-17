using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_
{
    class Cardiologist:Doctor
    {
        public Cardiologist(string name, string surname, string pesel, string usern, string password, string pwz) : base(name, surname, pesel, usern, password,pwz)
        {
        }
    }
}
