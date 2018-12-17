using Sistrategia.SAT.CFDiWebSite.CloudStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistrategia.SAT.CFDiWebSite.Models
{
    public class GetTimbradoLogViewModel
    {
        public List<CloudStorageItem> CloudStorageItems { get; set; }        
    }
    public class MigrationViewModel

    {
        public List<Migration> PendingMigrations { get; set; }
        public Migration CurrentMigration { get; set; }  

    }

    public class Migration
    {
        public string Name { get; set; }
    }
}