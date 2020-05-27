﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepo
{
    public class RecordDbinitializer : CreateDatabaseIfNotExists<RecordContext>
    {
        protected override void Seed(RecordContext db)
        {
            db.Records.Add(new Record(1, "Alex", "+777"));
            db.Records.Add(new Record(2, "Anastasia", "+234423"));
            db.Records.Add(new Record(3, "Yaroslav", "+123444343"));

            base.Seed(db);
        }


    }
}
