using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace DA.Systems.Cube.Norsk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQuoteApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.
        /// </summary>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteRequestModel">Data to be used to get valid services that are bookable. (optional)</param>
        /// <returns>QuoteResponseModel</returns>
        QuoteResponseModel PostApiQuote(QuoteRequestModel quoteRequestModel = default(QuoteRequestModel));

        /// <summary>
        /// Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DA.Systems.Cube.Norsk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteRequestModel">Data to be used to get valid services that are bookable. (optional)</param>
        /// <returns>ApiResponse of QuoteResponseModel</returns>
        ApiResponse<QuoteResponseModel> PostApiQuoteWithHttpInfo(QuoteRequestModel quoteRequestModel = default(QuoteRequestModel));
        #endregion Synchronous Operations
    }
}