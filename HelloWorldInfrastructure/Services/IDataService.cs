

namespace HelloWorldInfrastructure.Services
{
    using HelloWorldInfrastructure.Models;

    /// <summary>
    ///     Data Service for manipulating data
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        ///     Gets today's data
        /// </summary>
        /// <returns>A TodaysData model containing today's data</returns>
        Data GetTodaysData();
    }
}