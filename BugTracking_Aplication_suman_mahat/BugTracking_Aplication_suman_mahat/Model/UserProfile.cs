using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking_Aplication_suman_mahat.Model
{
    class UserProfile
    {
        //variables for profile 
        private int UserId;
        private string FullName;
        private string email;
        private string password;
        private string contact;
        private string status;

        //shotcut key for getter setter cntl + R+ E

        // gretter setter method for fullname
        

        public string FullName1
        {
            get
            {
                return FullName;
            }

            set
            {
                FullName = value;
            }
        }
        // gretter setter method for email
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        // gretter setter method for password
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        // gretter setter method for contact
        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        // gretter setter method for status
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        // gretter setter method for userid
        public int UserId1
        {
            get
            {
                return UserId;
            }

            set
            {
                UserId = value;
            }
        }
    }

    }

