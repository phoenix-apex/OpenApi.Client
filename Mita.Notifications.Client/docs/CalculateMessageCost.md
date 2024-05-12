# Mita.Notifications.Client.Model.CalculateMessageCost
Message Quote Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SenderId** | **Guid** | Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message. | 
**MessageType** | **MessageType** |  | 
**MessagePriority** | **MessagePriority** |  | 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | The Contact Address is the delivery address where the message will be sent to.  This can be either an MSISDN or e-mail address depending on the message type. | [optional] 
**MessageContent** | [**List&lt;MessageContent&gt;**](MessageContent.md) | Message Content. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

