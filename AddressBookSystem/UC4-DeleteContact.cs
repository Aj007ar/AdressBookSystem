﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC4_DeleteContact:UC3_EditContact
    {
        public void Delete()
        {
            Console.WriteLine("Enter Name For delete contact");
            var dict = Console.ReadLine().ToUpper();
            if (dict.Contains(dict))
                contact.Remove(dict);
            else
                Console.WriteLine("Person not found"); Delete();
        }
    }
}
