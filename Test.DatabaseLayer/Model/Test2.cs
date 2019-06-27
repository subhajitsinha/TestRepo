using System;
using System.Collections.Generic;

namespace Test.DatabaseLayer.Model
{
    public partial class Test2
    {
        public Test2()
        {
            Test4 = new HashSet<Test4>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Test4> Test4 { get; set; }
    }
}
