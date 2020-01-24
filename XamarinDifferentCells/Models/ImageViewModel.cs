using System;
namespace XamarinDifferentCells
{
    public class ImageViewModel : CellType
    {
        public string UrlString { get; set; }

        public ImageViewModel(string UrlString)
        {
            this.UrlString = UrlString;
        }
    }
}
