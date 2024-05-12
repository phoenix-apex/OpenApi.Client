# Mita.Notifications.Client.Api.SubscriptionsContactGroupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1GroupsGet**](SubscriptionsContactGroupsApi.md#apiv1groupsget) | **GET** /api/v1/groups | This method allows for the retrieval of the available contact groups stored by the Notifications Portal. |
| [**ApiV1GroupsGroupIdDelete**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupiddelete) | **DELETE** /api/v1/groups/{groupId} | This method allows for the deletion of a group stored by the Notifications Portal. |
| [**ApiV1GroupsGroupIdGet**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidget) | **GET** /api/v1/groups/{groupId} | This method allows for the retrieval of a Group object. |
| [**ApiV1GroupsGroupIdMessagesPost**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidmessagespost) | **POST** /api/v1/groups/{groupId}/messages | This method allows an application to send a new Message Request to all contacts within a Group. |
| [**ApiV1GroupsGroupIdPut**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidput) | **PUT** /api/v1/groups/{groupId} | This method allows for an application to update a existing group object. |
| [**ApiV1GroupsGroupIdSubscribersGet**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidsubscribersget) | **GET** /api/v1/groups/{groupId}/subscribers | This method allows for the retrieval of contacts subscribed to a group.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default), DisplayName,   Email, and MobileNo. |
| [**ApiV1GroupsGroupIdSubscribersPost**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidsubscriberspost) | **POST** /api/v1/groups/{groupId}/subscribers | This method allows for the creation of a new Subscriber   and subscription to a specific Group identified by the   groupId parameter. |
| [**ApiV1GroupsGroupIdSubscribersSubscriberIdDelete**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidsubscriberssubscriberiddelete) | **DELETE** /api/v1/groups/{groupId}/subscribers/{subscriberId} | This method allows for an application to manage opt-outs and unbind   an existing subscriber as specified by the subscriberId from a   specific Group identified by the groupId parameter. |
| [**ApiV1GroupsGroupIdSubscriptionsPost**](SubscriptionsContactGroupsApi.md#apiv1groupsgroupidsubscriptionspost) | **POST** /api/v1/groups/{groupId}/subscriptions | This method allows an application to bind an existing subscriber as   specified by the subscriberId to a specific Group identified by   the groupId parameter. |
| [**ApiV1GroupsPost**](SubscriptionsContactGroupsApi.md#apiv1groupspost) | **POST** /api/v1/groups | This method allows for the creation of a new Group. |

<a id="apiv1groupsget"></a>
# **ApiV1GroupsGet**
> List&lt;Group&gt; ApiV1GroupsGet ()

This method allows for the retrieval of the available contact groups stored by the Notifications Portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);

            try
            {
                // This method allows for the retrieval of the available contact groups stored by the Notifications Portal.
                List<Group> result = apiInstance.ApiV1GroupsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of the available contact groups stored by the Notifications Portal.
    ApiResponse<List<Group>> response = apiInstance.ApiV1GroupsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Group&gt;**](Group.md)

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

<a id="apiv1groupsgroupiddelete"></a>
# **ApiV1GroupsGroupIdDelete**
> void ApiV1GroupsGroupIdDelete (Guid groupId)

This method allows for the deletion of a group stored by the Notifications Portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.

            try
            {
                // This method allows for the deletion of a group stored by the Notifications Portal.
                apiInstance.ApiV1GroupsGroupIdDelete(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the deletion of a group stored by the Notifications Portal.
    apiInstance.ApiV1GroupsGroupIdDeleteWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |

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
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1groupsgroupidget"></a>
# **ApiV1GroupsGroupIdGet**
> Group ApiV1GroupsGroupIdGet (Guid groupId)

This method allows for the retrieval of a Group object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.

            try
            {
                // This method allows for the retrieval of a Group object.
                Group result = apiInstance.ApiV1GroupsGroupIdGet(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of a Group object.
    ApiResponse<Group> response = apiInstance.ApiV1GroupsGroupIdGetWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |

### Return type

[**Group**](Group.md)

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

<a id="apiv1groupsgroupidmessagespost"></a>
# **ApiV1GroupsGroupIdMessagesPost**
> InboundMessageBatch ApiV1GroupsGroupIdMessagesPost (Guid groupId, CreateMessageGroupRequest createMessageGroupRequest = null)

This method allows an application to send a new Message Request to all contacts within a Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdMessagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.
            var createMessageGroupRequest = new CreateMessageGroupRequest(); // CreateMessageGroupRequest | Message object containing the message data to be sent. (optional) 

            try
            {
                // This method allows an application to send a new Message Request to all contacts within a Group.
                InboundMessageBatch result = apiInstance.ApiV1GroupsGroupIdMessagesPost(groupId, createMessageGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdMessagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdMessagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to send a new Message Request to all contacts within a Group.
    ApiResponse<InboundMessageBatch> response = apiInstance.ApiV1GroupsGroupIdMessagesPostWithHttpInfo(groupId, createMessageGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdMessagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |
| **createMessageGroupRequest** | [**CreateMessageGroupRequest**](CreateMessageGroupRequest.md) | Message object containing the message data to be sent. | [optional]  |

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1groupsgroupidput"></a>
# **ApiV1GroupsGroupIdPut**
> void ApiV1GroupsGroupIdPut (Guid groupId, UpdateSubscriberGroupRequest updateSubscriberGroupRequest = null)

This method allows for an application to update a existing group object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.
            var updateSubscriberGroupRequest = new UpdateSubscriberGroupRequest(); // UpdateSubscriberGroupRequest | Group object. (optional) 

            try
            {
                // This method allows for an application to update a existing group object.
                apiInstance.ApiV1GroupsGroupIdPut(groupId, updateSubscriberGroupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for an application to update a existing group object.
    apiInstance.ApiV1GroupsGroupIdPutWithHttpInfo(groupId, updateSubscriberGroupRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |
| **updateSubscriberGroupRequest** | [**UpdateSubscriberGroupRequest**](UpdateSubscriberGroupRequest.md) | Group object. | [optional]  |

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1groupsgroupidsubscribersget"></a>
# **ApiV1GroupsGroupIdSubscribersGet**
> Subscribers ApiV1GroupsGroupIdSubscribersGet (Guid groupId, int? pageIndex = null, int? pageSize = null, string sortField = null, SortDirection? sortDirection = null)

This method allows for the retrieval of contacts subscribed to a group.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default), DisplayName,   Email, and MobileNo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdSubscribersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.
            var pageIndex = 56;  // int? | Page index (defaults to 1 if not provided). (optional) 
            var pageSize = 56;  // int? | Page size (defaults to 50 if not provided). (optional) 
            var sortField = "sortField_example";  // string | Sort field (optional) 
            var sortDirection = (SortDirection) "asc";  // SortDirection? | Sort direction (optional) 

            try
            {
                // This method allows for the retrieval of contacts subscribed to a group.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default), DisplayName,   Email, and MobileNo.
                Subscribers result = apiInstance.ApiV1GroupsGroupIdSubscribersGet(groupId, pageIndex, pageSize, sortField, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscribersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdSubscribersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of contacts subscribed to a group.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default), DisplayName,   Email, and MobileNo.
    ApiResponse<Subscribers> response = apiInstance.ApiV1GroupsGroupIdSubscribersGetWithHttpInfo(groupId, pageIndex, pageSize, sortField, sortDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscribersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |
| **pageIndex** | **int?** | Page index (defaults to 1 if not provided). | [optional]  |
| **pageSize** | **int?** | Page size (defaults to 50 if not provided). | [optional]  |
| **sortField** | **string** | Sort field | [optional]  |
| **sortDirection** | **SortDirection?** | Sort direction | [optional]  |

### Return type

[**Subscribers**](Subscribers.md)

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

<a id="apiv1groupsgroupidsubscriberspost"></a>
# **ApiV1GroupsGroupIdSubscribersPost**
> Guid ApiV1GroupsGroupIdSubscribersPost (Guid groupId, CreateSubscriberRequest createSubscriberRequest = null)

This method allows for the creation of a new Subscriber   and subscription to a specific Group identified by the   groupId parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdSubscribersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.
            var createSubscriberRequest = new CreateSubscriberRequest(); // CreateSubscriberRequest | Subscriber object. (optional) 

            try
            {
                // This method allows for the creation of a new Subscriber   and subscription to a specific Group identified by the   groupId parameter.
                Guid result = apiInstance.ApiV1GroupsGroupIdSubscribersPost(groupId, createSubscriberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscribersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdSubscribersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the creation of a new Subscriber   and subscription to a specific Group identified by the   groupId parameter.
    ApiResponse<Guid> response = apiInstance.ApiV1GroupsGroupIdSubscribersPostWithHttpInfo(groupId, createSubscriberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscribersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |
| **createSubscriberRequest** | [**CreateSubscriberRequest**](CreateSubscriberRequest.md) | Subscriber object. | [optional]  |

### Return type

**Guid**

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1groupsgroupidsubscriberssubscriberiddelete"></a>
# **ApiV1GroupsGroupIdSubscribersSubscriberIdDelete**
> void ApiV1GroupsGroupIdSubscribersSubscriberIdDelete (Guid groupId, Guid subscriberId)

This method allows for an application to manage opt-outs and unbind   an existing subscriber as specified by the subscriberId from a   specific Group identified by the groupId parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdSubscribersSubscriberIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.
            var subscriberId = "subscriberId_example";  // Guid | Subscriber unique identifier.

            try
            {
                // This method allows for an application to manage opt-outs and unbind   an existing subscriber as specified by the subscriberId from a   specific Group identified by the groupId parameter.
                apiInstance.ApiV1GroupsGroupIdSubscribersSubscriberIdDelete(groupId, subscriberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscribersSubscriberIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdSubscribersSubscriberIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for an application to manage opt-outs and unbind   an existing subscriber as specified by the subscriberId from a   specific Group identified by the groupId parameter.
    apiInstance.ApiV1GroupsGroupIdSubscribersSubscriberIdDeleteWithHttpInfo(groupId, subscriberId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscribersSubscriberIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |
| **subscriberId** | **Guid** | Subscriber unique identifier. |  |

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
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1groupsgroupidsubscriptionspost"></a>
# **ApiV1GroupsGroupIdSubscriptionsPost**
> void ApiV1GroupsGroupIdSubscriptionsPost (Guid groupId, CreateSubscriptionRequest createSubscriptionRequest = null)

This method allows an application to bind an existing subscriber as   specified by the subscriberId to a specific Group identified by   the groupId parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsGroupIdSubscriptionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var groupId = "groupId_example";  // Guid | Group unique identifier.
            var createSubscriptionRequest = new CreateSubscriptionRequest(); // CreateSubscriptionRequest | Subscription object containing Subscriber unique identifier. (optional) 

            try
            {
                // This method allows an application to bind an existing subscriber as   specified by the subscriberId to a specific Group identified by   the groupId parameter.
                apiInstance.ApiV1GroupsGroupIdSubscriptionsPost(groupId, createSubscriptionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscriptionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsGroupIdSubscriptionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows an application to bind an existing subscriber as   specified by the subscriberId to a specific Group identified by   the groupId parameter.
    apiInstance.ApiV1GroupsGroupIdSubscriptionsPostWithHttpInfo(groupId, createSubscriptionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsGroupIdSubscriptionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** | Group unique identifier. |  |
| **createSubscriptionRequest** | [**CreateSubscriptionRequest**](CreateSubscriptionRequest.md) | Subscription object containing Subscriber unique identifier. | [optional]  |

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
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1groupspost"></a>
# **ApiV1GroupsPost**
> Group ApiV1GroupsPost (CreateGroupRequest createGroupRequest = null)

This method allows for the creation of a new Group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1GroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscriptionsContactGroupsApi(config);
            var createGroupRequest = new CreateGroupRequest(); // CreateGroupRequest | Group object. (optional) 

            try
            {
                // This method allows for the creation of a new Group.
                Group result = apiInstance.ApiV1GroupsPost(createGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1GroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the creation of a new Group.
    ApiResponse<Group> response = apiInstance.ApiV1GroupsPostWithHttpInfo(createGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionsContactGroupsApi.ApiV1GroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupRequest** | [**CreateGroupRequest**](CreateGroupRequest.md) | Group object. | [optional]  |

### Return type

[**Group**](Group.md)

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

