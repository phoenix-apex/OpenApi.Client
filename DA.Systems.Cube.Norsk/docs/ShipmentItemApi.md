# DA.Systems.Cube.Norsk.Api.ShipmentItemApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ShipmentItemImageGET**](ShipmentItemApi.md#shipmentitemimageget) | **GET** /api/package/{barcode}/scanimage |  |

<a id="shipmentitemimageget"></a>
# **ShipmentItemImageGET**
> byte[] ShipmentItemImageGET (string barcode)



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
    public class ShipmentItemImageGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShipmentItemApi(httpClient, config, httpClientHandler);
            var barcode = "barcode_example";  // string | 

            try
            {
                byte[] result = apiInstance.ShipmentItemImageGET(barcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentItemApi.ShipmentItemImageGET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentItemImageGETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<byte[]> response = apiInstance.ShipmentItemImageGETWithHttpInfo(barcode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentItemApi.ShipmentItemImageGETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** |  |  |

### Return type

**byte[]**

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

