using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpSMS9.Models.Pages
{
    [ContentType]
    public class StartPage: PageData
    {
        [Display(Name = "Heading", Order = 1)]
        public virtual string Heading { get; set; }
        [Display(Name = "Sub Heading", Order = 2)]
        public virtual string SubHeading { get; set; }       
        [Display(Name = "Banner Image", Order = 3)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BannerImage { get; set; }
        [Display(Name = "Page Content", Order = 4)]
        public virtual XhtmlString MainBody { get; set; }
    }
}