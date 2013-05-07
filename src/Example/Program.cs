using AngrySquirrel.Netduino.NtpClient;
using Microsoft.SPOT.Hardware;

namespace Example
{
    /// <summary>
    /// Represents an example project showing how to use the <see cref="NtpClient" /> library
    /// </summary>
    public class Program
    {
        #region Public Methods and Operators

        /// <summary>
        /// Program entry point
        /// </summary>
        public static void Main()
        {
            var dateTime = NtpClient.GetDateTime();
            Utility.SetLocalTime(dateTime);
        }

        #endregion
    }
}