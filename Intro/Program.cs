// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

//Değişkenler
string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase // İlk kelime küçük diğerleri büyük harfle başlar.
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition // Şart
if (isAuthenticated) //ile (isAuthenticated == true) aynı
{
    Console.WriteLine("Button --> Hoşgeldin Buse");
}
else
{
    Console.WriteLine("Button --> Sisteme Giriş Yap");
}


//array[]->Aynı veriden bir kaç tane tuttuğumuz yapı
string[] loans = ["Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"]; //loans = krediler
//string[] loans1 = new string[] { };//2.yol
//string[] loans2 = new string[6]; //3.Yol
//loans2[0] = "Kredi 1";

//Döngüler-->B ir işlemi istediğimiz kadar belli bir şarta göre tekrsr ettirmeye yarar.
for (int i = 0/*start*/; i < loans.Length /*condition*/; i++/*increment*/)
{
    Console.WriteLine(loans[i]);
}

//class oluştururken newlemek->referans oluşturmak
//Course course1 = new Course();

//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8 vs...";
//course1.Price = 0;


//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "JAVA";
//course2.Description = "Java 17 ....";
//course2.Price = 10;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12...";
//course3.Price = 20;

//Course[] courses = { course1, course2, course3 };
//courses[0] = course1;
//courses[1] = course2;
//courses[2] = course3;

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

//CourseManager courseManager = new();
//Course[] courses2=courseManager.GetAll();
//for (int i = 0; i < courses2.Length; i++)
//{
//    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
//}
//Console.WriteLine("Kod bitti");

IndividualCustomer customer1= new IndividualCustomer();
customer1.Id =1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id =2;
customer2.NationalIdentity = "5647895236";
customer2.FirstName = "Buse nur";
customer2.LastName = "Demirbaş";
customer2.CustomerNumber = "123458";

CorporateCustomer customer3=new CorporateCustomer();
customer3.Id =3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "654321";
customer3.TaxNumber = "12345678956";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id =4;
customer4.Name = "arçelik";
customer4.CustomerNumber = "654325";
customer4.TaxNumber = "12345678959";

//values type-->int,boolean,double....
//reference types-->array,class,interface
//hiç kızmadı
//ınherit edilen sınıflar inherit edildiği sınıfların referansını tutabiliyor
                               //101     //102    //103      //104
BaseCustomer[] customers = {customer1,customer2, customer3, customer4};
//polymorphism-->Çok biçimlilik
//aslında bir method var gerçek hayattan örnek vericeksek
//siz kredi başvursunda bulunucaksınız bir method var hesapla(),ihtiyaç krdisinin hesabı,tarım kredisi hesbaı,tarım vs bunlar yöntemle siz bu yöntemlerden birin enjekte edip onu çalıştırabilmelisiniz
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}    


 CourseManager c=new CourseManager(new efCourseDal());
List<Course> courses = c.GetAll();
foreach (Course course in courses)
{
    Console.WriteLine($"Course: {course.Name}");
}

