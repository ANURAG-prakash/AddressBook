using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBookSystem
{
    public class FileOperation
    {

        public static void ReadFromStreamReader()
        {
            String path = @"D:\AddressProblems\AddressProblems\Book.txt";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        String s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                else
                {
                   Console.WriteLine( "File Not Exists");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = "E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\AddreddBook.txt";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        Console.WriteLine("Book Name");
                        sr.Write("Book Name  : ");
                        string bookName = Console.ReadLine();
                        sr.WriteLine(bookName);
                        Console.WriteLine("Enter First Name");
                        sr.Write("First Name  : ");
                        string name = Console.ReadLine();
                        sr.WriteLine(name);
                        Console.WriteLine("Enter Last Name");
                        sr.Write("Last Name  : ");
                        string lname = Console.ReadLine();
                        sr.WriteLine(lname);

                        sr.Close();
                        Console.WriteLine(File.ReadAllText(path));
                    }
                }

                else
                {
                    Console.WriteLine( "File Not Exists");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }





    }
}
