using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace dotnet_app.Models
{
    public class CodeFirstContext: DbContext
    {
        public Dbset<UserModel> UserModel { get; set; }
    }
}