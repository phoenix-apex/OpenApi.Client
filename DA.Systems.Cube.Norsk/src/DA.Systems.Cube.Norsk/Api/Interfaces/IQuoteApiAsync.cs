using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQuoteApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteRequestModel">Data to be used to get valid services that are bookable. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QuoteResponseModel</returns>
        System.Threading.Tasks.Task<QuoteResponseModel> PostApiQuoteAsync(QuoteRequestModel quoteRequestModel = default(QuoteRequestModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteRequestModel">Data to be used to get valid services that are bookable. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QuoteResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuoteResponseModel>> PostApiQuoteWithHttpInfoAsync(QuoteRequestModel quoteRequestModel = default(QuoteRequestModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }
}