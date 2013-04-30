namespace AngrySquirrel.Netduino.NtpClient
{
    /// <summary>
    /// </summary>
    public enum LeapIndicator
    {
        /// <summary>
        /// </summary>
        None = -1, 

        /// <summary>
        /// </summary>
        NoWarning, 

        /// <summary>
        /// </summary>
        LastMinuteHas61Seconds, 

        /// <summary>
        /// </summary>
        LastMinuteHas59Seconds, 

        /// <summary>
        /// </summary>
        Unknown
    }
}