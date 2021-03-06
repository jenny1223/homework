﻿using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework.Controllers
{
    public class HomeController : Controller
    {
        Show db = new Show();
        public ActionResult aaa()
        {
            return View();
        }
        public ActionResult Index()
        {
            //Random rnd = new Random();
            //var model = new List<MyClass>();

            //var Data = db.AccountBook.ToList();
            //foreach (var Item in Data)
            //{
            //    MyClass x = new MyClass()
            //    {
            //        Money = Item.Amounttt,
            //        Time = Item.Dateee
            //    };
            //    if (Item.Categoryyy == 0)
            //    {
            //        x.Type = "收入";
            //    }
            //    else
            //    {
            //        x.Type = "支出";
            //    }
            //    model.Add(x);
            //}

            return View();
            
            //MyClass note;
            //for (int i = 0; i < 200; i++)
            //{
            //    note = new MyClass();
            //    int rand = rnd.Next(2);
            //    if (rand == 1)
            //        note.Type = "支出";
            //    else
            //        note.Type = "收入";
            //    note.Time = DateTime.Now.AddDays(rnd.Next(3650));
            //    note.Money = rnd.Next(10000);
            //    model.Add(note);
            //}


            //var model = new List<homework.Models.MyClass>();
            //{
            //     Random str = new Random();
            //     string[] type = { "收入", "支出" };
            //     int s = str.Next(type.Length);
            //    str.Type= "收入",
            //    Time= DateTime.Now,
            //    Money = 500
            //};
        }
        //[HttpPost]
        //public ActionResult Index(MyClass Data)
        //{
        //    Show DB = new Show();
        //    AccountBook table = new AccountBook()
        //    {
        //        Amounttt = Data.Money,
        //        Categoryyy = Data.Type == "收入" ? 0 : 1,
        //        Dateee = Data.Time
        //    };
        //    DB.AccountBook.Add(table);
        //    DB.SaveChanges();
        //    return View(Data);
        //}
        public ActionResult ChildAction()
        {
            var model = new List<MyClass>();

            var Data = db.AccountBook.ToList();
            foreach (var Item in Data)
            {
                MyClass x = new MyClass()
                {
                    Money = Item.Amounttt,
                    Time = Item.Dateee
                };
                if (Item.Categoryyy == 0)
                {
                    x.Type = "收入";
                }
                else
                {
                    x.Type = "支出";
                }
                model.Add(x);
            }

            return View(model);
        }
        
        [HttpPost]
        public ActionResult Index(AccountBook data)
        {
            if (ModelState.IsValid)
            {
                data.Id = Guid.NewGuid();
                db.AccountBook.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}