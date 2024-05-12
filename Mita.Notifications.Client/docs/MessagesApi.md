# Mita.Notifications.Client.Api.MessagesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1MessagesGet**](MessagesApi.md#apiv1messagesget) | **GET** /api/v1/messages | This method allows for the retrieval of all messages stored by the system.   To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate (default), and DateCreated. |
| [**ApiV1MessagesMessageIdDelete**](MessagesApi.md#apiv1messagesmessageiddelete) | **DELETE** /api/v1/messages/{messageId} | This method allows an application to delete a message stored   by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to   delete the message. If the message is enroute through the service provider channels,   deletion will not be possible. Note that the method allows only for the deletion   of a single message, single recipient as identified by the provided Message   Unique Identifier. |
| [**ApiV1MessagesMessageIdGet**](MessagesApi.md#apiv1messagesmessageidget) | **GET** /api/v1/messages/{messageId} | Retrieve the delivery report (DLR) for the message as specified in the messageId parameter.   The delivery report will contain both the delivery status of the message as provided by   the service operator and the original submitted message details. For SMS message types,   this is the piece of information sent back by the mobile network provider containing whether   the message was successfully delivered or if the delivery has failed. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed. |
| [**ApiV1MessagesMessageIdPut**](MessagesApi.md#apiv1messagesmessageidput) | **PUT** /api/v1/messages/{messageId} | This method allows application to update the details of an already submitted   message stored by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to update any   of the details submitted. If the message is enroute through the service provider channels,   an update will not be possible. Note that the method allows only for the update of a single   message, single recipient as identified by the provided Message Unique Identifier. |
| [**ApiV1MessagesMessageIdSchedulesPut**](MessagesApi.md#apiv1messagesmessageidschedulesput) | **PUT** /api/v1/messages/{messageId}/schedules | This method allows an application to update the Scheduled Delivery Date field   for a single message as specified by the messageId parameter. Note, a message   can only be updated if the message is awaiting delivery (Pending status).   If the message is enroute through the service provider channels, an update   will not be possible. |
| [**ApiV1MessagesPost**](MessagesApi.md#apiv1messagespost) | **POST** /api/v1/messages | This method allows an application to send a new Message Request.   The method supports various message types (currently SMS or Email) and   can be used by the application to send a message to either    individual or multiple recipients. |

<a id="apiv1messagesget"></a>
# **ApiV1MessagesGet**
> DeliveryReports ApiV1MessagesGet (Guid? batchId = null, string clientReference = null, MessageType? messageType = null, MessageStatus? messageStatus = null, Guid? senderId = null, DateTimeOffset? scheduledDeliveryDateFrom = null, DateTimeOffset? scheduledDeliveryDateTo = null, int? pageIndex = null, int? pageSize = null, string sortField = null, SortDirection? sortDirection = null)

This method allows for the retrieval of all messages stored by the system.   To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate (default), and DateCreated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagesApi(config);
            var batchId = "batchId_example";  // Guid? | Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk. (optional) 
            var clientReference = "clientReference_example";  // string | Unique reference provided by the client application while submitting a new message. (optional) 
            var messageType = (MessageType) "email";  // MessageType? | Message Type. (optional) 
            var messageStatus = (MessageStatus) "100";  // MessageStatus? | Message Status. (optional) 
            var senderId = "senderId_example";  // Guid? | Sender unqiue identifier. (optional) 
            var scheduledDeliveryDateFrom = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | From date and time when the message is scheduled for delivery. (optional) 
            var scheduledDeliveryDateTo = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | To date and time when the message is scheduled for delivery. (optional) 
            var pageIndex = 56;  // int? | Page index (defaults to 1 if not provided). (optional) 
            var pageSize = 56;  // int? | Page size (defaults to 50 if not provided). (optional) 
            var sortField = "sortField_example";  // string | Sort field (optional) 
            var sortDirection = (SortDirection) "asc";  // SortDirection? | Sort direction (optional) 

            try
            {
                // This method allows for the retrieval of all messages stored by the system.   To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate (default), and DateCreated.
                DeliveryReports result = apiInstance.ApiV1MessagesGet(batchId, clientReference, messageType, messageStatus, senderId, scheduledDeliveryDateFrom, scheduledDeliveryDateTo, pageIndex, pageSize, sortField, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ApiV1MessagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of all messages stored by the system.   To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: Subject, MessageType, MessagePriority,   MessageStatus, ScheduledDeliveryDate (default), and DateCreated.
    ApiResponse<DeliveryReports> response = apiInstance.ApiV1MessagesGetWithHttpInfo(batchId, clientReference, messageType, messageStatus, senderId, scheduledDeliveryDateFrom, scheduledDeliveryDateTo, pageIndex, pageSize, sortField, sortDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ApiV1MessagesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **Guid?** | Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk. | [optional]  |
| **clientReference** | **string** | Unique reference provided by the client application while submitting a new message. | [optional]  |
| **messageType** | **MessageType?** | Message Type. | [optional]  |
| **messageStatus** | **MessageStatus?** | Message Status. | [optional]  |
| **senderId** | **Guid?** | Sender unqiue identifier. | [optional]  |
| **scheduledDeliveryDateFrom** | **DateTimeOffset?** | From date and time when the message is scheduled for delivery. | [optional]  |
| **scheduledDeliveryDateTo** | **DateTimeOffset?** | To date and time when the message is scheduled for delivery. | [optional]  |
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
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1messagesmessageiddelete"></a>
# **ApiV1MessagesMessageIdDelete**
> void ApiV1MessagesMessageIdDelete (Guid messageId)

This method allows an application to delete a message stored   by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to   delete the message. If the message is enroute through the service provider channels,   deletion will not be possible. Note that the method allows only for the deletion   of a single message, single recipient as identified by the provided Message   Unique Identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagesMessageIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagesApi(config);
            var messageId = "messageId_example";  // Guid | Message unique identifier.

            try
            {
                // This method allows an application to delete a message stored   by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to   delete the message. If the message is enroute through the service provider channels,   deletion will not be possible. Note that the method allows only for the deletion   of a single message, single recipient as identified by the provided Message   Unique Identifier.
                apiInstance.ApiV1MessagesMessageIdDelete(messageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagesMessageIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to delete a message stored   by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to   delete the message. If the message is enroute through the service provider channels,   deletion will not be possible. Note that the method allows only for the deletion   of a single message, single recipient as identified by the provided Message   Unique Identifier.
    apiInstance.ApiV1MessagesMessageIdDeleteWithHttpInfo(messageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | Message unique identifier. |  |

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

<a id="apiv1messagesmessageidget"></a>
# **ApiV1MessagesMessageIdGet**
> DeliveryReport ApiV1MessagesMessageIdGet (Guid messageId)

Retrieve the delivery report (DLR) for the message as specified in the messageId parameter.   The delivery report will contain both the delivery status of the message as provided by   the service operator and the original submitted message details. For SMS message types,   this is the piece of information sent back by the mobile network provider containing whether   the message was successfully delivered or if the delivery has failed. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagesMessageIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagesApi(config);
            var messageId = "messageId_example";  // Guid | Message unique identifier.

            try
            {
                // Retrieve the delivery report (DLR) for the message as specified in the messageId parameter.   The delivery report will contain both the delivery status of the message as provided by   the service operator and the original submitted message details. For SMS message types,   this is the piece of information sent back by the mobile network provider containing whether   the message was successfully delivered or if the delivery has failed. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.
                DeliveryReport result = apiInstance.ApiV1MessagesMessageIdGet(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagesMessageIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the delivery report (DLR) for the message as specified in the messageId parameter.   The delivery report will contain both the delivery status of the message as provided by   the service operator and the original submitted message details. For SMS message types,   this is the piece of information sent back by the mobile network provider containing whether   the message was successfully delivered or if the delivery has failed. This method will be used   by an application to determine the status of the submitted message at any point in time.   Note, that delivery reports are also provided through the provided Callback URL (Recommended   Method) when submitting a new message request. This allows an application to receive the   delivery report instantaneously when the status of a message has changed.
    ApiResponse<DeliveryReport> response = apiInstance.ApiV1MessagesMessageIdGetWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | Message unique identifier. |  |

### Return type

[**DeliveryReport**](DeliveryReport.md)

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1messagesmessageidput"></a>
# **ApiV1MessagesMessageIdPut**
> MessageBatch ApiV1MessagesMessageIdPut (Guid messageId, UpdateMessageRequest updateMessageRequest = null)

This method allows application to update the details of an already submitted   message stored by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to update any   of the details submitted. If the message is enroute through the service provider channels,   an update will not be possible. Note that the method allows only for the update of a single   message, single recipient as identified by the provided Message Unique Identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagesMessageIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagesApi(config);
            var messageId = "messageId_example";  // Guid | Message unique identifier.
            var updateMessageRequest = new UpdateMessageRequest(); // UpdateMessageRequest | Message object containing the new message details to be updated. (optional) 

            try
            {
                // This method allows application to update the details of an already submitted   message stored by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to update any   of the details submitted. If the message is enroute through the service provider channels,   an update will not be possible. Note that the method allows only for the update of a single   message, single recipient as identified by the provided Message Unique Identifier.
                MessageBatch result = apiInstance.ApiV1MessagesMessageIdPut(messageId, updateMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagesMessageIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows application to update the details of an already submitted   message stored by the Notifications Portal. If the message is awaiting delivery (Pending status),   due to a future scheduled delivery date, the application will be able to update any   of the details submitted. If the message is enroute through the service provider channels,   an update will not be possible. Note that the method allows only for the update of a single   message, single recipient as identified by the provided Message Unique Identifier.
    ApiResponse<MessageBatch> response = apiInstance.ApiV1MessagesMessageIdPutWithHttpInfo(messageId, updateMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | Message unique identifier. |  |
| **updateMessageRequest** | [**UpdateMessageRequest**](UpdateMessageRequest.md) | Message object containing the new message details to be updated. | [optional]  |

### Return type

[**MessageBatch**](MessageBatch.md)

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

<a id="apiv1messagesmessageidschedulesput"></a>
# **ApiV1MessagesMessageIdSchedulesPut**
> MessageBatch ApiV1MessagesMessageIdSchedulesPut (Guid messageId, UpdateScheduledMessageRequest updateScheduledMessageRequest = null)

This method allows an application to update the Scheduled Delivery Date field   for a single message as specified by the messageId parameter. Note, a message   can only be updated if the message is awaiting delivery (Pending status).   If the message is enroute through the service provider channels, an update   will not be possible.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagesMessageIdSchedulesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagesApi(config);
            var messageId = "messageId_example";  // Guid | Message unique identifier.
            var updateScheduledMessageRequest = new UpdateScheduledMessageRequest(); // UpdateScheduledMessageRequest | MessageSchedule object containing the Scheduled Delivery Date to be updated. (optional) 

            try
            {
                // This method allows an application to update the Scheduled Delivery Date field   for a single message as specified by the messageId parameter. Note, a message   can only be updated if the message is awaiting delivery (Pending status).   If the message is enroute through the service provider channels, an update   will not be possible.
                MessageBatch result = apiInstance.ApiV1MessagesMessageIdSchedulesPut(messageId, updateScheduledMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdSchedulesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagesMessageIdSchedulesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to update the Scheduled Delivery Date field   for a single message as specified by the messageId parameter. Note, a message   can only be updated if the message is awaiting delivery (Pending status).   If the message is enroute through the service provider channels, an update   will not be possible.
    ApiResponse<MessageBatch> response = apiInstance.ApiV1MessagesMessageIdSchedulesPutWithHttpInfo(messageId, updateScheduledMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ApiV1MessagesMessageIdSchedulesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **Guid** | Message unique identifier. |  |
| **updateScheduledMessageRequest** | [**UpdateScheduledMessageRequest**](UpdateScheduledMessageRequest.md) | MessageSchedule object containing the Scheduled Delivery Date to be updated. | [optional]  |

### Return type

[**MessageBatch**](MessageBatch.md)

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

<a id="apiv1messagespost"></a>
# **ApiV1MessagesPost**
> InboundMessageBatch ApiV1MessagesPost (CreateMessageRequest createMessageRequest = null)

This method allows an application to send a new Message Request.   The method supports various message types (currently SMS or Email) and   can be used by the application to send a message to either    individual or multiple recipients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1MessagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessagesApi(config);
            var createMessageRequest = new CreateMessageRequest(); // CreateMessageRequest | MessageRequest object containing the message data to be sent. (optional) 

            try
            {
                // This method allows an application to send a new Message Request.   The method supports various message types (currently SMS or Email) and   can be used by the application to send a message to either    individual or multiple recipients.
                InboundMessageBatch result = apiInstance.ApiV1MessagesPost(createMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ApiV1MessagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MessagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to send a new Message Request.   The method supports various message types (currently SMS or Email) and   can be used by the application to send a message to either    individual or multiple recipients.
    ApiResponse<InboundMessageBatch> response = apiInstance.ApiV1MessagesPostWithHttpInfo(createMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ApiV1MessagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createMessageRequest** | [**CreateMessageRequest**](CreateMessageRequest.md) | MessageRequest object containing the message data to be sent. | [optional]  |

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
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

