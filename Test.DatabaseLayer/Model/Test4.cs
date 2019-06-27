using System;
using System.Collections.Generic;

namespace Test.DatabaseLayer.Model
{
    public partial class Test4
    {
        public int Id { get; set; }
        public string NameOf { get; set; }
        public int? Test2Id { get; set; }

        public virtual Test2 Test2 { get; set; }
    }
}
