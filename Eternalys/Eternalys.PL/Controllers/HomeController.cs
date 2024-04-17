namespace Eternalys.PL.Controllers
{
    using Eternalys.BLL.Dal;
    using System.Web.Mvc;
    using BLL.Interfaces;
    using BLL.Services;
    using System.IO;
    using System.Web;
    using System;

    public class HomeController : Controller
    {
        public static bool isError = false;
        private readonly EternalysService service;

        public static bool IsError { get => isError; set => isError = value; }

        public EternalysService Service => service;

        public HomeController()
        {
            service = new EternalysService(qwerty_12345.Credentials.ConnectionString);
        }

        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult About()
        {

            return View();
        }

        [HttpPost]
        public ActionResult About(AssignmentDto assignment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    assignment.Attachment = Attachment_Path;
                    service.Insert(assignment);                    
                    return RedirectToAction("Index");
                }
                catch
                {
                    isError = true;
                    ViewBag.LogErrorMsg = "Something went wrong...Try to debug and find solution!";
                }
            }
            return View();
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryDto categ)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Insert(categ);
                    return RedirectToAction("Index");
                }
                catch
                {
                    isError = true;
                    ViewBag.LogErrorMsg = "Something went wrong...Try to debug and find solution!";
                }
            }
            return View();
        }

        #region Auxiliary Methods:
        #region Upload any File to Assignment[Post]:
        private static string path;
        private static string Attachment_Path { get; set; } = string.Empty;
        [HttpPost]
        public ActionResult UploadFile()
        {
            if (Request.Files.Count > 0)
            {
                try
                {
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        HttpPostedFileBase file = files[i];
                        string fname;

                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            Attachment_Path = fname = testfiles[testfiles.Length - 1];
                        }
                        else fname = Attachment_Path = file.FileName;

                        path = Path.Combine(Server.MapPath($"~/Images/Attachments/{fname}"));
                        file.SaveAs(path);
                    }

                    return Json("Upload!");
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else return Json("U should to upload image!");
        }
        #endregion
        #endregion
    }
}