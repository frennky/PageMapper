using System.Collections.Generic;

namespace PageMapper.Models
{
    public class PageObject
    {
        public string ClassName { get; set; }
        public string Url { get; set; }
        public IList<PageProperty> Properties { get; set; }
    }
}