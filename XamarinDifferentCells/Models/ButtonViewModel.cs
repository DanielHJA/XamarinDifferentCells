using System;
using System.Windows.Input;

namespace XamarinDifferentCells
{
    public class ButtonViewModel : CellType
    {
        public string Title { get; set; }
        public ICommand Command { get; set; }

        public ButtonViewModel(string Title, ICommand Command)
        {
            this.Title = Title;
            this.Command = Command;
        }
    }
}
