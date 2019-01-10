using Newtonsoft.Json;
using System;

namespace App
{
    public class Class1
    {
        public void Test()
        {
            var x = JsonConvert.DeserializeObject<Person>("{ 'firstName' : 'Ted' }");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
    }
}
