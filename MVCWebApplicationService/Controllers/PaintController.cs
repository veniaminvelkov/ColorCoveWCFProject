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
    public class PaintController : Controller
    {
        public ActionResult Index()
        {
            List<PaintViewModel> PaintVM = new List<PaintViewModel>();
            using (PaintService.PaintClient service = new PaintService.PaintClient())
            {
                foreach (var item in service.GetPaints())
                {
                    PaintVM.Add(new PaintViewModel(item));
                }
            }
            return View(PaintVM);
        }

        public ActionResult Details(int id)
        {
            PaintViewModel paintVM = new PaintViewModel();
            using (PaintService.PaintClient service = new PaintService.PaintClient())
            {
                var paintDTO = service.GetPaintByID(id);
                paintVM = new PaintViewModel(paintDTO);
            }

            return View(paintVM);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Paints = LoadDataUtilities.LoadPaintsData();

            PaintViewModel paintVM = new PaintViewModel();
            using (PaintService.PaintClient service = new PaintService.PaintClient())
            {
                var paintDTO = service.GetPaintByID(id);
                paintVM = new PaintViewModel(paintDTO);
            }

            return View(paintVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PaintViewModel paintVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (PaintService.PaintClient service = new PaintService.PaintClient())
                    {
                        PaintDTO paintDTO = new PaintDTO
                        {
                            Id = paintVM.Id,
                            Brand= paintVM.Brand,
                            ExpiryDate= paintVM.ExpiryDate,
                            IsAvailable= paintVM.IsAvailable,
                            PaintType= paintVM.PaintType,
                            Price= paintVM.Price,
                            Quantity= paintVM.Quantity
                        };
                        service.DeletePaint(paintDTO.Id);
                        service.PostPaint(paintDTO);
                    }

                    return RedirectToAction("Index");
                }
                ViewBag.Paints = LoadDataUtilities.LoadPaintsData();
                return View();
            }
            catch
            {
                ViewBag.Paints = LoadDataUtilities.LoadPaintsData();
                return View();
            }
        }

        public ActionResult Delete(int id)
        {

            using (PaintService.PaintClient service = new PaintService.PaintClient())
            {
                service.DeletePaint(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            ViewBag.Paints = LoadDataUtilities.LoadPaintsData();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaintViewModel paintVM)
        {
            try
            {
                using (PaintService.PaintClient service = new PaintService.PaintClient())
                {
                    PaintDTO paintDTO = new PaintDTO
                    {
                        Id = paintVM.Id,
                        Brand = paintVM.Brand,
                        ExpiryDate = paintVM.ExpiryDate,
                        IsAvailable = paintVM.IsAvailable,
                        PaintType = paintVM.PaintType,
                        Price = paintVM.Price,
                        Quantity = paintVM.Quantity
                    };
                    service.PostPaint(paintDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Paints = LoadDataUtilities.LoadPaintsData();
                return View();
            }
        }
    }
}