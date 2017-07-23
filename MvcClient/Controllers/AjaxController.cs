using MvcClient.Models;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Linq;
using System.Xml.Linq;
using System;


namespace MvcClient.Controllers
{
    public class AjaxController : Controller
    {
        private MvcClientContext db = new MvcClientContext();
      
        public ActionResult AjaxLink()
        {
          var list = EnumHelper.GetSelectList(typeof(CategoryEnum));
          return View(list);
        }
      
        public ActionResult AjaxSearch(CategoryEnum id)	
        {
          if (Request.IsAjaxRequest()){
            var articles = db.Articles
                .Where(a => a.Category == id)
                .OrderBy(a => a.Published);
            return PartialView("_AjaxSearch", articles);
          }
          return Content("Ajax通信以外のアクセスはできません。");
        }

        public ActionResult GourmetSearch()
        {
          return View();
        }

        public ActionResult GourmetResult(string keyword)
        {
          System.Threading.Thread.Sleep(3000);
          if (Request.IsAjaxRequest()){
            var keyid = "ee8b4d2125175995e23114cd0e7138ab";
            var prefid = "PREF13";
            var doc = XElement.Load(
                String.Format("https://api.gnavi.co.jp/RestSearchAPI/20150630/?keyid={0}&name={1}&pref={2}&offset_page={3}",
                    keyid, Url.Encode(keyword), prefid, 1));

            //ViewBag.Count = Int32.Parse(doc.Element("total_hit_count").Value);
            int count = 0;
            if(doc.Element("total_hit_count") != null)
            {
                    Int32.TryParse(doc.Element("total_hit_count").Value, out count);
            }
            ViewBag.Count = count;


            return PartialView("_GourmetResult", from r in doc.Elements("rest")
            //return Json(from r in doc.Elements("rest")

                select new Restaurant()
                {
                    Id = r.Element("id").Value,
                    Name = r.Element("name").Value,
                    Url = r.Element("url").Value,
                    Image = r.Element("image_url").Element("qrcode").Value,
                    Pr = r.Element("pr").Element("pr_long").Value
                }
            );
          }
          return Content("Ajax通信以外のアクセスはできません。");
        }

        public ActionResult JsonAccess()
        {
          var list = EnumHelper.GetSelectList(typeof(CategoryEnum));
          return View(list);
        }

        public ActionResult BookMark()
        {
          return View();
        }

        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
    }
}