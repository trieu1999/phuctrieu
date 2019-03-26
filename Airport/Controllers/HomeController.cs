using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airport.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var br = new Flight_info()
			{
				Name = "Danang",
				Status = "Online",
				Url = "abc.com"
			};
			using (var db = new ApplicationDbContext())
			{
				db.Flight_Infos.Add(br);
				db.SaveChanges();
			}
			using (var db = new ApplicationDbContext())
			{
			var flight_Info = (from c in db.Flight_Infos
				  select c).First();
			}

			var tr = new Home()
			{
				Name = "Danang",
				Status = "Online",
				Url = "abc.com"
			};
			using (var db = new ApplicationDbContext())
			{
				db.Homes.Add(tr);
				db.SaveChanges();
			}
			using (var db = new ApplicationDbContext())
			{
				var home = (from c in db.Homes
							   select c).First();
			}

			//Day du lieu vao
			var ck = new Checkin()
			{
				Name = "Danang",
				Status = "Online",
				Url = "abc.com"
			};
			using (var db = new ApplicationDbContext())
			{
				db.Checkins.Add(ck);
				db.SaveChanges();
			}

			//Lay du lieu ra
			using (var db = new ApplicationDbContext())
			{
				var checkin = (from c in db.Checkins
						  select c).First();
			}
			//Day du lieu vao
			var dd = new Manage_booking()
			{
				Name = "Danang",
				Status = "Online",
				Url = "abc.com"
			};
			using (var db = new ApplicationDbContext())
			{
				db.Manage_Bookings.Add(dd);
				db.SaveChanges();
			}

			//Lay du lieu ra
			using (var db = new ApplicationDbContext())
			{
				var manage_Booking = (from c in db.Manage_Bookings
						  select c).First();
			}
			//Day du lieu vao
			var bb = new Pre_Paidbagge()
			{
				Name = "Danang",
				Status = "Online",
				Url = "abc.com"
			};
			using (var db = new ApplicationDbContext())
			{
				db.Pre_Paidbagges.Add(bb);
				db.SaveChanges();
			}

			//Lay du lieu ra
			using (var db = new ApplicationDbContext())
			{
				var pre_Paidbagge = (from c in db.Pre_Paidbagges
									  select c).First();
			}


			return View();
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