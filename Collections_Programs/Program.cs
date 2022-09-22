using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Collections_Programs
//{
//Example of Arraylist
// public class Arraylist
// {
//static void Main(string[] args)
//{
// ArrayList list = new ArrayList();

//list.Add(10);
//list.Add(20);
//list.Add(30);
//list.Add(10);
//list.Insert(1, 15);
//list.IndexOf(10); // 0
//  list.LastIndexOf(10);  //3
//list.Remove(30);
// list.RemoveAt(0);

//list.Sort();
// list.Reverse();
// list.Clear();
//Console.WriteLine($"Capacity of list is {list.Capacity}");
//Console.WriteLine(list.Count);
//foreach (var item in list)
//{
//   Console.WriteLine(item);
//}



//  }
//}
//}


//Example of Stack
//  public class Program
// {
// static void Main(string[] args)
// {
// Stack st = new Stack();

// st.Push(50);
// st.Push(20);
// st.Push(30);
//st.Push(10);

// st.Peek();       
//foreach (var item in st)
//{
// Console.WriteLine(item);
//}



//}
//}
//}


namespace Collections_Programs
{

    //Example od Hashtable

    public class Program
    {
       static void main(string[] args)
        {
            Hashtable hs = new Hashtable();

            hs.Add(91, "IND");
            hs.Add(92, "PAK");
            hs.Add(33, " FR");
            hs.Add(35, "AUS");

            hs.Remove(33);

            foreach (var s in hs)
            {
                Console.WriteLine(s);   
            }
        }
    }
}