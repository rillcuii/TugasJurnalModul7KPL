using CODE_JURNAL_MODUL7;

class Program
{
    static void Main(string[] args)
    {
        // Panggil Tugas 1
        var tugas1 = new DataMahasiswa_103082430001();
        tugas1.ReadJSON();

        Console.WriteLine("\n------------------\n");

        // Panggil Tugas 2
        var tugas2 = new GlossaryMahasiswa_103082430001();
        tugas2.ReadJSON();
    }
}