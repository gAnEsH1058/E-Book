using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace E_Book.Models.Media
{
    [ContentType(DisplayName = "PDFMedia", GUID = "6e778577-a346-4045-93ea-63363406390a", Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class PDFMedia : MediaData
    {

        //[CultureSpecific]
        //[Editable(true)]
        //[Display(
        //    Name = "Description",
        //    Description = "Description field's description",
        //    GroupName = SystemTabNames.Content,
        //    Order = 1)]
        //public virtual string Description { get; set; }

    }
}