using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JsonEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewtonsoftEx();
            Console.ReadKey();
        }

        public static void NewtonsoftEx()
        { //How to get some values from a JSON string in C#?    https://stackoverflow.com/questions/17617594/how-to-get-some-values-from-a-json-string-in-c
            //JSON IN C# - Downloading Data and Making Objects From It  https://www.youtube.com/watch?v=N6JBjzPssQI
            string source = "{\r\n   \"id\": \"100000280905615\", \r\n \"name\": \"Jerard Jones\",  \r\n   \"first_name\": \"Jerard\", \r\n   \"last_name\": \"Jones\", \r\n   \"link\": \"https://www.facebook.com/Jerard.Jones\", \r\n   \"username\": \"Jerard.Jones\", \r\n   \"gender\": \"female\", \r\n   \"locale\": \"en_US\"\r\n}";
            dynamic data = JObject.Parse(source);
            Console.WriteLine(data.id);
            Console.WriteLine(data.first_name);
            Console.WriteLine(data.last_name);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.locale);
        }
    }
}
