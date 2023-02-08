using Newtonsoft.Json;
using Praktan10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktan10
{
    internal class SandDs
    {
        public static void Ds()
        {
            string Tuk = File.ReadAllText("C:\\10 Практическая\\Данные.json");
            List<List<string>> Vse = JsonConvert.DeserializeObject<List<List<string>>>(Tuk);
            Global.AllVse = Vse;
        }
        public static void S()
        {
            string json = JsonConvert.SerializeObject(Global.AllVse);
            File.WriteAllText("D:\\10 Практическая\\Данные.json", json);
        }
    }
}