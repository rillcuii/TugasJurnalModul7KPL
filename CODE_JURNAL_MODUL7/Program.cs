using CODE_JURNAL_MODUL7;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("--Output DataMahasiswa--");
            DataMahasiswa_103082400033 mhs = new DataMahasiswa_103082400033();
            mhs.ReadJSON();

            Console.WriteLine();

            Console.WriteLine("--- Output Tugas 2 ---");
            TeamMembers_103082400033 team = new TeamMembers_103082400033();
            team.ReadJSON();

            Console.WriteLine();

            Console.WriteLine("--- Output Tugas 3 ---");
            GlossaryItem_103082400033 glossary = new GlossaryItem_103082400033();
            glossary.ReadJSON();

            Console.WriteLine();
        }
        catch (Exception ex)
        { 
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}"); 
        }
    }
}