namespace Intro.Entities
{
    //CorporateCustomer:BaseCustomer-->diyorumki sen bir Base CUstomersın
    //ınherit edilen sınıflar inherit edildiği sınıfların referansını tutabiliyor
    //Kurumsal müşteri
    public class CorporateCustomer:BaseCustomer
    {
       public string Name { get; set; }
        public string TaxNumber { get; set; }//vergi numarası
    }

}
