using System.Collections;

class MyClass
{
    
    //string color = "red";        
    int maxSpeed = 200;          
    public void fullThrottle()  
    {
        //hash set
        Console.WriteLine("HASH SET");
        Console.WriteLine();
         HashSet<int> set1 = new HashSet<int>();

          for (int i = 1; i <= 10; i++)
          {
              set1.Add(i);
          }

          Console.WriteLine("The first 10 natural numbers are:");
          foreach (int i in set1)
          {
              Console.WriteLine(i);
          }
        //stack
        Console.WriteLine("STACK");
        int[] example = { 2, 4, 5, 3, 2 };
        Stack<int> st = new Stack<int>(example);
        st.Push(1);
        foreach (int d in st)
        {
            Console.WriteLine(d + " ");
        }
        Console.WriteLine("Sorted LIST ");
        SortedList<int, string> s = new SortedList<int, string>();
        s.Add(1, "harsh");
        s.Add(2, "Surbhi");
        s.Add(3, "Chhavi");
        s.Add(1, "shivani");
        s.Add(7, "ishita");
        s.Add(6, "Shree");
        Console.WriteLine("SortedList elements are as follows:");
        foreach (KeyValuePair<int, string> i in s)
        {
            Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
        }
        Console.WriteLine("ARRAY_LIST");
        ArrayList ar = new ArrayList();
        ar.Add(5);
        ar.Add(1);
        ar.Add(9);
        ar.Add(6);
        ar.Add(2);
        ar.Add(8);
        ar.Add(3);
        ar.Add(7);
        Console.Write("ArrayList elements are: ");
        foreach (int i in ar)
        {
            Console.Write(i + " ");
        }

    }
    static void Main(string []args)
    {
        MyClass obj = new MyClass();
        
        obj.fullThrottle();
    }
    
}
/*using System;
using System.Collections;
public class Example
{
   public static void Main()
   {
       ArrayList arr = new ArrayList();
       arr.Add("AB");
       arr.Add("BC");
       arr.Add("DE");
       arr.Add("FG");
       arr.Add("HI");
       arr.Add("JK");
       --->>string[] myArr = arr.ToArray(typeof(string)) as string[];
       foreach (string a in myArr)
       {
           Console.WriteLine(a);
       }
   }
}*///to understand

