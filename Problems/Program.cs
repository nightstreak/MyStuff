using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            string Prefix(string input){
                if(input is null){
                    return "0,0:";
                }
                int wordlength = input.Length;
                string[] splitword = new string[100];
                splitword = input.Split(' ');
                int wordcount = splitword.Length;
                return $"{wordlength},{wordcount}:{input}";
            }
            Console.WriteLine("Hello World!");
        }
    }
}
