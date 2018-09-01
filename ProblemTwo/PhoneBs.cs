using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo
{
    public class PhoneBs
    {
        public Phone GetPhoneNumber(string countryCode,string phoneNumber)
        {
            using (ProjectModelContainer container = new ProjectModelContainer())
            {
                return container.Phones.FirstOrDefault(x => x.CountryCode == countryCode && x.PhoneNumber == phoneNumber);
            }
        }
    }
}
