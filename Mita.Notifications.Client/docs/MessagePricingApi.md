# Mita.Notifications.Client.Api.MessagePricingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1MessagePricingPost**](MessagePricingApi.md#apiv1messagepricingpost) | **POST** /api/v1/message-pricing | This method allows an application to calculate the total cost to send   a new Message Request. The method currently supports both SMS and Email. |

<a id="apiv1messagepricingpost"></a>
# **ApiV1MessagePricingPost**
> List&lt;MessageReceipt&gt; ApiV1MessagePricingPost (CalculateMessageCost calculateMessageCost = null)

This method allows an application to calculate the total cost to send   a new Message Request. The method currently supports both SMS and Email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagePricingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagePricingApi(config);
            var calculateMessageCost = new CalculateMessageCost(); // CalculateMessageCost | MessageQuote object containing message information for the total cost calculation. (optional) 

            try
            {
                // This method allows an application to calculate the total cost to send   a new Message Request. The method currently supports both SMS and Email.
                List<MessageReceipt> result = apiInstance.ApiV1MessagePricingPost(calculateMessageCost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagePricingApi.ApiV1MessagePricingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagePricingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to calculate the total cost to send   a new Message Request. The method currently supports both SMS and Email.
    ApiResponse<List<MessageReceipt>> response = apiInstance.ApiV1MessagePricingPostWithHttpInfo(calculateMessageCost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagePricingApi.ApiV1MessagePricingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **calculateMessageCost** | [**CalculateMessageCost**](CalculateMessageCost.md) | MessageQuote object containing message information for the total cost calculation. | [optional]  |

### Return type

[**List&lt;MessageReceipt&gt;**](MessageReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

