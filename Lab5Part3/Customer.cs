using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab5;
using MidTermProject;

namespace Lab5Part3
{
    class Customer:PersonV2
    {
        private DateTime customerSince;
        private double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;

        public Customer() : base()
        {
            customerSince = DateTime.Now;
            totalPurchases = 1;
            discountMember = false;
            rewardsEarned = 0;
        }
        public Customer (PersonV2 p) : base(p, p.CellNum, p.InstagramURL)
        {
            customerSince = DateTime.Now;
            totalPurchases = 1;
            discountMember = false;
            rewardsEarned = 0;
        }
        public Customer(PersonV2 p, DateTime _customerSince, double _totalPurchases, bool _discountMember, int _rewardsEarned) : base(p, p.CellNum, p.InstagramURL)
        {
            CustomerSince = _customerSince;
            TotalPurchases = _totalPurchases;
            DiscountMember = _discountMember;
            RewardsEarned = _rewardsEarned;
        }
        public Customer(string _fName, string _mName, string _lName, string _streetOne, string _streetTwo, string _city, string _stateCode, string _zipCode, string _phoneNum, string _emailAddress, string _cellNum, string _instagramURL, DateTime _customerSince, double _totalPurchases, bool _discountMember, int _rewardsEarned)
        : base(_fName, _mName, _lName, _streetOne, _streetTwo, _city, _stateCode, _zipCode, _phoneNum, _emailAddress, _cellNum, _instagramURL)
        {
            CustomerSince = _customerSince;
            TotalPurchases = _totalPurchases;
            DiscountMember = _discountMember;
            RewardsEarned = _rewardsEarned;
        }

        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                if(BasicTools.isFutureDate(value))
                {
                    customerSince = DateTime.Now;
                    Feedback += "\n Error: Date Time Customer Since";
                }
                else
                {
                    customerSince = value;
                }
            }
        }
        public double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }
            set
            {
                if(BasicTools.isNegative(value))
                {
                    totalPurchases = 1.0;
                    Feedback += "\n Error: Purchase Total";
                }
                else
                {
                    totalPurchases = value;
                }
            }
        }

        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                //This will always be bool no other reasonable check needed
                discountMember = value;
            }
        }

        public int RewardsEarned 
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                if(BasicTools.isNegative(value))
                {
                    rewardsEarned = 0;
                    Feedback += "\n Error: Earned Rewards";
                }
                else
                {
                    rewardsEarned = value;
                }
            }
        }
    }
}
