# Mita.Notifications.Client.Api.AttachmentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1AttachmentsAttachmentIdGet**](AttachmentsApi.md#apiv1attachmentsattachmentidget) | **GET** /api/v1/attachments/{attachmentId} | Retrieves a file attachment as specified by the attachmentId parameter. |

<a id="apiv1attachmentsattachmentidget"></a>
# **ApiV1AttachmentsAttachmentIdGet**
> byte[] ApiV1AttachmentsAttachmentIdGet (Guid attachmentId)

Retrieves a file attachment as specified by the attachmentId parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1AttachmentsAttachmentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AttachmentsApi(config);
            var attachmentId = "attachmentId_example";  // Guid | Attachment unique identifier.

            try
            {
                // Retrieves a file attachment as specified by the attachmentId parameter.
                byte[] result = apiInstance.ApiV1AttachmentsAttachmentIdGet(attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.ApiV1AttachmentsAttachmentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1AttachmentsAttachmentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a file attachment as specified by the attachmentId parameter.
    ApiResponse<byte[]> response = apiInstance.ApiV1AttachmentsAttachmentIdGetWithHttpInfo(attachmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.ApiV1AttachmentsAttachmentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attachmentId** | **Guid** | Attachment unique identifier. |  |

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

