using System;

namespace CODE_JURNAL_MODUL7  // Sesuaikan nama namespace kelompokmu
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- TEST LEVEL 1 ---
            Console.WriteLine("=== Hasil Deserialisasi JSON 1 ===");
            DataMahasiswa103082400042 level1 = new DataMahasiswa103082400042();
            level1.ReadJSON();
            Console.WriteLine();

            // --- TEST LEVEL 2 ---
            Console.WriteLine("=== Hasil Deserialisasi JSON 2 ===");
            TeamMembers103082400042 level2 = new TeamMembers103082400042();
            level2.ReadJSON();
            Console.WriteLine(); 

            // --- TEST LEVEL 3 ---
            Console.WriteLine("=== Hasil Deserialisasi JSON 3 ===");
            GlossaryItem103082400042 level3 = new GlossaryItem103082400042();
            level3.ReadJSON();
            Console.WriteLine(); 
        }
    }
}