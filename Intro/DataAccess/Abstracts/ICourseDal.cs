using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts
{
    public interface ICourseDal 
        //beni implemente eden sınıf şu ikisini içermek zorunda
        //olay sadece bu değil olay poliformizm
        //bunu implemente edenler referans tipli olmasında dolayı mevcut referanstan yararlanmak
    {
        public List<Course> GetAll();
        public void Add(Course course);
    }
}
