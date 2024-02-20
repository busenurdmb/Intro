using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    
    public class CourseManager//operasyon tutucu sınıflar
    {
        //BUSİNES VERİ ERİŞİMİNE SOYUTLARINDAN çalışabilir.
        private readonly ICourseDal _courseDal;
        //dependency injection
      public CourseManager(ICourseDal courseDal)//eğer beni newlersen bana bir coursedal vermek zorundasın
        {
            _courseDal = courseDal;
        }




        //Course[] courses = new Course[3];
        ////Inmemory dediğimiz ortamda array tabanlı bir yapıda bu süreci konuştuk
        ////constructor
        //public CourseManager()//ctor->CourseManager newlendiğinde çalışır.
        //{

        //    Course course1 = new Course();

        //    course1.Id = 1;
        //    course1.Name = "C#";
        //    course1.Description = ".NET 8 vs...";
        //    course1.Price = 0;


        //    Course course2 = new Course();
        //    course2.Id = 2;
        //    course2.Name = "JAVA";
        //    course2.Description = "Java 17 ....";
        //    course2.Price = 10;

        //    Course course3 = new Course();
        //    course3.Id = 3;
        //    course3.Name = "Python";
        //    course3.Description = "Python 3.12...";
        //    course3.Price = 20;

        //    courses[0] = course1;
        //    courses[1] = course2;
        //    courses[2] = course3;

        //    //Console.WriteLine("Başladı...");
        //}
        //business,data bunlar katmana karşılık gelir.business ,data ,presentation bunlar birbirini newleyemez
        //busines datayı newleyemez
        public List<Course> GetAll()
        {
            //busines rules iş kuralları

            //bunu böyle koyarsan başka katman newleyemez ve bağımlısın
            //CourseDal coursedal = new CourseDal();
            //veri tabanı katmanına gidip bu bütün kurallardan geçti
            return _courseDal.GetAll();//datayı ver
        }


        //public void GetAll()
        //{
        //    //Veri kaynağından çekilir
        //    Console.WriteLine("Kurslar Listelendi");
        //}
    }
}
