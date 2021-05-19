using SakontyRAT.Server.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace SakontyRAT.Server.ViewModels.Helpers
{
    public class NodeHelper
    {
        public static IList<DirectoryNode> GetFolderNodes(string path)
        {
            List<DirectoryNode> nodes = new List<DirectoryNode>();

            try
            {
                nodes = new DirectoryInfo(path)
                    .GetDirectories("*", SearchOption.AllDirectories)
                    .Select(directory => new DirectoryNode(directory))
                    .ToList();
            }
            catch
            {
            }
            return nodes;
        }
    }
}