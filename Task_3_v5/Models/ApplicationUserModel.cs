using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections;

namespace Task_3_v5.Models
{
    [AllowAnonymous]
    public class ApplicationUserModel
    {
        public String UserId { get; set; }
    }
}
