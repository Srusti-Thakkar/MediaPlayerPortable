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
            var list = new List<File>();

            list.Add(new File() { Name = "Song 1", Length = 2 });
            list.Add(new File() { Name = "Song 2", Length = 3 });
            list.Add(new File() { Name = "Song 3", Length = 4 });
            list.Add(new File() { Name = "Song 4", Length = 5 });

            lstSongsList.ItemsSource = list;
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

        private void btnLoad_Clicked(object sender, EventArgs e)
        {
            // var list = DependencyService.Get<ILoadFIles>().GetFiles();
        }
    }
}
