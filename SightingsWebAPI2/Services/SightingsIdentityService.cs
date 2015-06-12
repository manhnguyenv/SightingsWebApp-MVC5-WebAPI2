using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SightingsWebAPI2.Services
{
    public class SightingsIdentityService : ISightingsIdentityService
    {
        public string CurrentUser
        {
            get { return "glenndewysockie"; }
        }
    }
}