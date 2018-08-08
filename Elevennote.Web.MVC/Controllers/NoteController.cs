using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elevennote.Web.MVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {

            var service = CreateNoteService();
            var model = service.GetNotes();

            return View(model);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateNoteService();

            service.CreateNote(model);

            return RedirectToAction("Index", "Note");

        }

        private NoteService CreateNoteService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            return service;
        }

    }
}