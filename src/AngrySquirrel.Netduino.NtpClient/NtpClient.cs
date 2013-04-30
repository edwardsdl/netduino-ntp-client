using System;
using System.Net;
using System.Net.Sockets;

namespace AngrySquirrel.Netduino.NtpClient
{
    /// <summary>
    /// Represents a client used to connect to a network time server
    /// </summary>
    public static class NtpClient
    {
        #region Public Methods and Operators

        /// <summary>
        /// Gets the current date and time
        /// </summary>
        /// <returns>
        /// The current date and time
        /// </returns>
        public static DateTime GetDateTime()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the current date and time using the given <see cref="NtpRequest"/>
        /// </summary>
        /// <param name="ntpRequest">
        /// The <see cref="NtpRequest"/> object to use when querying the network time server
        /// </param>
        /// <param name="host">
        /// </param>
        /// <param name="port">
        /// </param>
        /// <returns>
        /// The current date and time
        /// </returns>
        public static DateTime GetDateTime(NtpRequest ntpRequest, string host = "time.windows.com", int port = 123)
        {
            var hostEntry = Dns.GetHostEntry(host);
            foreach (var address in hostEntry.AddressList)
            {
                if (address == null)
                {
                    continue;
                }

                var ipEndPoint = new IPEndPoint(address, port);

                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Connect(ipEndPoint);
                    socket.Send(ntpRequest.ToByteArray());
                }
                finally
                {
                    socket.Close();
                }
            }

            return DateTime.Now;
        }

        #endregion
    }
}