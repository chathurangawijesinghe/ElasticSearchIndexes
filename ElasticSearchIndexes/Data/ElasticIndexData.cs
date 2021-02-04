using Elasticsearch.Net;
using ElasticSearchIndexes.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchIndexes.Data
{
    public class ElasticIndexData : IElasticIndexData
    {
        private IElasticClient ElasticClient;

        public ElasticIndexData()
        {
            var uri = new Uri("http://localhost:9200");
            ElasticClient = new ElasticClient(uri);
        }
        public IReadOnlyCollection<ElasticSqlDataCounts>  Get()
        {
            var elasticData = GetElasticData();
            var sqlData = GetSqlData();

            List<ElasticSqlDataCounts> result = new List<ElasticSqlDataCounts>();
            foreach (var sql in sqlData)
            {
                var data = elasticData.Where(w => w.Index == sql.IndexName).FirstOrDefault();
                if (data != null)
                {
                    var countData = new ElasticSqlDataCounts();
                    countData.ViewName = sql.ViewName;
                    countData.IndexName = sql.IndexName;
                    countData.ViewCount = sql.ViewCount;
                    countData.IndexCount = Int32.Parse( data.DocsCount);

                    result.Add(countData);
                }
            }

            return result;
        }

        private List<CatIndicesRecord> GetElasticData()
        {
            var searchResponse = ElasticClient.Cat.Indices();

            if (searchResponse.IsValid)
            {
                return searchResponse.Records.ToList();
            }

            return null;
        }

        private IReadOnlyCollection<DashboardView> GetSqlData()
        {
            var context = new SearchContext();
            var data = context.DashboardView.ToList();

            return data;
        }
    }
}
