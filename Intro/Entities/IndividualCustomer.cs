using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities
{
    //Inheritance(miras)->nesneleri birbirinden ayırmak aynı zamanda birbirinin referansını alarak kullanılabilme sürecidir.
    //IndividualCustomer:BaseCustomer CorporateCustomer:BaseCustomer
    //bunu dediğimiz zaman ikinizde müşterisininz demiş oluyoruz.
    //IndividualCustomer:BaseCustomer sen basecustomersın
    //bireysel müşteri
    public class IndividualCustomer:BaseCustomer
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }//>TC
    }

}
