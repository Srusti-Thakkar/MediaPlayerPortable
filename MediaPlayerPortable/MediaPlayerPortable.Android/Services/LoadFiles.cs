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
            List<string> filelist = new List<string>();
            var path = FileSystem.Current.LocalStorage;
            
            var files = Directory.EnumerateFiles(path.Name);
            foreach(var i in files)
            {
                filelist.Add(i);
            }
            return filelist;
        }
        
    }
}