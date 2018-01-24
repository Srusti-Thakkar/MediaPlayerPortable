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

[assembly: Dependency(typeof(LoadFiles))]

namespace MediaPlayerPortable.Droid.Services
{
    public class LoadFiles : ILoadFIles
    {
        public List<string> GetFiles()
        {
            var files = new List<string>();
            var documentsPath = Android.OS.Environment.RootDirectory;
            var list = documentsPath.ListFiles();
            if (list.Count() > 0)
                foreach (var file in list)
                {
                    files.Add(file.Name);
                }
            return files;
        }
    }
}