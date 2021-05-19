using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SakontyRAT.Server.Models
{
    public class DirectoryNode
    {
        public DirectoryNode(DirectoryInfo directoryInfo)
        {
            DirectoryInfo = directoryInfo;
        }

        public DirectoryInfo DirectoryInfo { get; private set; }
        public string Key { get => DirectoryInfo.FullName; }
        public string ParentKey { get => DirectoryInfo.Parent.FullName; }
        public string Name { get => DirectoryInfo.Name; }
    }
}