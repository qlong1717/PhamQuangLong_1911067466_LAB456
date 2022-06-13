using PhamQuangLong_1911067466_LAB456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhamQuangLong_1911067466_LAB456.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}