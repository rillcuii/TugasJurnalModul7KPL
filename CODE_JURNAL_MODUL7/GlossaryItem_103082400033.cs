using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CODE_JURNAL_MODUL7
{
    public class GlossaryItem_103082400033
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103082400033.json");
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                JsonElement root = doc.RootElement;
                JsonElement glossEntry = root.GetProperty("glossary")
                                             .GetProperty("GlossDiv")
                                             .GetProperty("GlossList")
                                             .GetProperty("GlossEntry");

                Console.WriteLine("GlossEntry Detail:");
                Console.WriteLine(glossEntry.GetRawText());
            }
        }
    }
}
