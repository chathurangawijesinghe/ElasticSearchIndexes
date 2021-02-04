using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElasticSearchIndexes.Models;
using Nest;
using Elasticsearch.Net;
using ElasticSearchIndexes.Data;

namespace ElasticSearchIndexes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IElasticIndexData _elasticIndexData;

        public HomeController(ILogger<HomeController> logger,
                                IElasticIndexData elasticIndexData)
        {
            _logger = logger;
            _elasticIndexData = elasticIndexData;
        }

        public IActionResult Index()
        {
            var data = _elasticIndexData.Get();

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
