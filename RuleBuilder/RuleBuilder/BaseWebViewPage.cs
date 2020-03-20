using RuleBuilder.Controllers;
using Service;
using System.Web.Mvc;

namespace RuleBuilder
{
    public abstract class BaseWebViewPage : WebViewPage
    {
        public IListService ListService { get; set; }

        public override void InitHelpers()
        {
            base.InitHelpers();

            var controller = (ViewContext.Controller as BaseController);

            ListService = controller.ListService;
        }
    }

    public abstract class BaseWebViewPage<TModel> : WebViewPage<TModel>
    {
        public IListService ListService { get; set; }

        public override void InitHelpers()
        {
            base.InitHelpers();

            var controller = (ViewContext.Controller as BaseController);
            ListService = controller.ListService;
        }
    }
}