using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.GraphQL
{
    public class CollegeSchema :Schema
    {
        public CollegeSchema(IServiceProvider resolver): base(resolver)

        {
            Query = (IObjectGraphType)resolver.GetService(typeof(CollegeQuery));
        }       
    }
}
