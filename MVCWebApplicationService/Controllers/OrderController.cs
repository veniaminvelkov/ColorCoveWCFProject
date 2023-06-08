using ApplicationService.DTOs;
using MVCWebApplicationService.Utilities;
using MVCWebApplicationService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplicationService.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            List<OrderViewModel> orderVM = new List<OrderViewModel>();
            using (OrderService.OrderClient service = new OrderService.OrderClient())
            {
                foreach (var item in service.GetOrders())
                {
                    orderVM.Add(new OrderViewModel(item));
                }
            }
            return View(orderVM);
        }

        public ActionResult Details(int id)
        {
            OrderViewModel orderVM = new OrderViewModel();
            using (OrderService.OrderClient service = new OrderService.OrderClient())
            {
                var orderDTO = service.GetOrderByID(id);
                orderVM = new OrderViewModel(orderDTO);
            }

            return View(orderVM);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Orders = LoadDataUtilities.LoadOrdersData();

            OrderViewModel orderVM = new OrderViewModel();
            using (OrderService.OrderClient service = new OrderService.OrderClient())
            {
                var orderDTO = service.GetOrderByID(id);
                orderVM = new OrderViewModel(orderDTO);
            }

            return View(orderVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrderViewModel orderVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (OrderService.OrderClient service = new OrderService.OrderClient())
                    {
                        OrderDTO orderDTO = new OrderDTO
                        {
                            Id = orderVM.Id,
                            CustomerId= orderVM.CustomerId,
                            PaintId=orderVM.PaintId,
                            OrderedBy=orderVM.OrderedBy,
                            PaintOrdered=orderVM.PaintOrdered,
                            Quantity = orderVM.Quantity
                            
                        };
                        service.PostOrder(orderDTO);
                    }

                    return RedirectToAction("Index");
                }
                ViewBag.Orders = LoadDataUtilities.LoadOrdersData();
                return View();
            }
            catch
            {
                ViewBag.Orders = LoadDataUtilities.LoadOrdersData();
                return View();
            }
        }

        public ActionResult Delete(int id)
        {

            using (OrderService.OrderClient service = new OrderService.OrderClient())
            {
                service.DeleteOrder(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.Orders = LoadDataUtilities.LoadOrdersData();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel orderVM)
        {
            try
            {
                using (OrderService.OrderClient service = new OrderService.OrderClient())
                {
                    OrderDTO orderDTO = new OrderDTO
                    {
                        Id = orderVM.Id,
                        CustomerId = orderVM.CustomerId,
                        PaintId = orderVM.PaintId,
                        OrderedBy = orderVM.OrderedBy,
                        PaintOrdered = orderVM.PaintOrdered,
                        Quantity = orderVM.Quantity
                    };
                    service.PostOrder(orderDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Orders = LoadDataUtilities.LoadOrdersData();
                return View();
            }
        }
    }
}