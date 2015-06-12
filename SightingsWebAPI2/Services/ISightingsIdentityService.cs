using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SightingsWebAPI2.Services
{
    public interface ISightingsIdentityService
    {
        string CurrentUser { get; }
    }
}
