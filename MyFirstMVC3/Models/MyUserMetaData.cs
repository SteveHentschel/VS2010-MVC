using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MyFirstMVC3.Models
{
    [MetadataType(typeof(MyUserMetaData))]
    public partial class MyUser
    {
        public class MyUserMetaData
        {
            [StringLength(50), Required]
            public object Name { get; set; }
            [StringLength(30), Required]
            public object Country { get; set; }
            [StringLength(6)]
            public object Email { get; set; }
            [Range(0, 10)]
            public object Rating { get; set; }
        }
    }
}