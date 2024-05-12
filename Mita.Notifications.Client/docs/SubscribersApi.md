# Mita.Notifications.Client.Api.SubscribersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1SubscribersGet**](SubscribersApi.md#apiv1subscribersget) | **GET** /api/v1/subscribers | This method allows for the retrieval of all subscribers stored by the system.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default),   DisplayName, Email, and MobileNo. |
| [**ApiV1SubscribersPost**](SubscribersApi.md#apiv1subscriberspost) | **POST** /api/v1/subscribers | This method allows for the creation of a new Subscriber. |
| [**ApiV1SubscribersSubscriberIdDelete**](SubscribersApi.md#apiv1subscriberssubscriberiddelete) | **DELETE** /api/v1/subscribers/{subscriberId} | This method allows for the deletion of a subscriber stored by the Notifications Portal. |
| [**ApiV1SubscribersSubscriberIdGet**](SubscribersApi.md#apiv1subscriberssubscriberidget) | **GET** /api/v1/subscribers/{subscriberId} | This method allows for the retrieval of a Subscriber object details. |
| [**ApiV1SubscribersSubscriberIdGroupsGet**](SubscribersApi.md#apiv1subscriberssubscriberidgroupsget) | **GET** /api/v1/subscribers/{subscriberId}/groups | This method allows for the retrieval of the list of groups a subscriber is subscribed to. |
| [**ApiV1SubscribersSubscriberIdPut**](SubscribersApi.md#apiv1subscriberssubscriberidput) | **PUT** /api/v1/subscribers/{subscriberId} | This method allows for an application to update an existing Subscriber object. |

<a id="apiv1subscribersget"></a>
# **ApiV1SubscribersGet**
> Subscribers ApiV1SubscribersGet (Guid? groupId = null, string email = null, string mobileNo = null, int? pageIndex = null, int? pageSize = null, string sortField = null, SortDirection? sortDirection = null)

This method allows for the retrieval of all subscribers stored by the system.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default),   DisplayName, Email, and MobileNo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1SubscribersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscribersApi(config);
            var groupId = "groupId_example";  // Guid? | Group unique identifier (optional) 
            var email = "email_example";  // string | Email Address (optional) 
            var mobileNo = "mobileNo_example";  // string | Mobile Number (optional) 
            var pageIndex = 56;  // int? | Page index (defaults to 1 if not provided). (optional) 
            var pageSize = 56;  // int? | Page size (defaults to 50 if not provided). (optional) 
            var sortField = "sortField_example";  // string | Sort field (optional) 
            var sortDirection = (SortDirection) "asc";  // SortDirection? | Sort direction (optional) 

            try
            {
                // This method allows for the retrieval of all subscribers stored by the system.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default),   DisplayName, Email, and MobileNo.
                Subscribers result = apiInstance.ApiV1SubscribersGet(groupId, email, mobileNo, pageIndex, pageSize, sortField, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1SubscribersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of all subscribers stored by the system.     To limit the amount of data returned, the application consuming the API has   the option to control the amount of data received using the available pagination   parameters. The PageSize parameter is used to limit the number of records   returned per page. If this is not provided, it defaults to a limit of 50 records.   The PageIndex parameter is used to navigate through pages. SortField and   SortDirection parameters are used to control the sorting of the results.   The supported sorting fields are as follows: FirstName, LastName (default),   DisplayName, Email, and MobileNo.
    ApiResponse<Subscribers> response = apiInstance.ApiV1SubscribersGetWithHttpInfo(groupId, email, mobileNo, pageIndex, pageSize, sortField, sortDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid?** | Group unique identifier | [optional]  |
| **email** | **string** | Email Address | [optional]  |
| **mobileNo** | **string** | Mobile Number | [optional]  |
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

<a id="apiv1subscriberspost"></a>
# **ApiV1SubscribersPost**
> Guid ApiV1SubscribersPost (CreateSubscriberRequest createSubscriberRequest = null)

This method allows for the creation of a new Subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1SubscribersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscribersApi(config);
            var createSubscriberRequest = new CreateSubscriberRequest(); // CreateSubscriberRequest | Subscriber object. (optional) 

            try
            {
                // This method allows for the creation of a new Subscriber.
                Guid result = apiInstance.ApiV1SubscribersPost(createSubscriberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1SubscribersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the creation of a new Subscriber.
    ApiResponse<Guid> response = apiInstance.ApiV1SubscribersPostWithHttpInfo(createSubscriberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1subscriberssubscriberiddelete"></a>
# **ApiV1SubscribersSubscriberIdDelete**
> void ApiV1SubscribersSubscriberIdDelete (Guid subscriberId)

This method allows for the deletion of a subscriber stored by the Notifications Portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1SubscribersSubscriberIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscribersApi(config);
            var subscriberId = "subscriberId_example";  // Guid | Subscriber unique identifier.

            try
            {
                // This method allows for the deletion of a subscriber stored by the Notifications Portal.
                apiInstance.ApiV1SubscribersSubscriberIdDelete(subscriberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1SubscribersSubscriberIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the deletion of a subscriber stored by the Notifications Portal.
    apiInstance.ApiV1SubscribersSubscriberIdDeleteWithHttpInfo(subscriberId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="apiv1subscriberssubscriberidget"></a>
# **ApiV1SubscribersSubscriberIdGet**
> Subscriber ApiV1SubscribersSubscriberIdGet (Guid subscriberId)

This method allows for the retrieval of a Subscriber object details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1SubscribersSubscriberIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscribersApi(config);
            var subscriberId = "subscriberId_example";  // Guid | Subscriber unique identifier.

            try
            {
                // This method allows for the retrieval of a Subscriber object details.
                Subscriber result = apiInstance.ApiV1SubscribersSubscriberIdGet(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1SubscribersSubscriberIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of a Subscriber object details.
    ApiResponse<Subscriber> response = apiInstance.ApiV1SubscribersSubscriberIdGetWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **Guid** | Subscriber unique identifier. |  |

### Return type

[**Subscriber**](Subscriber.md)

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

<a id="apiv1subscriberssubscriberidgroupsget"></a>
# **ApiV1SubscribersSubscriberIdGroupsGet**
> List&lt;Group&gt; ApiV1SubscribersSubscriberIdGroupsGet (Guid subscriberId)

This method allows for the retrieval of the list of groups a subscriber is subscribed to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1SubscribersSubscriberIdGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscribersApi(config);
            var subscriberId = "subscriberId_example";  // Guid | Subscriber unique identifier.

            try
            {
                // This method allows for the retrieval of the list of groups a subscriber is subscribed to.
                List<Group> result = apiInstance.ApiV1SubscribersSubscriberIdGroupsGet(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1SubscribersSubscriberIdGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for the retrieval of the list of groups a subscriber is subscribed to.
    ApiResponse<List<Group>> response = apiInstance.ApiV1SubscribersSubscriberIdGroupsGetWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **Guid** | Subscriber unique identifier. |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1subscriberssubscriberidput"></a>
# **ApiV1SubscribersSubscriberIdPut**
> void ApiV1SubscribersSubscriberIdPut (Guid subscriberId, UpdateSubscriberRequest updateSubscriberRequest = null)

This method allows for an application to update an existing Subscriber object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Mita.Notifications.Client.Api;
using Mita.Notifications.Client.Client;
using Mita.Notifications.Client.Model;

namespace Example
{
    public class ApiV1SubscribersSubscriberIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SubscribersApi(config);
            var subscriberId = "subscriberId_example";  // Guid | Subscriber unique identifier.
            var updateSubscriberRequest = new UpdateSubscriberRequest(); // UpdateSubscriberRequest | Subscriber object. (optional) 

            try
            {
                // This method allows for an application to update an existing Subscriber object.
                apiInstance.ApiV1SubscribersSubscriberIdPut(subscriberId, updateSubscriberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1SubscribersSubscriberIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method allows for an application to update an existing Subscriber object.
    apiInstance.ApiV1SubscribersSubscriberIdPutWithHttpInfo(subscriberId, updateSubscriberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.ApiV1SubscribersSubscriberIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **Guid** | Subscriber unique identifier. |  |
| **updateSubscriberRequest** | [**UpdateSubscriberRequest**](UpdateSubscriberRequest.md) | Subscriber object. | [optional]  |

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

