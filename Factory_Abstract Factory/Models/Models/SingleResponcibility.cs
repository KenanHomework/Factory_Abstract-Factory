using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponcibility
{
    class PhoneNumber
    {
        public string Number { get; set; }

        public string Country { get; set; }
    }

    abstract class PhonenumberChecker
    {
        public static bool Check(PhoneNumber number)
        {
            // amazing code
            return true;
        }
    }

    abstract class CallService
    {
        public void Call(PhoneNumber number)
        {
            if (PhonenumberChecker.Check(number))
                Console.WriteLine("Calling....");
        }
    }
}
