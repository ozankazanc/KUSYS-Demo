﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Entities.Concrete
{
    public class UserRole : IdentityUserRole<int>
    {
        public class UserLogin : IdentityUserLogin<int>
        {

        }
    }
}
