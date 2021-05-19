using System;
using System.Collections.Generic;
using System.Text;
using WatsonTcp;

namespace SakontyRAT.Network
{
    public class InvalidRequestHandler : IRequestHandler
    {
        private const string Name = "InvalidRequest";

        public string GetName()
        {
            return Name;
        }

        public void Handle(WatsonTcpClient client, SakontyMessage message)
        {
            var response = new Dictionary<object, object>();
            response.Add("Response", "Invalid");

            string invalidResponse = $"Request of type {message.MetaData["Request"] as string} is invalid.";
            var data = Encoding.UTF8.GetBytes(invalidResponse);

            client.Send(data, response);
        }
    }
}