using PageMapper.Models;

namespace PageMapper.Extensions
{
    public static class PagePropertyExtensions
    {
        public static bool IsValid(this PageProperty pageProperty)
        {
            return !string.IsNullOrEmpty(pageProperty.Name)
                && !string.IsNullOrEmpty(pageProperty.Locator)
                && !string.IsNullOrEmpty(pageProperty.LocatorType);
        }
    }
}