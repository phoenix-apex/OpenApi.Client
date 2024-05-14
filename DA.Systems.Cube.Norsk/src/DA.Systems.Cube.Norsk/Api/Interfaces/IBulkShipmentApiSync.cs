using System;
using System.Collections.Generic;
using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulkShipmentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve captured weight/dimensions for multiple shipments
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Limit the search to a range start from this date (optional)</param>
        /// <param name="endDateTime">Limit the search to a range end at this date (optional)</param>
        /// <returns>List&lt;ShipmentDimensionsResponse&gt;</returns>
        List<ShipmentDimensionsResponse> GetApiBulkShipmentDimensions(DateTimeOffset? startDateTime = default(DateTimeOffset?), DateTimeOffset? endDateTime = default(DateTimeOffset?));

        /// <summary>
        /// Retrieve captured weight/dimensions for multiple shipments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDateTime">Limit the search to a range start from this date (optional)</param>
        /// <param name="endDateTime">Limit the search to a range end at this date (optional)</param>
        /// <returns>ApiResponse of List&lt;ShipmentDimensionsResponse&gt;</returns>
        ApiResponse<List<ShipmentDimensionsResponse>> GetApiBulkShipmentDimensionsWithHttpInfo(DateTimeOffset? startDateTime = default(DateTimeOffset?), DateTimeOffset? endDateTime = default(DateTimeOffset?));
        #endregion Synchronous Operations
    }
}