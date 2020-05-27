using DictionaryInterface;
using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace JsonRepo
{
    public class JsonRepository : IPhoneDictionary
    {
        private JsonSerializer jsonSerializer = new JsonSerializer();

        private string path = HttpContext.Current.Server.MapPath(@"~/App_Data/records.json");

        public List<Record> GetRecords()
        {
            List<Record> records;
            using (JsonTextReader fs = new JsonTextReader(File.OpenText(path)))
            {
                records = jsonSerializer.Deserialize<List<Record>>(fs);
            }
            return records.OrderBy(a => a.Name).ToList();
        }

        public void AddRecord(Record record)
        {
            List<Record> records = GetRecords();

            using (JsonTextWriter fs = new JsonTextWriter(new StreamWriter(path)))
            {
                records.Add(record);
                jsonSerializer.Serialize(fs, records);
            }
        }

        public void Delete(int id)
        {
            List<Record> records = GetRecords();

            using (JsonTextWriter fs = new JsonTextWriter(new StreamWriter(path)))
            {
                records = records.Select(r => r).Where(r => r.Id != id).ToList();
                jsonSerializer.Serialize(fs, records);
            }
        }

        public void Update(Record newRecord)
        {
            List<Record> records = GetRecords();

            using (JsonTextWriter fs = new JsonTextWriter(new StreamWriter(path)))
            {
                int index = records.FindIndex(r => r.Id == newRecord.Id);
                records[index] = newRecord;
                jsonSerializer.Serialize(fs, records);
            }

        }
    }
}