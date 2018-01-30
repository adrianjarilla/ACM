using System;

namespace ACM_BL
{
    public class Customer
    {
        private string _lastName;
        
        public string LastName
        {
            get
            {
                //Any code here
                return _lastName;
            }
            set
            {
                //Any code here
                 _lastName = value;

            }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }


    }
}
