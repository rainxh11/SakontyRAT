using System;
using System.Collections.Generic;
using System.Text;

namespace SakontyRAT.Network
{
    public interface ISakontyPeer
    {
        bool Running { get; }

        void AddRequestHandler(IRequestHandler requestHandler);

        void Start();

        void Stop();
    }
}