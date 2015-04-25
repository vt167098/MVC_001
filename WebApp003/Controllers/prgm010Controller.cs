using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp003.Models;

namespace WebApp003.Controllers
{
    public class prgm010Controller : Controller
    {
        private GFCDBEntities db = new GFCDBEntities();

        // GET: prgm010
        public ActionResult Index()
        {
            return View(db.prgm010.ToList());
        }

        // GET: prgm010/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prgm010 prgm010 = db.prgm010.Find(id);
            if (prgm010 == null)
            {
                return HttpNotFound();
            }
            return View(prgm010);
        }

        // GET: prgm010/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: prgm010/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "prg_no,prg_name,exec_file,menu_prg,remark,create_id,create_date,update_id,update_date,log_code")] prgm010 prgm010)
        {
            if (ModelState.IsValid)
            {
                db.prgm010.Add(prgm010);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prgm010);
        }

        // GET: prgm010/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prgm010 prgm010 = db.prgm010.Find(id);
            if (prgm010 == null)
            {
                return HttpNotFound();
            }
            return View(prgm010);
        }

        // POST: prgm010/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "prg_no,prg_name,exec_file,menu_prg,remark,create_id,create_date,update_id,update_date,log_code")] prgm010 prgm010)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prgm010).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prgm010);
        }

        // GET: prgm010/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prgm010 prgm010 = db.prgm010.Find(id);
            if (prgm010 == null)
            {
                return HttpNotFound();
            }
            return View(prgm010);
        }

        // POST: prgm010/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            prgm010 prgm010 = db.prgm010.Find(id);
            db.prgm010.Remove(prgm010);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
