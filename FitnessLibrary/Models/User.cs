using System;
using System.Collections;
using System.Collections.Generic;

namespace FTLibrary.Models
{
    public class User
    {
        public int Id { get; set; }

        //Save these for later?
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string FullName
        {
            get 
            {
                return ($"{ FirstName } { LastName }");
            }
        }
        public IList<Activity> Activities { get; set; }


    }
}
