using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_C_.Demo2
{
    public class Student
    {
        private string name;
        private int age;
        private string telephone;
        public Student()
        {
            this.Eat();
        }
        // property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get => age;
            set => age = value >=18? value:18;
        }
        public string Telephone
        {
            get => telephone;
            set => telephone = value;
        }
        //Abstract property
        public int Balance { get; set; }
        public void Eat()
        {

        }
       


        public void Eat(string msg)
        {

        }

    }
}
