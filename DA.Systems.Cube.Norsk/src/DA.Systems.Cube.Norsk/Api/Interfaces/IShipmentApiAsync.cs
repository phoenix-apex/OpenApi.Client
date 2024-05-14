using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve captured weight/dimensions for a shipment items
        /// </summary>
        /// <remarks>
        /// May return not found if the dimensions haven&#39;t yet been captured
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShipmentDimensionsResponse</returns>
        System.Threading.Tasks.Task<ShipmentDimensionsResponse> GetApiShipmentDimensionsByBarcodeAsync(string barcode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve captured weight/dimensions for a shipment items
        /// </summary>
        /// <remarks>
        /// May return not found if the dimensions haven&#39;t yet been captured
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShipmentDimensionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShipmentDimensionsResponse>> GetApiShipmentDimensionsByBarcodeWithHttpInfoAsync(string barcode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get an object with all corresponding data for \&quot;ExternalApi.Models.Shipment\&quot;.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Shipment</returns>
        System.Threading.Tasks.Task<Shipment> GetApiShipmentByBarcodeAsync(string barcode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get an object with all corresponding data for \&quot;ExternalApi.Models.Shipment\&quot;.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Shipment>> GetApiShipmentByBarcodeWithHttpInfoAsync(string barcode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> GetApiShipmentLabelByBarcodeAsync(string barcode, LabelFormat? format = default(LabelFormat?), LabelSize? size = default(LabelSize?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> GetApiShipmentLabelByBarcodeWithHttpInfoAsync(string barcode, LabelFormat? format = default(LabelFormat?), LabelSize? size = default(LabelSize?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Book a shipment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentBookingRequest">A model that represents a shipment booking request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShipmentBookingResponse</returns>
        System.Threading.Tasks.Task<ShipmentBookingResponse> PostApiShipmentAsync(ShipmentBookingRequest shipmentBookingRequest = default(ShipmentBookingRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Book a shipment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentBookingRequest">A model that represents a shipment booking request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShipmentBookingResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShipmentBookingResponse>> PostApiShipmentWithHttpInfoAsync(ShipmentBookingRequest shipmentBookingRequest = default(ShipmentBookingRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }
}