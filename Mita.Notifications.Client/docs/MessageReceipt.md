# Mita.Notifications.Client.Model.MessageReceipt
Message Receipt details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Language** | **Language** |  | [optional] 
**CharacterCount** | **int** | The number of characters in the message. For SMS type messages, depending on the \&quot;Encoding\&quot;   of the text provided, SMS text messages are limited to either 160 (GSM-7 encoding equating to   7-bits per character) or 70 (UTF encoded messages, such as Maltese, using 16 bits per character)   characters in length. If a message length exceeds 160 characters in case of 7-bit encoding (or   70 characters for UTF encoding), the message is split up to multiple separate SMS and sent to   the handset separately, to be concatenated on the receiver&#39;s end. For GSM-7 encoded long messages,   exceeding 160 characters, these are split into 153 character chunks (7 characters used for    segmentation information and for concatenation individual messages back together). For UTF   encoded long messages, they are split into 67 character chunks (with 3 characters used for   segmentation information and to concatenate the individual messages back together). Note that the   standard SMS message can only contain a maximum of 1120 bits, therefore messages will be   limited to 7 concatenated messages. | [optional] 
**MessagePartsCount** | **int** | The number of messages the message text will be split into.   For SMS Type Messages, MessageCount will range from 1 to 7,   while for Email Type Messages, the MessageCount property   will always be set to 1. | [optional] 
**MessagePartMaxCharacters** | **int?** | The calculated maximum number of characters for each Message   Part, based on the message text encoding. This field will only   be populated for SMS Type Messages. | [optional] 
**MessageParts** | **List&lt;string&gt;** | This provides a preview for SMS Type Messages of how the message text will be   split into parts as per the SMS standard. | [optional] 
**Encoding** | **Encoding** |  | [optional] 
**LocalMessagePrice** | **double** | The Local Price per Message in Euro including VAT. | [optional] 
**InternationalMessagePrice** | **double** | The International Price per Message in Euro including VAT. | [optional] 
**TotalRecipientsCount** | **int** | The total number of recipients that the message will be sent.  Recipients will be grouped by the Country Dialing Code provided. | [optional] 
**TotalMessagesCount** | **int** | The actual total number of messages to be sent. For SMS Type Messages this is the   total \&quot;MessagePartsCount\&quot; multiplied by the \&quot;TotalRecipientsCount\&quot;. | [optional] 
**TotalCost** | **double** | The Total Cost to send the Message in Euro including VAT. | [optional] 
**WarningMessages** | **List&lt;string&gt;** | Warning Messages provided by the Notifications System to be   displayed by the client application. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

