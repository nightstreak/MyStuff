using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input){
                if(input == ""){
                    return "0,0:";
                }
                int wordlength = input.Length;
                string[] splitword = new string[100];
                splitword = input.Split(' ');
                int wordcount = splitword.Length;
                return $"{wordlength},{wordcount}:{input}";
            }
        static void Main(string[] args)
        {
            Program test = new Program();
            Console.WriteLine(test.Prefix("I have 99  problems !!"));
            Console.WriteLine(test.Prefix("Wool is not nice."));
            Console.WriteLine(test.Prefix("....I'm fine....  "));
        }
    }
}
