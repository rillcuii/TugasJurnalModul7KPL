using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CODE_JURNAL_MODUL7
{
    public class DataMahasiswa_103082400033
    {
        public string nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103082400033.json");
            DataMahasiswa_103082400033 data = JsonSerializer.Deserialize<DataMahasiswa_103082400033>(jsonString);

            Console.WriteLine($"nama : {data.nama}, nim : {data.nim}), fakultas : {data.fakultas}");
        }
    }
}
