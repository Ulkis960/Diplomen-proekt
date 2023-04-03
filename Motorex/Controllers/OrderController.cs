using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Motorex.Abstraction;
using Motorex.Data;
using Motorex.Domain;
using Motorex.Models.Order;

namespace Motorex.Controllers
{
    [Authorize]
    
    public class OrderController : Controller
    {

        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = context.Users.SingleOrDefault(u => u.Id == userId);

            List<OrderIndexVM> orders = context
                 .Orders
                .Select(x => new OrderIndexVM
                {
                    Id = x.Id,
                    OrderDate = x.OrderDate.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                    UserId = x.UserId,
                    User = x.User.UserName,
                    MotorId = x.MotorId,
                    Motor = x.Motor.Model,
                    Picture = x.Motor.Picture,
                    Quantity = x.Quantity,
                    Price = x.Price,
                    Discount = x.Discount,
                    TotalPrice = x.TotalPrice,
                }).ToList();
            return View(orders);
        }

        // Get:
        public ActionResult Create(int motorId, int quantity)
        {

            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = this.context.Users.SingleOrDefault(u => u.Id == userId);
            var motor = this.context.Motors.SingleOrDefault(x => x.Id == motorId);

            if (user == null || motor == null || motor.Quantity < quantity)
            {
                return this.RedirectToAction("Index", "Motor");
            }
            OrderConfirmVM orderForDb = new OrderConfirmVM
            {

                // Id = x.Id,
                UserId = userId,
                User = user.UserName,
                MotorId = motorId,
                Model = motor.Model,
                Picture = motor.Picture,

                Quantity = quantity,
                Price = motor.Price,
                Discount = motor.Discount,
                TotalPrice = quantity * motor.Price - quantity * motor.Price * motor.Discount / 100
            };
            return View(orderForDb);

        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderConfirmVM bindingModel)
        {
            if (this.ModelState.IsValid)
            {
                string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = this.context.Users.SingleOrDefault(u => u.Id == userId);
                var motor = this.context.Motors.SingleOrDefault(x => x.Id == bindingModel.MotorId);

                if (user == null || motor == null || motor.Quantity < bindingModel.Quantity || bindingModel.Quantity == 0)
                {
                    return this.RedirectToAction("Index", "Motor");
                }
                Order orderForDb = new Order
                {

                    // Id = x.Id,
                    OrderDate = DateTime.UtcNow,
                    MotorId = bindingModel.MotorId,
                    UserId = userId,
                    Quantity = bindingModel.Quantity,
                    Price = motor.Price,
                    Discount = motor.Discount,


                };

                motor.Quantity -= bindingModel.Quantity;

                this.context.Motors.Update(motor);
                this.context.Orders.Add(orderForDb);
                this.context.SaveChanges();
            }
            return this.RedirectToAction("Index", "Motor");
        }


  
        public IActionResult MyOrders(string searchString)
        {
            string currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = this.context.Users.SingleOrDefault(u => u.Id == currentUserId);
            if (user == null)
            {
                return null;
            }
            List<OrderIndexVM> orders = context
                 .Orders
                  .Where(x => x.UserId == user.Id)
                .Select(x => new OrderIndexVM
                {
                    Id = x.Id,
                    OrderDate = x.OrderDate.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                    UserId = x.UserId,
                    User = x.User.UserName,
                    MotorId = x.MotorId,
                    Motor = x.Motor.Model,
                    Picture = x.Motor.Picture,
                    Quantity = x.Quantity,
                    Price = x.Price,
                    Discount = x.Discount,
                    TotalPrice = x.TotalPrice,
                }).ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o => o.Motor.ToLower().Contains(searchString.ToLower())).ToList();
            }
            return this.View(orders);
        }
    }
}
