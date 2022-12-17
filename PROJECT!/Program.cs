using System;
using System.Collections.Generic;
namespace PROJECT_
{
    class Program //specialation needded for doctors delete the normal doctor
    {
        static void Main(string[] args) //Completed But never tested
        {
            var HospitalA = new Hospital(); //Our hospital       
            administrator.Addadmin(HospitalA, "zeki", "Tuncdoken", "1", "1", "1");
            administrator.Addurologist(HospitalA, "metin", "ali", "2", "2", "2", "YYY");
            administrator.Addurologist(HospitalA, "s", "s", "3", "3", "3", "s");
            administrator.AddNurse(HospitalA, "ali", "kerem", "4", "4", "4");
            string inputnumber;
            string name, surname, pesel, username, password,pwz;

            employee CurrentUser = new employee(null, null, null, null, null);
            //login page
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Username:");
                    string user = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string pass = Console.ReadLine();
                    
                    foreach (employee logincheck in HospitalA.Hospitalemployee)
                    {
                        if (logincheck.UserName == user && logincheck.Password == pass)
                        {
                            CurrentUser = logincheck;
                            break;
                        }
                    }
                    if (CurrentUser == null)
                        Console.WriteLine("Employe not found please try again");
                    else
                        break;
                }
                if (CurrentUser is Doctor || CurrentUser is Nurse) //doctor and nurse
                {
                    Console.WriteLine("Welcome! "+CurrentUser.Name);
                    while (true)
                    {
                        Console.WriteLine("What do you want?" +
                            "\n[1]please show the all nurses&doctors in our hospital." +
                            "\n[2] Loggin out.");
                        inputnumber = Console.ReadLine();
                        if (inputnumber == "1")
                            CurrentUser.getstandartdlist(CurrentUser, HospitalA);
                        else if (inputnumber == "2")
                        {
                            CurrentUser = null;
                            break;
                        }
                        else
                            Console.WriteLine("Incorrect input try again");
                    }
                }
                else if(CurrentUser is administrator)
                {
                    Console.WriteLine("Welcome! "+ CurrentUser.Name);
                    while (true)
                    {
                        Console.WriteLine("What do you want?\n" +
                            "[1]Please show all staf at hospital" +
                            "\n[2] Add new staff\n" +
                            "[3]edit data of staff\n" +
                            "[4] Loggin out");
                        inputnumber = Console.ReadLine();
                        if (inputnumber == "1") //get list of staffs
                            CurrentUser.getstandartdlist(CurrentUser, HospitalA);
                        else if (inputnumber == "2") //add staff
                        {
                            Console.WriteLine("What staff do you want to add\n" +
                                "[1] Nurse\n" +
                                "[2] Laryngologist\n" +
                                "[3] Cardiologist\n" +
                                "[4] Urologist\n" +
                                "[5] Neurologist\n" +
                                "[6] ADMİN\n");
                            string Addnumber = Console.ReadLine();
                            switch (Addnumber)
                            {
                                case "1":
                                    Console.WriteLine("name:");
                                     name = Console.ReadLine();
                                    Console.WriteLine("Surname:");
                                     surname = Console.ReadLine();
                                    Console.WriteLine("Pesel");
                                     pesel = Console.ReadLine();
                                    Console.WriteLine("Usename:");
                                     username = Console.ReadLine();
                                    Console.WriteLine("password:");
                                     password = Console.ReadLine();
                                    administrator.AddNurse(HospitalA,name,surname,pesel,username,password);
                                    break;
                                case "2":
                                    Console.WriteLine("name:");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Surname:");
                                    surname = Console.ReadLine();
                                    Console.WriteLine("Pesel");
                                    pesel = Console.ReadLine();
                                    Console.WriteLine("Usename:");
                                    username = Console.ReadLine();
                                    Console.WriteLine("password:");
                                    password = Console.ReadLine();
                                    Console.WriteLine("pwz:");
                                    pwz = Console.ReadLine();
                                    administrator.Addlaryngologist(HospitalA, name, surname, pesel, username, password, pwz);
                                    break;
                                case "3":
                                    Console.WriteLine("name:");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Surname:");
                                    surname = Console.ReadLine();
                                    Console.WriteLine("Pesel");
                                    pesel = Console.ReadLine();
                                    Console.WriteLine("Usename:");
                                    username = Console.ReadLine();
                                    Console.WriteLine("password:");
                                    password = Console.ReadLine();
                                    Console.WriteLine("pwz:");
                                    pwz = Console.ReadLine();
                                    administrator.AddCardiologist(HospitalA, name, surname, pesel, username, password,pwz);
                                    break;
                                case "4":
                                    Console.WriteLine("name:");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Surname:");
                                    surname = Console.ReadLine();
                                    Console.WriteLine("Pesel");
                                    pesel = Console.ReadLine();
                                    Console.WriteLine("Usename:");
                                    username = Console.ReadLine();
                                    Console.WriteLine("password:");
                                    password = Console.ReadLine();
                                    Console.WriteLine("pwz:");
                                    pwz = Console.ReadLine();
                                    administrator.Addurologist(HospitalA, name, surname, pesel, username, password, pwz);
                                    break;
                                case "5":
                                    Console.WriteLine("name:");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Surname:");
                                    surname = Console.ReadLine();
                                    Console.WriteLine("Pesel");
                                    pesel = Console.ReadLine();
                                    Console.WriteLine("Usename:");
                                    username = Console.ReadLine();
                                    Console.WriteLine("password:");
                                    password = Console.ReadLine();
                                    Console.WriteLine("pwz:");
                                    pwz = Console.ReadLine();
                                    administrator.Addneurologist(HospitalA, name, surname, pesel, username, password, pwz);
                                    break;
                                case "6":
                                    Console.WriteLine("name:");
                                     name = Console.ReadLine();
                                    Console.WriteLine("Surname:");
                                     surname = Console.ReadLine();
                                    Console.WriteLine("Pesel");
                                     pesel = Console.ReadLine();
                                    Console.WriteLine("Usename:");
                                     username = Console.ReadLine();
                                    Console.WriteLine("password:");
                                     password = Console.ReadLine();
                                    administrator.Addadmin(HospitalA, name, surname, pesel, username, password);
                                    break;
                                default:
                                    Console.WriteLine("Wrong İnput.");
                                    break;
                            }
                        }
                        else if (inputnumber == "3")
                        {
                            Console.WriteLine("Which staff you want to edit Enter PESEL number:");
                            string Editperson = Console.ReadLine();
                            foreach (employee staff in HospitalA.Hospitalemployee)
                            {
                                if (Editperson == staff.PeselNumber)
                                {
                                    Console.WriteLine("Staff:" + staff.Name + staff.SurName);
                                    Console.WriteLine("what do you want to change this staff\n" +
                                        "[1]Name\n" +
                                        "[2]SurName\n" +
                                        "[3]UserName\n" +
                                        "[4]Password\n" +
                                        "[5]Add date to Duty\n" +
                                        "[6]Add remove date from Duty\n");
                                    string changinproperties = Console.ReadLine();
                                    int year, month, day;
                                    switch (changinproperties)
                                    {
                                        case "1":
                                            Console.WriteLine("please input new name:");
                                            staff.Name = Console.ReadLine();
                                            break;
                                        case "2":
                                            Console.WriteLine("please input new surname:");
                                            staff.SurName = Console.ReadLine();
                                            break;
                                        case "3":
                                            Console.WriteLine("please input new Username");
                                            staff.UserName = Console.ReadLine();
                                            break;
                                        case "4":
                                            Console.WriteLine("please input new Password");
                                            staff.Password = Console.ReadLine();
                                            break;
                                        case "5":
                                            Console.WriteLine("please input year");
                                            year = int.Parse(Console.ReadLine());
                                            Console.WriteLine("please input month");
                                            month = int.Parse(Console.ReadLine());
                                            Console.WriteLine("please input day");
                                            day = int.Parse(Console.ReadLine());
                                            administrator.AddDateToduty(year, month, day, HospitalA, staff);
                                            break;
                                        case "6":
                                            Console.WriteLine("please input year");
                                            year = int.Parse(Console.ReadLine());
                                            Console.WriteLine("please input month");
                                            month = int.Parse(Console.ReadLine());
                                            Console.WriteLine("please input day");
                                            day = int.Parse(Console.ReadLine());
                                            administrator.RemoveDateDuty(year, month, day, HospitalA, staff);
                                            break;
                                        default:
                                            Console.WriteLine("wrong input");
                                            break;
                                    }
                                }
                            }
                        }
                        else
                            break;
                    }
                }
            }
        }
    }
}
