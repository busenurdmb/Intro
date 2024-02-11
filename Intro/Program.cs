// See https://aka.ms/new-console-template for more information
using Intro.Business;
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

CourseManager courseManager = new();
Course[] courses2=courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
Console.WriteLine("Kod bitti");
