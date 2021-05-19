using System;
using System.Collections.Generic;
using System.Text;

namespace SakontyRAT.Network
{
    public class SakontyMessage
    {
        public byte[] Data { get; set; }
        public Dictionary<object, object> MetaData { get; set; }
    }
}