using Service;
using System.Web.Mvc;
using Unity;

namespace RuleBuilder.Controllers
{
    public class BaseController : Controller
    {
        [Dependency]
        public IListService ListService { get; set; }
    }
}