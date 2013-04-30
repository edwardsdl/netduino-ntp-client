namespace AngrySquirrel.Netduino.NtpClient
{
    /// <summary>
    /// Represents a response from a time server given in the NTP timestamp format
    /// </summary>
    public class NtpResponse
    {
        #region Constructors and Destructors

        /// <summary>
        /// </summary>
        /// <param name="seconds">
        /// </param>
        /// <param name="fraction">
        /// </param>
        public NtpResponse(int seconds, int fraction)
        {
            Seconds = seconds;
            Fraction = fraction;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the fraction of a second that has elapsed after the time given by <see cref="Seconds" />
        /// </summary>
        public int Fraction { get; private set; }

        /// <summary>
        /// Gets the number of seconds that have elapsed since January 1, 1900
        /// </summary>
        public int Seconds { get; private set; }

        #endregion
    }
}