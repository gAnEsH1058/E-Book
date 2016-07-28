using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;

namespace E_Book.Models.Pages
{
    [ContentType(DisplayName = "Book", GUID = "3ed61ec7-d41a-440f-a788-7a56d071f296", Description = "")]
    public class Book : PageData
    {
        [BackingType(typeof(PropertyString))]
        [CultureSpecific]
        [Display(
            Name = "Name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string BookName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Author Name",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Author { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Description",
          GroupName = SystemTabNames.Content,
          Order = 30)]
        public virtual XhtmlString Description { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Book Price",
          GroupName = SystemTabNames.Content,
          Order = 40)]
        public virtual Double Price { get; set; }


        [CultureSpecific]
        [Display(
          Name = "Image",
          GroupName = SystemTabNames.Content,
          Order = 50)]
        public virtual Url Image { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Published",
          GroupName = SystemTabNames.Content,
          Order = 60)]
        public virtual string Published { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Bookurl",
         GroupName = SystemTabNames.Content,
         Order = 70)]
        public virtual Url Bookurl { get; set; }
    }
}