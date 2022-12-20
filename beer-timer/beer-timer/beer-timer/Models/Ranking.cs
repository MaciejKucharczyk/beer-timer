using System;
using System.Collections.Generic;

namespace beer_timer.Models
{
    public class Ranking
    {
        //public Ranking(int id, int sec, int tens, string userNameId, string technique) {
        //    this.Id= id;
        //    this.Sec = sec;
        //    this.Tens = tens;
        //    this.UserNameId = userNameId;
        //    this.Technique = technique;

        //}

        public int Id { get; set; }
        public int? Sec { get; set; }
        public int? Tens { get; set; }
        public string UserNameId { get; set; } = null!;
        public string? Technique { get; set; }
    }
}
