using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103082400042
{
    // Properti harus pas sama key di JSON kamu
    public string nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }
    public string prodi { get; set; }

    public void ReadJSON()
    {
        // Baca file json-nya
        string jsonString = File.ReadAllText("jurnal7_1_103082400042.json");

        // Deserialisasi ke object
        DataMahasiswa103082400042 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103082400042>(jsonString);

        // Print hasil sesuai instruksi
        Console.WriteLine($"Nama: {mahasiswa.nama}");
        Console.WriteLine($"NIM: {mahasiswa.nim}");
        Console.WriteLine($"Fakultas: {mahasiswa.fakultas}");
        Console.WriteLine($"Program Studi: {mahasiswa.prodi}");
    }
}