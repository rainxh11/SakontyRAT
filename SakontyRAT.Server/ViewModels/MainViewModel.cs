using DevExpress.Mvvm;
using SakontyRAT.Server.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SakontyRAT.Server.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Nodes = Helpers.NodeHelper.GetFolderNodes(@"D:\PROJECTS");
        }

        private IList<DirectoryNode> _Nodes;

        public IList<DirectoryNode> Nodes
        {
            get { return _Nodes; }
            set { _Nodes = value; }
        }
    }
}