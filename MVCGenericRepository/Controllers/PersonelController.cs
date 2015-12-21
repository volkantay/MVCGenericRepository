using MVCGenericRepository.GenericRepository;
using MVCGenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGenericRepository.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        
            private IRepository<Personel> _repository = null;
            public PersonelController()
            {
                this._repository = new Repository<Personel>();
            }
            // GET: Personel
            public ActionResult Index()
            {
                var personeller = _repository.getAll();
                return View(personeller);
            }

            [HttpGet]
            public ActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Create(Personel personel)
            {
                if (ModelState.IsValid)
                {
                    _repository.Insert(personel);
                    _repository.Save();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(personel);
                }
            }

            public ActionResult Edit(int Id)
            {
                var personel = _repository.getById(Id);
                return View(personel);
            }
            [HttpPost]
            public ActionResult Edit(Personel personel)
            {
                if (ModelState.IsValid)
                {
                    _repository.Update(personel);
                    _repository.Save();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(personel);
                }
            }

            public ActionResult Details(int Id)
            {
                var personel = _repository.getById(Id);
                return View(personel);
            }

            public ActionResult Delete(int Id)
            {
                var personel = _repository.getById(Id);
                return View(personel);
            }

            [HttpPost, ActionName("Delete")]
            public ActionResult DeleteConfirmed(int Id)
            {
                var personel = _repository.getById(Id);
                _repository.Delete(Id);
                _repository.Save();
                return RedirectToAction("Index");
            }
        }


 }
