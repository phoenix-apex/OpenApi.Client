# Mita.Notifications.Client.Api.MessageBatchesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1BatchesBatchIdDelete**](MessageBatchesApi.md#apiv1batchesbatchiddelete) | **DELETE** /api/v1/batches/{batchId} | This method allows an application to delete all messages within a batch.   If a messages are awaiting delivery (Pending status), due to a future scheduled   delivery date, the application will be able to delete batch messages.   If messages are enroute through the service provider channels, deletion will   not be possible. |
| [**ApiV1BatchesBatchIdMessagesGet**](MessageBatchesApi.md#apiv1batchesbatchidmessagesget) | **GET** /api/v1/batches/{batchId}/messages | This method allows for the retrieval of multiple delivery reports (DLR) for all   the messages within a batch. Each delivery report will contain the status of the   submitted message and the original submitted message details. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate, and DateCreated (default). |
| [**ApiV1BatchesBatchIdPut**](MessageBatchesApi.md#apiv1batchesbatchidput) | **PUT** /api/v1/batches/{batchId} | This method allows an application to update all messages within a batch.  Note that the update is dependent on the ClientReference and MessageType   fields, that is, if a batch contains multiple message types, only the   messages of the type as defined in the MessageBatchRequest object will be   updated. Also, only the messages identified by the ClientReference will be updated.   Note messages within a batch can be updated if these are awaiting delivery   (Pending status). If messages are enroute through the service provider   channels, an update will not be possible. Also, if message recipients   need to be updated for a single message use the   \&quot;PUT api/v1/messages/{messageId}\&quot; method. |
| [**ApiV1BatchesBatchIdSchedulesPut**](MessageBatchesApi.md#apiv1batchesbatchidschedulesput) | **PUT** /api/v1/batches/{batchId}/schedules | This method allows an application to update the Scheduled Delivery Date field   for all messages within a batch. Note, messages within a batch can be updated   if these are awaiting delivery (Pending status). If messages are enroute   through the service provider channels, an update will not be possible. |
| [**ApiV1BatchesPost**](MessageBatchesApi.md#apiv1batchespost) | **POST** /api/v1/batches | This method allows an application to send multiple message types   within the same request. The method allows an application to send   messages to either individual or multiple recipients. This method is   also useful in scenarios where different messages (body text) need   to be sent to a number of recipients. |

<a id="apiv1batchesbatchiddelete"></a>
# **ApiV1BatchesBatchIdDelete**
> void ApiV1BatchesBatchIdDelete (Guid batchId)

This method allows an application to delete all messages within a batch.   If a messages are awaiting delivery (Pending status), due to a future scheduled   delivery date, the application will be able to delete batch messages.   If messages are enroute through the service provider channels, deletion will   not be possible.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1BatchesBatchIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessageBatchesApi(config);
            var batchId = "batchId_example";  // Guid | Batch unique identifier.

            try
            {
                // This method allows an application to delete all messages within a batch.   If a messages are awaiting delivery (Pending status), due to a future scheduled   delivery date, the application will be able to delete batch messages.   If messages are enroute through the service provider channels, deletion will   not be possible.
                apiInstance.ApiV1BatchesBatchIdDelete(batchId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1BatchesBatchIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to delete all messages within a batch.   If a messages are awaiting delivery (Pending status), due to a future scheduled   delivery date, the application will be able to delete batch messages.   If messages are enroute through the service provider channels, deletion will   not be possible.
    apiInstance.ApiV1BatchesBatchIdDeleteWithHttpInfo(batchId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **Guid** | Batch unique identifier. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **410** | Client Error |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1batchesbatchidmessagesget"></a>
# **ApiV1BatchesBatchIdMessagesGet**
> DeliveryReports ApiV1BatchesBatchIdMessagesGet (Guid batchId, int? pageIndex = null, int? pageSize = null, string sortField = null, SortDirection? sortDirection = null)

This method allows for the retrieval of multiple delivery reports (DLR) for all   the messages within a batch. Each delivery report will contain the status of the   submitted message and the original submitted message details. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate, and DateCreated (default).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1BatchesBatchIdMessagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessageBatchesApi(config);
            var batchId = "batchId_example";  // Guid | Batch unique identifier as provided when the original   message request was submitted.
            var pageIndex = 56;  // int? | Page index (defaults to 1 if not provided). (optional) 
            var pageSize = 56;  // int? | Page size (defaults to 50 if not provided). (optional) 
            var sortField = "sortField_example";  // string | Sort field (optional) 
            var sortDirection = (SortDirection) "asc";  // SortDirection? | Sort direction (optional) 

            try
            {
                // This method allows for the retrieval of multiple delivery reports (DLR) for all   the messages within a batch. Each delivery report will contain the status of the   submitted message and the original submitted message details. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate, and DateCreated (default).
                DeliveryReports result = apiInstance.ApiV1BatchesBatchIdMessagesGet(batchId, pageIndex, pageSize, sortField, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdMessagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1BatchesBatchIdMessagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of multiple delivery reports (DLR) for all   the messages within a batch. Each delivery report will contain the status of the   submitted message and the original submitted message details. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate, and DateCreated (default).
    ApiResponse<DeliveryReports> response = apiInstance.ApiV1BatchesBatchIdMessagesGetWithHttpInfo(batchId, pageIndex, pageSize, sortField, sortDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdMessagesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **Guid** | Batch unique identifier as provided when the original   message request was submitted. |  |
| **pageIndex** | **int?** | Page index (defaults to 1 if not provided). | [optional]  |
| **pageSize** | **int?** | Page size (defaults to 50 if not provided). | [optional]  |
| **sortField** | **string** | Sort field | [optional]  |
| **sortDirection** | **SortDirection?** | Sort direction | [optional]  |

### Return type

[**DeliveryReports**](DeliveryReports.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1batchesbatchidput"></a>
# **ApiV1BatchesBatchIdPut**
> InboundMessageBatch ApiV1BatchesBatchIdPut (Guid batchId, UpdateMessageBatchRequest updateMessageBatchRequest = null)

This method allows an application to update all messages within a batch.  Note that the update is dependent on the ClientReference and MessageType   fields, that is, if a batch contains multiple message types, only the   messages of the type as defined in the MessageBatchRequest object will be   updated. Also, only the messages identified by the ClientReference will be updated.   Note messages within a batch can be updated if these are awaiting delivery   (Pending status). If messages are enroute through the service provider   channels, an update will not be possible. Also, if message recipients   need to be updated for a single message use the   \"PUT api/v1/messages/{messageId}\" method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1BatchesBatchIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessageBatchesApi(config);
            var batchId = "batchId_example";  // Guid | Batch unique identifier.
            var updateMessageBatchRequest = new UpdateMessageBatchRequest(); // UpdateMessageBatchRequest | Message object containing the new message details to be updated. (optional) 

            try
            {
                // This method allows an application to update all messages within a batch.  Note that the update is dependent on the ClientReference and MessageType   fields, that is, if a batch contains multiple message types, only the   messages of the type as defined in the MessageBatchRequest object will be   updated. Also, only the messages identified by the ClientReference will be updated.   Note messages within a batch can be updated if these are awaiting delivery   (Pending status). If messages are enroute through the service provider   channels, an update will not be possible. Also, if message recipients   need to be updated for a single message use the   \"PUT api/v1/messages/{messageId}\" method.
                InboundMessageBatch result = apiInstance.ApiV1BatchesBatchIdPut(batchId, updateMessageBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1BatchesBatchIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to update all messages within a batch.  Note that the update is dependent on the ClientReference and MessageType   fields, that is, if a batch contains multiple message types, only the   messages of the type as defined in the MessageBatchRequest object will be   updated. Also, only the messages identified by the ClientReference will be updated.   Note messages within a batch can be updated if these are awaiting delivery   (Pending status). If messages are enroute through the service provider   channels, an update will not be possible. Also, if message recipients   need to be updated for a single message use the   \"PUT api/v1/messages/{messageId}\" method.
    ApiResponse<InboundMessageBatch> response = apiInstance.ApiV1BatchesBatchIdPutWithHttpInfo(batchId, updateMessageBatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **Guid** | Batch unique identifier. |  |
| **updateMessageBatchRequest** | [**UpdateMessageBatchRequest**](UpdateMessageBatchRequest.md) | Message object containing the new message details to be updated. | [optional]  |

### Return type

[**InboundMessageBatch**](InboundMessageBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1batchesbatchidschedulesput"></a>
# **ApiV1BatchesBatchIdSchedulesPut**
> void ApiV1BatchesBatchIdSchedulesPut (Guid batchId, UpdateScheduledMessageBatchRequest updateScheduledMessageBatchRequest = null)

This method allows an application to update the Scheduled Delivery Date field   for all messages within a batch. Note, messages within a batch can be updated   if these are awaiting delivery (Pending status). If messages are enroute   through the service provider channels, an update will not be possible.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1BatchesBatchIdSchedulesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessageBatchesApi(config);
            var batchId = "batchId_example";  // Guid | Batch unique identifier.
            var updateScheduledMessageBatchRequest = new UpdateScheduledMessageBatchRequest(); // UpdateScheduledMessageBatchRequest | MessageSchedule object containing the Scheduled Delivery Date to be updated. (optional) 

            try
            {
                // This method allows an application to update the Scheduled Delivery Date field   for all messages within a batch. Note, messages within a batch can be updated   if these are awaiting delivery (Pending status). If messages are enroute   through the service provider channels, an update will not be possible.
                apiInstance.ApiV1BatchesBatchIdSchedulesPut(batchId, updateScheduledMessageBatchRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdSchedulesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1BatchesBatchIdSchedulesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to update the Scheduled Delivery Date field   for all messages within a batch. Note, messages within a batch can be updated   if these are awaiting delivery (Pending status). If messages are enroute   through the service provider channels, an update will not be possible.
    apiInstance.ApiV1BatchesBatchIdSchedulesPutWithHttpInfo(batchId, updateScheduledMessageBatchRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesBatchIdSchedulesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **Guid** | Batch unique identifier. |  |
| **updateScheduledMessageBatchRequest** | [**UpdateScheduledMessageBatchRequest**](UpdateScheduledMessageBatchRequest.md) | MessageSchedule object containing the Scheduled Delivery Date to be updated. | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1batchespost"></a>
# **ApiV1BatchesPost**
> List&lt;InboundMessageBatch&gt; ApiV1BatchesPost (List<MessageRequest> messageRequest = null)

This method allows an application to send multiple message types   within the same request. The method allows an application to send   messages to either individual or multiple recipients. This method is   also useful in scenarios where different messages (body text) need   to be sent to a number of recipients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1BatchesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessageBatchesApi(config);
            var messageRequest = new List<MessageRequest>(); // List<MessageRequest> | MessageRequests object containing a collection of Message objects to be sent. (optional) 

            try
            {
                // This method allows an application to send multiple message types   within the same request. The method allows an application to send   messages to either individual or multiple recipients. This method is   also useful in scenarios where different messages (body text) need   to be sent to a number of recipients.
                List<InboundMessageBatch> result = apiInstance.ApiV1BatchesPost(messageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1BatchesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to send multiple message types   within the same request. The method allows an application to send   messages to either individual or multiple recipients. This method is   also useful in scenarios where different messages (body text) need   to be sent to a number of recipients.
    ApiResponse<List<InboundMessageBatch>> response = apiInstance.ApiV1BatchesPostWithHttpInfo(messageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessageBatchesApi.ApiV1BatchesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageRequest** | [**List&lt;MessageRequest&gt;**](MessageRequest.md) | MessageRequests object containing a collection of Message objects to be sent. | [optional]  |

### Return type

[**List&lt;InboundMessageBatch&gt;**](InboundMessageBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

