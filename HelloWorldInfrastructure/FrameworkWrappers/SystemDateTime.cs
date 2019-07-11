
namespace HelloWorldInfrastructure.FrameworkWrappers
{
    using System;

    /// <summary>
    ///     Wraps the System.DateTime structure
    /// </summary>
    public class SystemDateTime : IDateTime
    {
        /// <summary>
        ///     Gets the DateTime as of Now
        /// </summary>
        /// <returns>A DateTime object containing the date and time of Now</returns>
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}