using System;
using Xamarin.Forms;
using XamarinDifferentCells.Models;

namespace XamarinDifferentCells
{
    public class MyDataTemplateSelector: DataTemplateSelector
    {

        public DataTemplate ButtonTemplate { get; set; }
        public DataTemplate LabelTemplate { get; set; }
        public DataTemplate ImageTemplate { get; set; }
        public DataTemplate SwitchTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            if (item is ButtonViewModel)
            {
                return ButtonTemplate;
            }

            if (item is LabelViewModel)
            {
                return LabelTemplate;
            }

            if (item is ImageViewModel)
            {
                return ImageTemplate;
            }

            if (item is SwitchViewModel)
            {
                return SwitchTemplate;
            }

            return null;
        }

    }
}
