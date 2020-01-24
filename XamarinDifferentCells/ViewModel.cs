using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDifferentCells.Models;

namespace XamarinDifferentCells
{
    public class ViewModel : BindableObject, INotifyPropertyChanged
    {
        public ObservableCollection<CellType> CellCollection { get; private set; } = new ObservableCollection<CellType>();
        public ICommand ButtonOneCommand { get; private set; } 
        public ICommand ButtonTwoCommand { get; private set; }
        LabelViewModel label = new LabelViewModel(Text: "This is a label");

        public ViewModel() {
            ButtonOneCommand = new Command(ButtonOneCommandMethod);
            ButtonTwoCommand = new Command(ButtonTwoCommandMethod);
            ImageViewModel image = new ImageViewModel(UrlString: "https://cdn.pixabay.com/photo/2016/11/29/03/28/animal-1867062_960_720.jpg");
            ButtonViewModel button = new ButtonViewModel(Title: "This is a button", Command: ButtonOneCommand);
            ButtonViewModel button2 = new ButtonViewModel(Title: "This is another button", Command: ButtonTwoCommand);
            SwitchViewModel switchModel = new SwitchViewModel();

            CellCollection.Add(image);
            CellCollection.Add(button);
            CellCollection.Add(label);
            CellCollection.Add(button2);
            CellCollection.Add(switchModel);
            OnPropertyChanged("CellCollection");
        }

        private void ButtonOneCommandMethod(object obj)
        {
            System.Console.WriteLine("This is from button 1");
            label.setTitle("Button 1 Pressed");
        }

        private void ButtonTwoCommandMethod(object obj)
        {
            System.Console.WriteLine("This is from button 2");
            label.setTitle("Button 2 Pressed");
        }

    }
}



