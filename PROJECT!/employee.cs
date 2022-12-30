using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_
{
    abstract class employee //abstract class
    {
        public string Name { get;  set; }
        public string SurName { get;  set; }

        private string pesel;
        public string PeselNumber { get { return pesel; } set { pesel = value; } }

        private string userName;
        public string UserName { get { return userName; }  set { userName = value; } }

        private string password;
        public string Password { get { return password; } set { password = value; } }

        public List<DateTime> CallOfDuty = new List<DateTime> { };
        public employee(string name,string surname,string pesel,string username,string password)
        {
            this.Name = name;
            this.SurName = surname;
            this.PeselNumber = pesel;
            this.UserName = username;
            this.Password = password;
        }
        public virtual void getstandartdlist(employee x , Hospital host) //overload to getall list doctorstan
        {
            switch (Convert.ToString(x.GetType()))
            {
                case "PROJECT_.Doctor":
                    Console.WriteLine(x.Name + x.SurName + " Doctor");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                    break;
                case "PROJECT_.Nurse":
                    Console.WriteLine(x.Name + x.SurName + " Nurse");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                    break;
                case "PROJECT_.Cardiologist":
                    Console.WriteLine(x.Name + x.SurName + " Doctor Specialiation :Cardiologist");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                    break;
                case "PROJECT_.laryngologist":
                    Console.WriteLine(x.Name + x.SurName + " Doctor Specialiation:laryngologist");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                    break;
                case "PROJECT_.neurologist":
                    Console.WriteLine(x.Name + x.SurName + " Doctor Specialiation neurologist");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                    break;
                case "PROJECT_.urologist":
                    Console.WriteLine(x.Name + x.SurName + " Doctor Specialiation :urologist");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                    break;
                default:
                    break;
            }
        }
    }
}
