# Mita.Notifications.Client.Model.MessageContent
The MessageContent object contains the data associated with   the message to be sent and the Language the message is drafted in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Language** | **Language** |  | 
**Subject** | **string** | Message Subject.  Conditional - Used only for e-mail message types or message types requiring a Subject. | [optional] 
**MessageBody** | **string** | Message Body. | 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Message attachment list.  Optional - Used only for e-mail message types or message types allowing an attachment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

