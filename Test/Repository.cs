using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DatabaseLayer.Model;

namespace Test
{
    public class Repository
    {
        public List<TestModel> GetAllTest2()
        {
            using (var db = new ContosoDbContext())
            {

                var res = (from test4 in db.Test4
                          join test2 in db.Test2
                        on test4.Test2Id equals test2.Id
                        into MatchedOrders
                          from mo in MatchedOrders.DefaultIfEmpty()
                          select new TestModel() {
                              Id = test4.Id,
                              NameOf = test4.NameOf,
                              Name = mo.Name
                          }).ToList();
                return res;
            }

        }
    }
}
