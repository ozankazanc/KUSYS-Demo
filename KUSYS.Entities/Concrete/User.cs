using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Entities.Concrete
{
    public class User : IdentityUser<int>
    {
        public List<Person> Persons { get; set; }
    }
}
