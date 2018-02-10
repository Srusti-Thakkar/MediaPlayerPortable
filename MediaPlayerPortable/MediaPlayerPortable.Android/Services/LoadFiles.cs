using System;

using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MediaPlayerPortable.Contracts;

using System.Collections.Generic;
using MediaPlayerPortable.Droid.Services;
using Xamarin.Forms;
using Android.Provider;
using System.Threading.Tasks;
using System.IO;
using PCLStorage;

[assembly: Dependency(typeof(LoadFiles))]

namespace MediaPlayerPortable.Droid.Services
{
    public class LoadFiles : ILoadFIles
    {  

        public List<string> GetMediaFiles()
        {
            //List<string> filelist = new List<string>();
            //var path = FileSystem.Current.LocalStorage;
            
            //var files = Directory.GetFiles(path.Name);
            //foreach(var i in files)
            //{
            //    filelist.Add(i);
            //}
            //return filelist;

             List<string> filelist = new List<string>();
            var path = FileSystem.Current.LocalStorage;
            //var rootPath = path.Path.Split('0')[0] + "0/";
            var rootPath = Android.OS.Environment.RootDirectory.Path;
            // var temp = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryMusic);
            var temp = Android.OS.Environment.GetExternalStoragePublicDirectory("/");
            var files = Directory.GetFiles(temp.AbsolutePath, "*.mp3",SearchOption.AllDirectories);
            foreach (var i in files)
            {
                filelist.Add(i);
            }
            return filelist;
        }
        
    }
}