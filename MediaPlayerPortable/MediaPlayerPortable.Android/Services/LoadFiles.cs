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
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace MediaPlayerPortable.Droid.Services
{
    public class LoadFiles:ILoadFIles
    {
        public List<string> GetFiles()
        {
            var files = new List<string>();
            var documentsPath = Android.OS.Environment.RootDirectory;

            var list = documentsPath.ListFiles(); 
            
            foreach(var file in list)
            {
                files.Add(file.Name);
            }
            return files;   
        }
    }
}