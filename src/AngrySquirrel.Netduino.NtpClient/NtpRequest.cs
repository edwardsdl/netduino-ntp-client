using System;

namespace AngrySquirrel.Netduino.NtpClient
{
    /// <summary>
    /// </summary>
    public class NtpRequest
    {
        #region Constructors and Destructors

        /// <summary>
        /// </summary>
        public NtpRequest()
        {
            LeapIndicator = LeapIndicator.NoWarning;
            Mode = Mode.Client;
            VersionNumber = 4;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// </summary>
        public LeapIndicator LeapIndicator { get; set; }

        /// <summary>
        /// </summary>
        public Mode Mode { get; set; }

        /// <summary>
        /// </summary>
        public int Poll { get; set; }

        /// <summary>
        /// </summary>
        public int Precision { get; set; }

        /// <summary>
        /// </summary>
        public int ReferenceId { get; set; }

        /// <summary>
        /// </summary>
        public DateTime ReferenceTimestamp { get; set; }

        /// <summary>
        /// </summary>
        public int RootDelay { get; set; }

        /// <summary>
        /// </summary>
        public int RootDispersion { get; set; }

        /// <summary>
        /// </summary>
        public Stratum Stratum { get; set; }

        /// <summary>
        /// </summary>
        public DateTime TransmitTimestamp { get; set; }

        /// <summary>
        /// </summary>
        public int VersionNumber { get; set; }

        #endregion

        #region Methods

        internal byte[] ToByteArray()
        {
            return new[]
                {
                    (byte)((int)LeapIndicator | VersionNumber >> 2 | (int)Mode >> 5 | (int)Stratum | Poll | Precision), 
                };
        }

        #endregion
    }
}