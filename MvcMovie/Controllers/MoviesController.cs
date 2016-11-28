using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
	{

		private MovieDBContext db = new MovieDBContext();

		//Get: /Movies/
        public ActionResult Index()
        {
			return View (db.Movies.ToList());
        }

		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
			}

			Movie movie = db.Movies.Find(id);

			if (movie == null)
			{
				return HttpNotFound();
			}

			return View(movie);
		}

    }
}
