using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInterface
{
    public interface IPhoneDictionary
    {
        List<Record> GetRecords();
        void AddRecord(Record record);
        void Delete(int id);
        void Update(Record newRecord);
    }
}
