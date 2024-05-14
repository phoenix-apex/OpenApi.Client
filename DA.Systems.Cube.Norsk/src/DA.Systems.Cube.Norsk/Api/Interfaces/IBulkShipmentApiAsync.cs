using System;
using System.Collections.Generic;
using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulkShipmentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve captured weight/dimensions for multiple shipments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Limit the search to a range start from this date (optional)</param>
        /// <param name="endDateTime">Limit the search to a range end at this date (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShipmentDimensionsResponse&gt;</returns>
        System.Threading.Tasks.Task<List<ShipmentDimensionsResponse>> GetApiBulkShipmentDimensionsAsync(DateTimeOffset? startDateTime = default(DateTimeOffset?), DateTimeOffset? endDateTime = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve captured weight/dimensions for multiple shipments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Limit the search to a range start from this date (optional)</param>
        /// <param name="endDateTime">Limit the search to a range end at this date (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShipmentDimensionsResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ShipmentDimensionsResponse>>> GetApiBulkShipmentDimensionsWithHttpInfoAsync(DateTimeOffset? startDateTime = default(DateTimeOffset?), DateTimeOffset? endDateTime = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }
}