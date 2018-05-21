﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentskiDom.Data.EF;
using StudentskiDom.Data.Models;
using StudentskiDom.Web.Helper;

namespace StudentskiDom.Web.Areas.RecepcionerModul.Controllers
{
	[Area("RecepcionerModul")]
	public class HomeController : Controller
    {

		private readonly MojContext _context;

		public HomeController(MojContext db)
		{
			_context = db;
		}

		public IActionResult Index()
        {
			KorisnickiNalog korisnik = HttpContext.GetLogiraniKorisnik();
			Zaposlenik z = _context.Zaposlenici.Where(x => x.Id == korisnik.Id).FirstOrDefault();
			if (korisnik==null || z==null || z._VrstaZaposlenikaId!=1)
			{
				TempData["error_poruka"] = "Nemate pravo pristupa!";
				return Redirect("/Autentifikacija/Index");
			}
            return View();
        }
    }
}