using System;
using System.Collections.Generic;

namespace beer_timer.Models
{
    public partial class Ranking
    {
        public int Id { get; set; }
        public int? Sec { get; set; }
        public int? Tens { get; set; }
        public string UserNameId { get; set; } = null!;
        public string? Technique { get; set; }
    }
}
