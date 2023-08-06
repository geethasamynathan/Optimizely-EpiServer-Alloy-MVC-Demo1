using EPiServer.ServiceLocation;
using EpiServerAlloyDXP.Business.Rendering;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EpiServerAlloyDXP.Views
{
    public abstract class AlloyPageBase<TModel> : RazorPage<TModel> where TModel : class
    {
        private readonly AlloyContentAreaItemRenderer _alloyContentAreaItemRenderer;

        public abstract override Task ExecuteAsync();

        public AlloyPageBase() : this(ServiceLocator.Current.GetInstance<AlloyContentAreaItemRenderer>())
        {
        }

        public AlloyPageBase(AlloyContentAreaItemRenderer alloyContentAreaItemRenderer)
        {
            _alloyContentAreaItemRenderer = alloyContentAreaItemRenderer;
        }

        protected void OnItemRendered(ContentAreaItem contentAreaItem, TagHelperContext context, TagHelperOutput output)
        {
            _alloyContentAreaItemRenderer.RenderContentAreaItemCss(contentAreaItem, context, output);
        }
    }
}