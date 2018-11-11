using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Swagger.Data.DomainModels
{
    public class Account
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }
    }
}
