# Mita.Notifications.Client.Model.ApiKey
API Key Information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Friendly name to identify the usage of the API Key. | [optional] 
**Key** | **string** | API Key unique identifier. | [optional] 
**Secret** | **string** | Secret Key (Must be refreshed every seven days or as per the indicated Expiry Date field). | [optional] 
**ExpiryDate** | **DateTimeOffset?** | Expiry Date. If null the Secret Key never expires (only used for testing). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

