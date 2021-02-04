using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearchIndexes.Models
{
    [Table("ElasticData")]
    public class DashboardView
    {
        [Key]
        public int Id { get; set; }
        public string ViewName { get; set; }
        public string IndexName { get; set; }
        public long ViewCount { get; set; }
    }
}
