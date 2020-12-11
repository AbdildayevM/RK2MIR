using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK2MIR.Models
{
    public class Employee//-Order(1-m)
    {
        public Employee(int ID, string LastName, string FirstName, long PhoneNumber, string Password, double RateOutOfTen)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.PhoneNumber = PhoneNumber;
            this.Password = Password;
            this.RateOutOfTen = RateOutOfTen;
        }

        public Employee()
        {
        }

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }
        public double RateOutOfTen { get; set; }


        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }

        public void setLastName(string last)
        {
            this.LastName = last;
        }
        public string getLastName()
        {
            return this.LastName;
        }

        public void setFirstName(string first)
        {
            this.FirstName = first;
        }
        public string getFirstName()
        {
            return this.FirstName;
        }

        public void setPhoneNumber(long phone)
        {
            this.PhoneNumber = phone;
        }
        public long getPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void setPassword(string password)
        {
            this.Password = password;
        }
        public string getPassword()
        {
            return this.Password;
        }

        public void setRateOutOfTen(double rate)
        {
            this.RateOutOfTen = rate;
        }
        public double getRateOutOfTen()
        {
            return this.RateOutOfTen;
        }
    }
}
