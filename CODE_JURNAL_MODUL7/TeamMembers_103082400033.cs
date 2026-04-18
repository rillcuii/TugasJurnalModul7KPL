using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CODE_JURNAL_MODUL7
{

    public class members()
    {
        public string nim { get; set; }
        public string namadepan { get; set; }
        public string namabelakang { get; set; }
        public string gender { get; set; }
        public string umur { get; set; }
    }
    public class TeamMembers_103082400033
    {
        public List <members> members { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103082400033.json");
            TeamMembers_103082400033 team = JsonSerializer.Deserialize<TeamMembers_103082400033>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var m in team.members)
            {
                Console.WriteLine($"{m.nim} {m.namadepan} {m.namabelakang} ({m.umur} {m.gender})");
            }
        }
    }
}
