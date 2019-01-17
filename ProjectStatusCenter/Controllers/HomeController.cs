using ProjectStatusCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectStatusCenter.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            DateTime current = DateTime.Now;
            TrackerProjectList model = new TrackerProjectList();
            model.SelectedStartYear = current.Year - 1;
            model.SelectedEndYear = current.Year + 1;

            using (var db = new TrackerDBContext())
            {
                // Display all Tracker projects from the database
                var query = from b in db.TBLs
                            select b;

                System.Diagnostics.Debug.WriteLine("All Tracker projects in the database:");
                model.tBLs = new List<TBL>();

                foreach (var item in query)
                {
                    System.Diagnostics.Debug.WriteLine(item.Application + ":" + item.Description);

                    var mod = new TBL();
                    mod.Application = item.Application;
                    mod.Description = item.Description;
                    mod.BusinessBeginString = ((DateTime)item.BusinessBeginCycle).ToShortDateString();
                    mod.BusinessEndString = ((DateTime)item.BusinessEndCycle).ToShortDateString();
                    mod.BusinessContact = item.BusinessContact;
                    mod.DevBeginCycle = item.DevBeginCycle;
                    mod.DevEndCycle = item.DevEndCycle;
                    mod.Developer = item.Developer;

                    model.tBLs.Add(mod);
                }
            }

            return View(model);
        }


        public ActionResult Index3()
        {
            DateTime current = DateTime.Now;
            TrackerProjectList model = new TrackerProjectList();
            model.SelectedStartYear = current.Year - 1;
            model.SelectedEndYear = current.Year + 1;
            List<SelectListItem> startItems = new List<SelectListItem>();
            List<SelectListItem> endItems = new List<SelectListItem>();

            Console.Write("starting year dropdowns on server...");

            for (var i = 2000; i < model.SelectedEndYear; i++)
            {
                SelectListItem listItem = new SelectListItem { Value = i.ToString(), Text = i.ToString() };
                startItems.Add(listItem);
            }
            for (var i = 2000; i <= model.SelectedEndYear; i++)
            {
                SelectListItem listItem = new SelectListItem { Value = i.ToString(), Text = i.ToString() };
                endItems.Add(listItem);
            }
            model.StartYear = startItems;
            model.EndYear = endItems;
            Console.Write("dropdowns complete...");

            Console.Write("starting db access...");
            using (var db = new TrackerDBContext())
            {

                // Display all Tracker projects from the database
                //var query = (from b in db.TBLs
                // select b).Where(b => b.ID == 6);
                var query = from b in db.TBLs
                            select b;

                System.Diagnostics.Debug.WriteLine("All Tracker projects in the database:");
                model.tBLs = new List<TBL>();

                foreach (var item in query)
                {
                    System.Diagnostics.Debug.WriteLine(item.Application + ":" + item.Description);

                    var mod = new TBL();
                    mod.Application = item.Application;
                    mod.Description = item.Description;
                    mod.BusinessBeginString = ((DateTime) item.BusinessBeginCycle).ToShortDateString();
                    mod.BusinessEndString = ((DateTime) item.BusinessEndCycle).ToShortDateString();
                    mod.BusinessContact = item.BusinessContact;
                    mod.DevBeginCycle = item.DevBeginCycle;
                    mod.DevEndCycle = item.DevEndCycle;
                    mod.Developer = item.Developer;

                    model.tBLs.Add(mod);
                }
            }


            return View(model);
        }


        public ActionResult Index4() 
        {
            DateTime current = DateTime.Now;
            TrackerProjectList model = new TrackerProjectList();
            model.SelectedStartYear = current.Year - 1;
            model.SelectedEndYear = current.Year + 1;
            List<SelectListItem> startItems = new List<SelectListItem>();
            List<SelectListItem> endItems = new List<SelectListItem>();

            Console.Write("starting year dropdowns on server...");

            for (var i = 2000; i < model.SelectedEndYear; i++)
            {
                SelectListItem listItem = new SelectListItem { Value = i.ToString(), Text = i.ToString() };
                startItems.Add(listItem);
            }
            for (var i = 2000; i <= model.SelectedEndYear; i++)
            {
                SelectListItem listItem = new SelectListItem { Value = i.ToString(), Text = i.ToString() };
                endItems.Add(listItem);
            }
            model.StartYear = startItems;
            model.EndYear = endItems;
            Console.Write("dropdowns complete...");

            Console.Write("starting db access...");
            using (var db = new TrackerDBContext())
            {

                // Display all Tracker projects from the database
                //var query = (from b in db.TBLs
                // select b).Where(b => b.ID == 6);
                var query = from b in db.TBLs
                            select b;

                System.Diagnostics.Debug.WriteLine("All Tracker projects in the database:");
                model.tBLs = new List<TBL>();

                foreach (var item in query)
                {
                    System.Diagnostics.Debug.WriteLine(item.Application + ":" + item.Description);

                    var mod = new TBL();
                    mod.Application = item.Application;
                    mod.Description = item.Description;
                    mod.BusinessBeginString = ((DateTime)item.BusinessBeginCycle).ToShortDateString();
                    mod.BusinessEndString = ((DateTime)item.BusinessEndCycle).ToShortDateString();
                    mod.BusinessContact = item.BusinessContact;
                    mod.DevBeginCycle = item.DevBeginCycle;
                    mod.DevEndCycle = item.DevEndCycle;
                    mod.Developer = item.Developer;

                    model.tBLs.Add(mod);
                }
            }


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a tool for managing Projects status within DOM IT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}