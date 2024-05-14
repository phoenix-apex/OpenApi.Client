# DA.Systems.Cube.Norsk.Api.QuoteApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QuoteQuotesPOST**](QuoteApi.md#quotequotespost) | **POST** /api/quote | Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided. |

<a id="quotequotespost"></a>
# **QuoteQuotesPOST**
> QuoteResponseModel QuoteQuotesPOST (QuoteRequestModel quoteRequestModel = null)

Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DA.Systems.Cube.Norsk.Api;
using DA.Systems.Cube.Norsk.Client;
using DA.Systems.Cube.Norsk.Model;

namespace Example
{
    public class QuoteQuotesPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new QuoteApi(httpClient, config, httpClientHandler);
            var quoteRequestModel = new QuoteRequestModel(); // QuoteRequestModel | Data to be used to get valid services that are bookable. (optional) 

            try
            {
                // Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.
                QuoteResponseModel result = apiInstance.QuoteQuotesPOST(quoteRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuoteApi.QuoteQuotesPOST: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuoteQuotesPOSTWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about possible services that can be booked using the provided information.  Returned Quotes will be applicable to the data provided.
    ApiResponse<QuoteResponseModel> response = apiInstance.QuoteQuotesPOSTWithHttpInfo(quoteRequestModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuoteApi.QuoteQuotesPOSTWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **quoteRequestModel** | [**QuoteRequestModel**](QuoteRequestModel.md) | Data to be used to get valid services that are bookable. | [optional]  |

### Return type

[**QuoteResponseModel**](QuoteResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

