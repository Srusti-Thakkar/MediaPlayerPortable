using MediaPlayerPortable.Contracts;
using MediaPlayerPortable.Entities;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MediaPlayerPortable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async Task<bool> LoadFiles()
        {
            List<File> fileList = new List<File>();
            var flag = false;

            var list = FileSystem.Current.LocalStorage;
            var files = await list.GetFilesAsync();
            foreach (var file in files)
            {
                var a = new File();
                a.Name = file.Name;

                fileList.Add(a);
            }
            lstSongsList.ItemsSource = fileList;
            return flag;
        }

        private async void btnLoad_ClickedAsync(object sender, EventArgs e)
        {
            //var list = DependencyService.Get<ILoadFIles>().GetFiles();
            //List<File> fileList = new List<File>();
            //foreach(var i in list)
            //{
            //    fileList.Add(new File()
            //    {
            //        Name = i
            //    });
            //}
            //lstSongsList.ItemsSource = fileList;

            var data = await LoadFiles();
        }

        
    }
}
