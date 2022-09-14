using StackDemo0;
using System.Collections.Generic;

namespace StackDemo;


    internal class Program
    {
        static void Main(string[] args)
        { 
          
                Stack<int> liststack= new Stack<int>();
                liststack.Push(70);  
                liststack.Push(30);  
                liststack.Push(56);

             foreach (int i in liststack)
             {
                 Console.Write(i + "->");
             }


        }
    }
