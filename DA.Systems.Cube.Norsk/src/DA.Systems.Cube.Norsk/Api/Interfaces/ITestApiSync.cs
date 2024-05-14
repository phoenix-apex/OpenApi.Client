using DA.Systems.Cube.Norsk.Client;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITestApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Simply returns true if the user is authenticated
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>bool</returns>
        bool GetApiTest();

        /// <summary>
        /// Simply returns true if the user is authenticated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> GetApiTestWithHttpInfo();
        #endregion Synchronous Operations
    }
}