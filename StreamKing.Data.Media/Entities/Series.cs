﻿namespace StreamKing.Data.Media
{
    public class Series : Media
    {
        public List<Season> Seasons { get; set; }

        public DateTime? LastAirDate { get; set; }
    }
}
