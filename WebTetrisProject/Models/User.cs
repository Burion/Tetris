using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;


namespace WebTetris.Models
{
    public class User : IdentityUser
    {
        private Bitmap ProflileImage1 { get; set; }
    }
}
