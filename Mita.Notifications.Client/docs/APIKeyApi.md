# Mita.Notifications.Client.Api.APIKeyApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1KeyGet**](APIKeyApi.md#apiv1keyget) | **GET** /api/v1/key | Use this API to refresh an expired API Key and obtain a new Secret Key.    Please note that API Secret Keys expire after seven days by default.   When this key expires, the user needs to refresh the API Secret Key  using this endpoint to generate a new secret key.     You can obtain a new Secret Key the expired Secret Key. |

<a id="apiv1keyget"></a>
# **ApiV1KeyGet**
> ApiKey ApiV1KeyGet ()

Use this API to refresh an expired API Key and obtain a new Secret Key.    Please note that API Secret Keys expire after seven days by default.   When this key expires, the user needs to refresh the API Secret Key  using this endpoint to generate a new secret key.     You can obtain a new Secret Key the expired Secret Key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1KeyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new APIKeyApi(config);

            try
            {
                // Use this API to refresh an expired API Key and obtain a new Secret Key.    Please note that API Secret Keys expire after seven days by default.   When this key expires, the user needs to refresh the API Secret Key  using this endpoint to generate a new secret key.     You can obtain a new Secret Key the expired Secret Key.
                ApiKey result = apiInstance.ApiV1KeyGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIKeyApi.ApiV1KeyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1KeyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Use this API to refresh an expired API Key and obtain a new Secret Key.    Please note that API Secret Keys expire after seven days by default.   When this key expires, the user needs to refresh the API Secret Key  using this endpoint to generate a new secret key.     You can obtain a new Secret Key the expired Secret Key.
    ApiResponse<ApiKey> response = apiInstance.ApiV1KeyGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APIKeyApi.ApiV1KeyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ApiKey**](ApiKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

