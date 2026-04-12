using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CODE_JURNAL_MODUL7
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    internal class DataMahasiswa_103082430001
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103082430001.json");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<DataMahasiswa_103082430001>(jsonString, options);

            Console.WriteLine($"Name: {data.firstName} {data.lastName}");
            Console.WriteLine($"Age: {data.age} | Gender: {data.gender}");
            Console.WriteLine($"Address: {data.address.streetAddress}, {data.address.city}, {data.address.state}");
        }
    }
}
