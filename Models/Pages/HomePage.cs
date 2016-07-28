using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace E_Book.Models.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "d422a30c-8583-453c-ba61-a08206232663", Description = "")]
    public class HomePage : PageData
    {

        [CultureSpecific]
        [Searchable]
        //[Required]
        public virtual PageReference PageReference { get; set; }

        [CultureSpecific]
        [Searchable]
        public virtual ContentArea ProductBlog { get; set; }

    }
}