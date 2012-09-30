using PageMapper.Models;
using System;

namespace PageMapper.Events
{
    public class UrlChangedEventArgs : EventArgs
    {
        public Uri Url { get; set; }

        public UrlChangedEventArgs(Uri url)
        {
            this.Url = url;
        }
    }
}