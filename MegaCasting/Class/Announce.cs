using System;
using System.Collections.Generic;

namespace MegaCasting.Class
{
    public partial class Announce
    {
        public int ID { get; set; }
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
