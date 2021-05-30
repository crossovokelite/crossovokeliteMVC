using System;

namespace crossovokeliteMVC.Models
{
    public static class RcrdExtensions
    {
        public static string FriendlyTimestamp(this Rcrd rcrd)
        {
            var now = DateTime.Now;
            var date = rcrd.DateCreated;
            var span = now - date;

            if (span > TimeSpan.FromHours(24))
            {
                return date.ToString("MMM dd");
            }

            if (span > TimeSpan.FromMinutes(60))
            {
                return string.Format("{0}h", span.Hours);
            }

            if (span > TimeSpan.FromSeconds(60))
            {
                return string.Format("{0}m", span.Minutes);
            }

            return "now";

        }
    }
}