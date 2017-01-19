using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEFCoreMigration.DAL
{
    public class SampleEFCoreMigrationRespository
    {
        public SampleEFCoreMigrationContext Context { get; set; }

        public SampleEFCoreMigrationRespository(SampleEFCoreMigrationContext sentContext)
        {
            Context = sentContext;
        }
    }
}
