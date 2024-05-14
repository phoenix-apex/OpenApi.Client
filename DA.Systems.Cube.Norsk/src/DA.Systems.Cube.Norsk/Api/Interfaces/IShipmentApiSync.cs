using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve captured weight/dimensions for a shipment items
        /// </summary>
        /// <remarks>
        /// May return not found if the dimensions haven&#39;t yet been captured
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <returns>ShipmentDimensionsResponse</returns>
        ShipmentDimensionsResponse GetApiShipmentDimensionsByBarcode(string barcode);

        /// <summary>
        /// Retrieve captured weight/dimensions for a shipment items
        /// </summary>
        /// <remarks>
        /// May return not found if the dimensions haven&#39;t yet been captured
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <returns>ApiResponse of ShipmentDimensionsResponse</returns>
        ApiResponse<ShipmentDimensionsResponse> GetApiShipmentDimensionsByBarcodeWithHttpInfo(string barcode);
        /// <summary>
        /// Get an object with all corresponding data for \&quot;ExternalApi.Models.Shipment\&quot;.
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <returns>Shipment</returns>
        Shipment GetApiShipmentByBarcode(string barcode);

        /// <summary>
        /// Get an object with all corresponding data for \&quot;ExternalApi.Models.Shipment\&quot;.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode">String containing a reference for the searched shipment</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> GetApiShipmentByBarcodeWithHttpInfo(string barcode);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="size"> (optional)</param>
        /// <returns>byte[]</returns>
        byte[] GetApiShipmentLabelByBarcode(string barcode, LabelFormat? format = default(LabelFormat?), LabelSize? size = default(LabelSize?));

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
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> GetApiShipmentLabelByBarcodeWithHttpInfo(string barcode, LabelFormat? format = default(LabelFormat?), LabelSize? size = default(LabelSize?));
        /// <summary>
        /// Book a shipment
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentBookingRequest">A model that represents a shipment booking request (optional)</param>
        /// <returns>ShipmentBookingResponse</returns>
        ShipmentBookingResponse PostApiShipment(ShipmentBookingRequest shipmentBookingRequest = default(ShipmentBookingRequest));

        /// <summary>
        /// Book a shipment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentBookingRequest">A model that represents a shipment booking request (optional)</param>
        /// <returns>ApiResponse of ShipmentBookingResponse</returns>
        ApiResponse<ShipmentBookingResponse> PostApiShipmentWithHttpInfo(ShipmentBookingRequest shipmentBookingRequest = default(ShipmentBookingRequest));
        #endregion Synchronous Operations
    }
}