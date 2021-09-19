using System;

namespace crossovokeliteMVC.Models
{
    public static class EagletExtensions
    {
        public static string FriendlyTimestamp(this Eaglet eaglet)
        {
            var now = DateTime.Now;
            var date = eaglet.DateCreated;
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