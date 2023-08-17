using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_C_.Demo3
{
    public class CodeTeacher : Teacher,ITeacher //lớp cha đầu tiên xong mới đến interface 
    {
        private int age;
       
        public CodeTeacher(string name,int a) :base(name)
        {
            this.age = age;
        }
        public override void Teach()
        {
            base.Lunch();
        }
        public new void Lunch()// khởi tạo mảng mới 
        {

        }
        public void Eat()
        {

        }
    }
}
