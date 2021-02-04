using ElasticSearchIndexes.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchIndexes.Data
{
    public interface IElasticIndexData
    {
        IReadOnlyCollection<ElasticSqlDataCounts> Get();
    }
}
