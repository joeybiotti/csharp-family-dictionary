using System;
using System.Collections.Generic;

namespace family_dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Steve"},
                {"age", "31"}
            });
            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Christine"},
                {"age", "29"}
            });
            myFamily.Add("brother2", new Dictionary<string, string>(){
                {"name", "Danny"},
                {"age", "21"}
            });
        

            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {       
                     
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");

            };

        }
    }
}
