using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace MidTermProject
{
    class Person
    {
        public Person()
        {
            fName = mName = lName = streetOne = streetTwo = city = stateCode = zipCode = phoneNum = emailAddress = feedback = "";
        }
        public Person(string _fName, string _mName, string _lName, string _streetOne, string _streetTwo, string _city, string _stateCode, string _zipCode, string _phoneNum, string _emailAddress)
        {
            FName = _fName;
            MName = _mName;
            LName = _lName;
            StreetOne = _streetOne;
            StreetTwo = _streetTwo;
            City = _city;
            StateCode = _stateCode;
            ZipCode = _zipCode;
            PhoneNum = _phoneNum;
            EmailAddress = _emailAddress;
            Feedback = "";
        }
        public Person(Person p)
        {
            FName = p.FName;
            MName = p.MName;
            LName = p.LName;
            StreetOne = p.StreetOne;
            StreetTwo = p.StreetTwo;
            City = p.City;
            StateCode = p.StateCode;
            ZipCode = p.ZipCode;
            PhoneNum = p.PhoneNum;
            EmailAddress = p.EmailAddress;
            Feedback = "";
        }
        //Would in real application add constructors and add methods to get things like statecode, phone num in different formats or phone/zipcode in num data type or to get full name
        private string fName, mName, lName, streetOne, streetTwo, city, stateCode, zipCode, phoneNum, emailAddress, feedback;//Since I already made the gets and sets this is literally the only line of code that changes between parts 2 & 3 
        //Already know the differences between public and private from java experience
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string MName
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public string StreetOne
        {
            get
            {
                return streetOne;
            }
            set
            {
                streetOne = value;
            }
        }
        public string StreetTwo
        {
            get
            {
                return streetTwo;
            }
            set
            {
                streetTwo = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string StateCode
        {
            get
            {
                return stateCode;
            }
            set
            {
                //Conditional sets all copy paste from do while loops in previous assignment now while condition is while value is ""
                if (BasicTools.isValidStateCode(value))
                    stateCode = value.ToUpper();
                else
                {
                    stateCode = "";
                    feedback += "\n Error: State Code";
                }
            }
        }
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                if (BasicTools.isValidZipCode(value))
                    zipCode = value;
                else
                {
                    zipCode = "";
                    feedback += "\n Error: Zip Code";
                }
            }
        }
        public string PhoneNum
        {
            get
            {
                return phoneNum;
            }
            set
            {
                if (BasicTools.isValidPhoneNum(value))
                    phoneNum = value;
                else
                {
                    phoneNum = "";
                    feedback += "\n Error: Phone Number";
                }
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                if (BasicTools.isValidEmail(value))
                    emailAddress = value;
                else
                {
                    emailAddress = "";
                    feedback += "\n Error: Email Address";
                }
            }
        }
        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }
    }
}
