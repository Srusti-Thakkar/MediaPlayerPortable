using PCLStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MediaPlayerPortable
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //LocalStorageService localStorageservice = new LocalStorageService();
            //localStorageservice.loadSettings().Wait();
            MainPage = new MediaPlayerPortable.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    public class LocalStorageService
    {
        public async Task loadSettings()
        {
            // load file
            try
            {
                //open root folder
                IFolder rootFolder = FileSystem.Current.LocalStorage;
                //open folder if exists

                IFolder folder = await rootFolder.CreateFolderAsync("MySubFolder", CreationCollisionOption.OpenIfExists);
                //open file if exists
                IFile file = await folder.GetFileAsync("MyFile1.txt");
                using (System.IO.Stream stream = await file.OpenAsync(FileAccess.ReadAndWrite))
                {
                    long length = stream.Length;
                    BackgroundModel.Image = new byte[length];
                    stream.Read(BackgroundModel.Image, 0, (int)length);
                }
            }
            catch
            {
            }

        }
    }
    public static class BackgroundModel
    {
        static BackgroundModel()
        {

        }
        public static byte[] Image { get; set; }
    }
}
