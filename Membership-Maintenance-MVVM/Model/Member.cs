using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_Maintenance_MVVM.Model
{
    public class Member : IEquatable<Member>
    {
        private string _firstName;
        private string _lastName;
        private string _email;

        /// <summary>
        /// Property for FirstName
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length > 25)
                {
                    _firstName = value;
                }
            }
        }

        /// <summary>
        /// Property for LastName
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length > 25)
                {
                    _lastName = value;
                }
            }
        }

        /// <summary>
        /// Property for Email
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 25)
                {
                    _email = value;
                }
            }
        }






        /// <summary>
        /// Default Constructor for Member
        /// </summary>
        public Member()
        {

        }

        /// <summary>
        /// Overloaded Constructor for Member
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Email"></param>
        public Member(string FirstName, string LastName, string Email)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _email = Email;
        }

        /// <summary>
        /// Creates a formatted string for the textbox
        /// </summary>
        /// <returns>formatted string for displaying</returns>
        public string GetDisplayText
        {
            get
            {
                return _firstName + " " + _lastName + " - " + _email;

            }
        }

        /// <summary>
        /// Determines equality of 2 Member objects
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Member other)
        {
            return (this._firstName == other._firstName
                && this._lastName == other._lastName
                && this._email == other._email);
        }
    }
}
