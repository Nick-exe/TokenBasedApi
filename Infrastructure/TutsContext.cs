using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenBasedApi.Infrastructure
{
    public class TutsContext : IdentityDbContext<IdentityUser>
    {
        public TutsContext(): base("tokenString")
        {

        }
    }
}