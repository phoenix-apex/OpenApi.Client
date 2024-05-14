using DA.Systems.Cube.Norsk.Client;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentItemApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode"></param>
        /// <returns>byte[]</returns>
        byte[] GetApiPackageScanimageByBarcode(string barcode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcode"></param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> GetApiPackageScanimageByBarcodeWithHttpInfo(string barcode);
        #endregion Synchronous Operations
    }
}