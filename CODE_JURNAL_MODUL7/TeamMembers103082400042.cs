using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Member
{
    public string nim { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
}

public class TeamMembers103082400042
{
    public List<Member> members { get; set; }

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103082400042.json");
        TeamMembers103082400042 team = JsonSerializer.Deserialize<TeamMembers103082400042>(jsonString);

        Console.WriteLine("Team member list:");
        foreach (var m in team.members)
        {
            Console.WriteLine($"{m.nim} {m.firstName} {m.lastName} ({m.age} {m.gender})");
        }
    }
}