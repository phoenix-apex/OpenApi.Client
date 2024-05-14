# DA.Systems.Cube.Norsk.Api.ShipmentApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ShipmentDimensionsGET**](ShipmentApi.md#shipmentdimensionsget) | **GET** /api/shipment/{barcode}/dimensions | Retrieve captured weight/dimensions for a shipment items |
| [**ShipmentGetGET**](ShipmentApi.md#shipmentgetget) | **GET** /api/shipment/{barcode} | Get an object with all corresponding data for \&quot;ExternalApi.Models.Shipment\&quot;. |
| [**ShipmentLabelGET**](ShipmentApi.md#shipmentlabelget) | **GET** /api/shipment/{barcode}/label |  |
| [**ShipmentPostPOST**](ShipmentApi.md#shipmentpostpost) | **POST** /api/shipment | Book a shipment |

<a id="shipmentdimensionsget"></a>
# **ShipmentDimensionsGET**
> ShipmentDimensionsResponse ShipmentDimensionsGET (string barcode)

Retrieve captured weight/dimensions for a shipment items

May return not found if the dimensions haven't yet been captured

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
    public class ShipmentDimensionsGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShipmentApi(httpClient, config, httpClientHandler);
            var barcode = "barcode_example";  // string | String containing a reference for the searched shipment

            try
            {
                // Retrieve captured weight/dimensions for a shipment items
                ShipmentDimensionsResponse result = apiInstance.ShipmentDimensionsGET(barcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentDimensionsGET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentDimensionsGETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve captured weight/dimensions for a shipment items
    ApiResponse<ShipmentDimensionsResponse> response = apiInstance.ShipmentDimensionsGETWithHttpInfo(barcode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.ShipmentDimensionsGETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | String containing a reference for the searched shipment |  |

### Return type

[**ShipmentDimensionsResponse**](ShipmentDimensionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns \&quot;ExternalApi.Models.Dims.ShipmentDimensionsResponse\&quot; with stored dimensions. |  -  |
| **404** | Indicates that a shipment could not be found for the barcode. |  -  |
| **500** | Returns an object containing an error reason and reference. Reference can be provided to helpdesk for assistance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentgetget"></a>
# **ShipmentGetGET**
> Shipment ShipmentGetGET (string barcode)

Get an object with all corresponding data for \"ExternalApi.Models.Shipment\".

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
    public class ShipmentGetGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShipmentApi(httpClient, config, httpClientHandler);
            var barcode = "barcode_example";  // string | String containing a reference for the searched shipment

            try
            {
                // Get an object with all corresponding data for \"ExternalApi.Models.Shipment\".
                Shipment result = apiInstance.ShipmentGetGET(barcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentGetGET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentGetGETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an object with all corresponding data for \"ExternalApi.Models.Shipment\".
    ApiResponse<Shipment> response = apiInstance.ShipmentGetGETWithHttpInfo(barcode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.ShipmentGetGETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** | String containing a reference for the searched shipment |  |

### Return type

[**Shipment**](Shipment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns \&quot;ExternalApi.Models.Shipment\&quot; with related data. |  -  |
| **400** | Returns any validations errors for the request |  -  |
| **500** | Returns an object containing an error reason and reference. Reference can be provided to helpdesk for assistance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentlabelget"></a>
# **ShipmentLabelGET**
> byte[] ShipmentLabelGET (string barcode, LabelFormat? format = null, LabelSize? size = null)



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
    public class ShipmentLabelGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShipmentApi(httpClient, config, httpClientHandler);
            var barcode = "barcode_example";  // string | 
            var format = (LabelFormat) "Pdf";  // LabelFormat? |  (optional) 
            var size = (LabelSize) "A4";  // LabelSize? |  (optional) 

            try
            {
                byte[] result = apiInstance.ShipmentLabelGET(barcode, format, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentLabelGET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentLabelGETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<byte[]> response = apiInstance.ShipmentLabelGETWithHttpInfo(barcode, format, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.ShipmentLabelGETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string** |  |  |
| **format** | **LabelFormat?** |  | [optional]  |
| **size** | **LabelSize?** |  | [optional]  |

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, text/vnd.eltron-epl, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentpostpost"></a>
# **ShipmentPostPOST**
> ShipmentBookingResponse ShipmentPostPOST (ShipmentBookingRequest shipmentBookingRequest = null)

Book a shipment

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
    public class ShipmentPostPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShipmentApi(httpClient, config, httpClientHandler);
            var shipmentBookingRequest = new ShipmentBookingRequest(); // ShipmentBookingRequest | A model that represents a shipment booking request (optional) 

            try
            {
                // Book a shipment
                ShipmentBookingResponse result = apiInstance.ShipmentPostPOST(shipmentBookingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentPostPOST: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentPostPOSTWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Book a shipment
    ApiResponse<ShipmentBookingResponse> response = apiInstance.ShipmentPostPOSTWithHttpInfo(shipmentBookingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.ShipmentPostPOSTWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentBookingRequest** | [**ShipmentBookingRequest**](ShipmentBookingRequest.md) | A model that represents a shipment booking request | [optional]  |

### Return type

[**ShipmentBookingResponse**](ShipmentBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns information about the newly booked \&quot;ExternalApi.Models.Booking.ShipmentBookingResponse\&quot; |  -  |
| **400** | If the request has invalid or missing fields |  -  |
| **500** | Returns an object containing an error reason and reference. Reference can be provided to helpdesk for assistance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

