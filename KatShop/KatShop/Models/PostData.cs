using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace KatShop.Models
{
	public class PostData
	{
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyy}",ApplyFormatInEditMode =true)]
        public DateTime? CreateDate { get; set; }
    }

    [ModelMetadataType(typeof(PostData))]
    public partial class Post
    {

    }
}
