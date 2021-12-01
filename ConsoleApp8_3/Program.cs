using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Program p = new Program();
            Random rand = new Random();
            string path = @"C:\testfolder\text.txt";
            string text = "";
            string[] words = new string[0];
            p.ReadString(path, out words, out text);
            
            Console.WriteLine("Количество слов: " + words.Length);
            Console.WriteLine("Количество символов: " + text.Length);
            Console.WriteLine("Количество строк: " + (Convert.ToInt32(new Regex("\n").Matches(text).Count)+1));

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        public void ReadString(string path, out string[] words, out string text)
        {
            text = "";            
            words = new string[0];
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                    text = text.Replace("  ", "");
                    words = text.Split(' ');
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }       
        }        
    }
}