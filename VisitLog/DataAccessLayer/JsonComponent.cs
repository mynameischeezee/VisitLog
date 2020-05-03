using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace VisitLog.DataAccessLayer
{
   public static class JsonComponent
    {
        public static T DeSerialize<T>(string Path, string FileName)
        {
            string ReadFile = File.ReadAllText(Path + @"\" + FileName + ".json");
            //return (object)JsonConvert.DeserializeObject(ReadFile);
            return (T)JsonConvert.DeserializeObject<T>(ReadFile);

        }
        public static T DeSerializet<T>(string Path)
        {
            string ReadFile = File.ReadAllText(Path);
            return (T)JsonConvert.DeserializeObject<T>(ReadFile);
        }
        public static void Serialize(object Obj, string Path, string FileName)
        {
            string SerializeResult = JsonConvert.SerializeObject(Obj);
            File.WriteAllText(Path + @"\" + FileName + ".json", SerializeResult);

        }
    }
}
