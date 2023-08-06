using EPiServer.Web;
using EpiServerAlloyDXP.Models.Pages;
using Microsoft.AspNetCore.Html;
using System.ComponentModel.DataAnnotations;

namespace EpiServerAlloyDXP.Models.ViewModels
{
    public class ContactBlockModel
    {
        [UIHint(UIHint.Image)]
        public ContentReference Image { get; set; }

        public string Heading { get; set; }

        public string LinkText { get; set; }

        public IHtmlContent LinkUrl { get; set; }

        public bool ShowLink { get; set; }

        public ContactPage ContactPage { get; set; }
    }
}