using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace WhileStatement
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void openFileClick(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fp = new FileOpenPicker();
            fp.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            fp.ViewMode = PickerViewMode.List;
            fp.FileTypeFilter.Add("*");

            StorageFile file = await fp.PickSingleFileAsync();
            if (file != null)
            {
                fileName.Text = file.Path;

                var fileStream = await file.OpenAsync(FileAccessMode.Read);
                var inputStream = fileStream.GetInputStreamAt(0);
                TextReader reader = new StreamReader(inputStream.AsStreamForRead());
                displayData(reader);
            }
        }

        private void displayData(TextReader reader)
        {
            source.Text = "";

            //While loop version
            //string line = reader.ReadLine();
            //while (line != null)
            //{
            //    source.Text += line + '\n';
            //    line = reader.ReadLine();
            //}

            //For loop version
            for (string line = reader.ReadLine(); reader.ReadLine() != null; line = reader.ReadLine()) //Initilization, termination, update
            {
                source.Text += line + '\n'; //increments line and adds a space
            }
            reader.Dispose();
        }
    }
}
