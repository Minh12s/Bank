using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using T2210A_C_.Demo2;
using T2210A_C_.Demo3;
using T2210A_C_.Demo4;

public class Program
{
    public static void Main(string[] args)
    {
        VoidStringDelegate vsd = new VoidStringDelegate(DemoDelegate.Goodbye);
        vsd("xin chao");
      //  VoidStringDelegate vsd1 = new VoidStringDelegate(DemoDelegate.SayHello);
        vsd("hello");
        var t2 = new DemoDelegate();
        t2.SayHello("T2210A");
        DemoDelegate.Goodbye("T2210A");

        VoidStringDelegate vsd2 = new VoidStringDelegate(new DemoDelegate().SayHello);
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;
        vsd("T2210A");

        DisplayMessage("HelloWord", DemoDelegate.Goodbye);

        VoidStringDelegate vsd3 = delegate (string s)
        {
            Console.WriteLine(s);
        };
        VoidStringDelegate vsd4 = s => Console.WriteLine(s);
        vsd3("aaa");
        vsd4("sdes");


    }
    static void DisplayMessage(string message, VoidStringDelegate callback)
    {
        callback(message);
    }
    
    public static void Main2(string[]args)
    {
        Student s = new Student();
        s.Name = "Nguyen Van An";
        s.Eat("bal");
        s.Eat();

        List<Student> listStudent = new List<Student>();
    }
   public static void Main3(string[]args)
    {
        Teacher t = new Teacher();
        t.Tels.Add("89297347");
        t.Tels.Add("89297347");
        Console.WriteLine(t.Tels[0]);
        t[0] = "0111222333";//t.Tels(0) = "0111222333"
        Console.WriteLine(t[0]);
      

    }
}