using System;
namespace XamarinDifferentCells
{
    public class LabelViewModel : CellType
    {
        public string Text { get; set; }

        public LabelViewModel(string Text)
        {
            this.Text = Text;
        }

        public void setTitle(string Text)
        {
            this.Text = Text;
            OnPropertyChanged("Text");
        }

    }
}
