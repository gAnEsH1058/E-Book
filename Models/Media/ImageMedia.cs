using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace E_Book.Models.Media
{
    [ContentType(DisplayName = "ImageMedia", GUID = "a7032662-173b-4edd-addc-a5b7edf3c473", Description = "")]
    [MediaDescriptor(ExtensionString = "jpeg,jpg,png")]
    public class ImageMedia : ImageData
    {
        /*
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Description { get; set; }
         */
    }
}