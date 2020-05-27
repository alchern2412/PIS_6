using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPhoneDictionary
    {
        List<Record> GetRecords();
        void AddRecord(Record record);
        void Delete(int id);
        void Update(Record newRecord);
    }
}
