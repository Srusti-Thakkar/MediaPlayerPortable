using MediaPlayerPortable.Contracts;
using MediaPlayerPortable.Entities;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.FilePicker;

namespace MediaPlayerPortable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

       

        private void btnLoad_ClickedAsync(object sender, EventArgs e)
        {
            var list = DependencyService.Get<ILoadFIles>().GetMediaFiles();
            List<File> fileList = new List<File>();
            foreach (var i in list)
            {
                fileList.Add(new File()
                {
                    Name = i
                });
            }
            lstSongsList.ItemsSource = fileList;

        }

        
    }
}
