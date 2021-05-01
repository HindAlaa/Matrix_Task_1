using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace matrix_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document1.txt", Encoding.UTF8);
            string[] document = file.Split();
            Console.WriteLine("please enter two search words");
            string first_word = Console.ReadLine();
            string second_word = Console.ReadLine();
            Console.WriteLine(" please enter the operation & or | ");
            string operation = Console.ReadLine();
            //------------------------------------
            if (operation == "&")
            {
                if (document.Contains(first_word) && document.Contains(second_word))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                string fileA = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document 2.txt", Encoding.UTF8);
                string[] documentA = fileA.Split();
                if (documentA.Contains(first_word) && documentA.Contains(second_word))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0 ");
                }
                string fileB = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document 3.txt", Encoding.UTF8);
                string[] documentB = fileB.Split();
                if (documentB.Contains(first_word) && documentB.Contains(second_word))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                string fileC = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document 4.txt", Encoding.UTF8);
                string[] documentC = fileC.Split();
                if (documentC.Contains(first_word) && documentC.Contains(second_word))
                {
                    Console.WriteLine("1");

                }
                else
                {
                    Console.WriteLine("0");
                }
                if (document.Contains(first_word) && document.Contains(second_word))
                {
                    Console.WriteLine("in document 1");
                }
                if (documentA.Contains(first_word) && documentA.Contains(second_word))
                {
                    Console.WriteLine("in document 2");
                }
                if (documentB.Contains(first_word) && documentB.Contains(second_word))
                {
                    Console.WriteLine("in document 3");
                }
                if (documentC.Contains(first_word) && documentC.Contains(second_word))
                {
                    Console.WriteLine("in document 4");

                }
     }
            //----------------
   if (operation == "|")
    {

                if (document.Contains(first_word) || document.Contains(second_word))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                string fileA = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document 2.txt", Encoding.UTF8);
                string[] documentA = fileA.Split();
                if (documentA.Contains(first_word) || documentA.Contains(second_word))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0 ");
                }
                string fileB = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document 3.txt", Encoding.UTF8);
                string[] documentB = fileB.Split();
                if (documentB.Contains(first_word) || documentB.Contains(second_word))
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                string fileC = File.ReadAllText(@"c:\users\it shop\desktop\visual studio 2015\Projects\matrix_Task 1\matrix_Task 1\document 4.txt", Encoding.UTF8);
                string[] documentC = fileC.Split();
                if (documentC.Contains(first_word) || documentC.Contains(second_word))
                {
                    Console.WriteLine("1");

                }
                else
                {
                    Console.WriteLine("0");
                }
                if (document.Contains(first_word) || document.Contains(second_word))
                {
                    Console.WriteLine("in document 1");
                }
                if (documentA.Contains(first_word) || documentA.Contains(second_word))
                {
                    Console.WriteLine("in document 2");
                }
                if (documentB.Contains(first_word) || documentB.Contains(second_word))
                {
                    Console.WriteLine("in document 3");
                }
                if (documentC.Contains(first_word) || documentC.Contains(second_word))
                {
                    Console.WriteLine("in document 4");

                }


            }
  
            //-----------------
  else
   {
       Console.WriteLine(" error incorrect operator");
   }
        }
    }
}
