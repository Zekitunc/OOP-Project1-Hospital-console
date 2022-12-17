using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_
{
    class administrator: employee
    {
        private administrator(string name, string surname, string pesel, string usern, string password) : base(name, surname, pesel, usern, password)
        {
        }
        public override void getstandartdlist(employee x, Hospital host)
        {
            Console.WriteLine("Welcome Admin Here's the list:");
            foreach (employee emp in host.Hospitalemployee)
            {
                base.getstandartdlist(emp, host);
                if (Convert.ToString(emp.GetType()) == "PROJECT_.administrator")
                {
                    Console.WriteLine(emp.Name + emp.SurName + " ADMİN");
                    foreach (DateTime duty in host.Calendar[x])
                        Console.WriteLine(duty);
                }
            }
        }
        internal static void Addadmin(Hospital host,string name,string surname,string pesel,string username,string password)
        {
            administrator emp = new administrator(name, surname, pesel, username, password);
            host.Hospitalemployee.Add(emp);
            host.Calendar.Add(emp, emp.CallOfDuty);
        }
        internal static void AddNurse (Hospital host,string name,string surname,string pesel,string username,string password)
        {
            Nurse emp = new Nurse(name, surname, pesel, username, password);
            host.Hospitalemployee.Add(emp);
            host.Calendar.Add(emp, emp.CallOfDuty);

        }
        internal static void AddCardiologist(Hospital host, string name, string surname, string pesel, string username, string password, string pwz)
        {
            Cardiologist dct = new Cardiologist(name, surname, pesel, username, password, pwz);
            host.Hospitalemployee.Add(dct);
            host.Calendar.Add(dct, dct.CallOfDuty);
        }
        internal static void Addurologist(Hospital host, string name, string surname, string pesel, string username, string password, string pwz)
        {
            urologist dct = new urologist(name, surname, pesel, username, password, pwz);
            host.Hospitalemployee.Add(dct);
            host.Calendar.Add(dct, dct.CallOfDuty);
        }
        internal static void Addlaryngologist(Hospital host, string name, string surname, string pesel, string username, string password, string pwz)
        {
            laryngologist dct = new laryngologist(name, surname, pesel, username, password, pwz);
            host.Hospitalemployee.Add(dct);
            host.Calendar.Add(dct, dct.CallOfDuty);

        }
        internal static void Addneurologist(Hospital host, string name, string surname, string pesel, string username, string password, string pwz)
        {
            neurologist dct = new neurologist(name, surname, pesel, username, password, pwz);
            host.Hospitalemployee.Add(dct);
            host.Calendar.Add(dct, dct.CallOfDuty);
        }
        internal static void AddDateToduty(int year,int month,int day,Hospital host,employee staff)
        {
            DateTime date = new DateTime(year, month, day);
            bool empty;
            switch(Convert.ToString(staff.GetType()))
            {
                case "PROJECT_.Doctor":
                    staff.CallOfDuty.Add(date);
                    break;
                case "PROJECT_.Nurse":
                    staff.CallOfDuty.Add(date);
                    break;
                case "PROJECT_.urologist":
                    empty = checkcalendar(host, date, "PROJECT_.urologist");
                    if (empty == true)
                        staff.CallOfDuty.Add(date);
                    else if (empty == false)
                        Console.WriteLine("This day we already have urologist");
                    break;
                case "PROJECT_.Cardiologist":
                    empty = checkcalendar(host, date, "PROJECT_.Cardiologist");
                    if (empty == true)
                        staff.CallOfDuty.Add(date);
                    else
                        Console.WriteLine("This day we already have Cardiologist");
                    break;
                case "PROJECT_.laryngologist":
                    empty = checkcalendar(host, date, "PROJECT_.laryngologist");
                    if (empty == true)
                        staff.CallOfDuty.Add(date);
                    else
                        Console.WriteLine("This day we already have laryngologist");
                    break;
                case "PROJECT_.neurologist":
                    empty = checkcalendar(host, date, "PROJECT_.neurologist");
                    if (empty == true)
                        staff.CallOfDuty.Add(date);
                    else
                        Console.WriteLine("This day we alreadu have neurologist");
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }
        internal static void RemoveDateDuty(int year,int month,int day,Hospital host,employee staff)
        {
            bool check = false;
            DateTime removedate = new DateTime(year, month, day);
            for(int i =0;i<staff.CallOfDuty.Count;i++)
                if (staff.CallOfDuty[i] == removedate)
                {
                    staff.CallOfDuty.RemoveAt(i);
                    check = true;
                }
            if (check==false)
                Console.WriteLine("This staff haven't duty at input date");
        }
        internal static bool checkcalendar(Hospital host, DateTime date,string typeofemployee)
        {
            bool empty = true;
            foreach (employee checkemploye in host.Hospitalemployee)
            {
                if (Convert.ToString(checkemploye.GetType()) == typeofemployee)
                {
                    foreach (DateTime checkdate in host.Calendar[checkemploye])
                        if (date == checkdate)
                            empty = false;
                }
            }
            return empty;
        }
    }
}
