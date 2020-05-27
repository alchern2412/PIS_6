using DictionaryInterface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepo
{
    public class SqlRepository : IPhoneDictionary
    {
        private RecordContext db = new RecordContext();


        public List<Record> GetRecords()
        {
            IEnumerable<Record> records = db.Records;
            List<Record> r = records.ToList();
            return r;
        }

        public void AddRecord(Record record)
        {
            db.Records.Add(record);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            IEnumerable<Record> records = db.Records;
            List<Record> r = records.ToList();
            Record delRecord = r.Find(rec => rec.Id == id);
            db.Records.Remove(delRecord);
            db.SaveChanges();

        }

        public void Update(Record newRecord)
        {
            IEnumerable<Record> records = db.Records;
            List<Record> r = records.ToList();
            Record updateRec = r.Find(rec => rec.Id == newRecord.Id);

            updateRec.Name = newRecord.Name;
            updateRec.Number = newRecord.Number;
            db.SaveChanges();

        }
    }
}
