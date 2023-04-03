using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Motorex.Abstraction;
using Motorex.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StatisticsController : Controller
    {
        private readonly IStatisticService statisticsService;
        public StatisticsController(IStatisticService statisticsService)
        { this.statisticsService = statisticsService; }
        public IActionResult Index()
        {
            StatisticsVM statistics = new StatisticsVM();
            statistics.CountClients = statisticsService.CountClients();
            statistics.CountProducts = statisticsService.CountProducts();
            statistics.CountOrders = statisticsService.CountOrders();
            statistics.SumOrders = (int)statisticsService.SumOrders();

            return View(statistics);
        }
    }
}
