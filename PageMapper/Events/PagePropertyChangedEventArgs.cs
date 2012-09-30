using PageMapper.Models;
using System;

namespace PageMapper.Events
{
    public class PagePropertyChangedEventArgs : EventArgs
    {
        public WebElement SelectedElement { get; set; }

        public PagePropertyChangedEventArgs(WebElement selectedElement)
        {
            this.SelectedElement = selectedElement;
        }
    }
}