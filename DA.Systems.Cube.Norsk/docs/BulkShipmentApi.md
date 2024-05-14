# DA.Systems.Cube.Norsk.Api.BulkShipmentApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BulkShipmentDimensionsGET**](BulkShipmentApi.md#bulkshipmentdimensionsget) | **GET** /api/bulk/shipment/dimensions | Retrieve captured weight/dimensions for multiple shipments |

<a id="bulkshipmentdimensionsget"></a>
# **BulkShipmentDimensionsGET**
> List&lt;ShipmentDimensionsResponse&gt; BulkShipmentDimensionsGET (DateTimeOffset? startDateTime = null, DateTimeOffset? endDateTime = null)

Retrieve captured weight/dimensions for multiple shipments

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
    public class BulkShipmentDimensionsGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BulkShipmentApi(httpClient, config, httpClientHandler);
            var startDateTime = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Limit the search to a range start from this date (optional) 
            var endDateTime = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Limit the search to a range end at this date (optional) 

            try
            {
                // Retrieve captured weight/dimensions for multiple shipments
                List<ShipmentDimensionsResponse> result = apiInstance.BulkShipmentDimensionsGET(startDateTime, endDateTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkShipmentApi.BulkShipmentDimensionsGET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkShipmentDimensionsGETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve captured weight/dimensions for multiple shipments
    ApiResponse<List<ShipmentDimensionsResponse>> response = apiInstance.BulkShipmentDimensionsGETWithHttpInfo(startDateTime, endDateTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkShipmentApi.BulkShipmentDimensionsGETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDateTime** | **DateTimeOffset?** | Limit the search to a range start from this date | [optional]  |
| **endDateTime** | **DateTimeOffset?** | Limit the search to a range end at this date | [optional]  |

### Return type

[**List&lt;ShipmentDimensionsResponse&gt;**](ShipmentDimensionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

