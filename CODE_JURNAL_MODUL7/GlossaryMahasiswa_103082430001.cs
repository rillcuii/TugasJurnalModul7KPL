using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string GlossTerm { get; set; }
    public GlossDef GlossDef { get; set; }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

// Ini class utamanya
public class GlossaryContainer
{
    public Glossary glossary { get; set; }
}

public class GlossaryMahasiswa_103082430001
{
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103082430001.json");
        var data = JsonSerializer.Deserialize<GlossaryContainer>(jsonString);

        Console.WriteLine("Glossary Title: " + data.glossary.title);
        Console.WriteLine("Gloss Entry ID: " + data.glossary.GlossDiv.GlossList.GlossEntry.ID);
        Console.WriteLine("Definition: " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
    }
}