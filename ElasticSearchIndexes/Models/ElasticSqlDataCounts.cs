using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchIndexes.Models
{
    public class ElasticSqlDataCounts
    {
        public string ViewName { get; set; }
        public string IndexName { get; set; }
        public long ViewCount { get; set; }
        public long IndexCount { get; set; }
    }
}
