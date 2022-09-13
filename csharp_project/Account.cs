using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_project
{
    internal class Account
    {
        #region Properties
        //Auto Property
        public string Number_Account { get; set; }
        public string Name_Account { get; set; }

        //Backing field - temp
        private decimal _price;

        //Full Property
        public decimal Price
        {
            get { return _price; }
            set
            {
                /*if (value < 0) {
                    _price = 0;
                }
                else {
                    _price = value;
                }*/

                //Prevent negative numbers in the property
                _price = value < 0 ? 0 : value;
            }
        }
        #endregion

        public static string Bank { get; set; }

        #region Constructors
        //Constructor
        public Account()
        {
            //default for testing purposes
        }


        public Account(string number_account)
        {
            Number_Account = number_account;
        }

        //Call constructor from another constructor
        public Account(string number_account, string name_account) : this(number_account)
        {
            Name_Account = name_account;
        }

        public Account(string number_account, string name_account, decimal price) : this(number_account, name_account)
        {
            Price = price;
        }
        #endregion

        #region Methods
        public void LessBucks(decimal cantidad)
        {
            if (cantidad > Price)
            {
                Console.WriteLine("No founds source, please play hard");
                return;
            }
            Price -= cantidad;
        }

        public void MoreBucks(decimal cantidad)
        {
            Price += cantidad;
        }

        public override string ToString()
        {
            return string.Format("Account 02:{0}   User:{1}   Price:{2}", Number_Account, Name_Account, Price);
        }

        #endregion

        //Solo los metodos Static pueden modificar propiedades del mismo tipo
        public static void UpdateBank(string bank)
        {
            Console.WriteLine("Updated new Bank");
            Bank = bank;
        }
    }
}
