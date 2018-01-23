using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = MediaPlayerPortable.Entities;

namespace MediaPlayerPortable.Contracts
{
    public interface ILoadFIles
    {
        List<string> GetFiles();
    }
}
