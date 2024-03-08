using System.Diagnostics;
using System.IO;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFiles()
        {
            var resp = new ResponseApi() { success = false };
            Debug.WriteLine($"{nameof(UploadFiles)}");

            if (Request != null && Request.Files != null && Request.Files.Count > 0)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase postedFile = Request.Files[i];
                    string path = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    postedFile.SaveAs(path + Path.GetFileName(postedFile.FileName));
                    TempData["Message"] = "File uploaded successfully.";
                }
                resp.success = true;
            }

            return Json(resp, JsonRequestBehavior.AllowGet);
        }
    }
}