using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities
{
    //class olmasının sebebi birden fazla özelliği içinde barındırıyor olması birtanesi
    public class Course//özellik tutucu sınıf
    {
        //Prop tanımlarken PascalCase kullanıyoruz.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
