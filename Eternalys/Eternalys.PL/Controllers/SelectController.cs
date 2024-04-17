namespace Eternalys.PL.Controllers
{
    using Eternalys.BLL.Services;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class SelectController : Controller
    {
        private readonly EternalysService service;

        public SelectController()
        {
            service = new EternalysService(qwerty_12345.Credentials.ConnectionString);
        }

        public async Task<ActionResult> GetAssigments()
        {
            var lst = await service.ReadAssignmentsAsync();
            return View(lst);
        }
    }
}