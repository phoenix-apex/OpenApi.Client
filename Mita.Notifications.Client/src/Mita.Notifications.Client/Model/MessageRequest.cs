/*
 * MITA Notifications Platform REST API
 *
 * The Notifications REST API allows programmatic access to the Notifications Portal message funtionality. To use the REST API, you will need a Notifications Portal Account and an API key and secret. You can generate from the Notifications Portal using the API Key Manager.The REST API takes full advantage of all HTTP headers. Each part of a request and response is meaningful, including the request method (GET/POST, etc.), the individual headers (Location, Content-Type, Accept, etc.), and the response status code (200, 400, 404, etc.). Use of this API assumes a working knowledge of these HTTP components, and general use of RESTful web APIs.
 *
 * The version of the OpenAPI document: v1
 * Contact: notifications.mita@gov.mt
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Mita.Notifications.Client.Client.OpenAPIDateConverter;

namespace Mita.Notifications.Client.Model;

/// <summary>
/// Message Request
/// </summary>
[DataContract(Name = "MessageRequest")]
public partial class MessageRequest : IValidatableObject
{

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    [DataMember(Name = "MessageType", IsRequired = true, EmitDefaultValue = true)]
    public MessageType MessageType { get; set; }

    /// <summary>
    /// Gets or Sets MessagePriority
    /// </summary>
    [DataMember(Name = "MessagePriority", IsRequired = true, EmitDefaultValue = true)]
    public MessagePriority MessagePriority { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessageRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageRequest" /> class.
    /// </summary>
    /// <param name="contacts">The Contact Address is the delivery address where the message will be sent to.  This can be either an MSISDN or e-mail address depending on the message type..</param>
    /// <param name="messageContent">Message Content..</param>
    /// <param name="clientReference">Unique reference generated by the client application. (required).</param>
    /// <param name="messageType">messageType (required).</param>
    /// <param name="messagePriority">messagePriority (required).</param>
    /// <param name="senderId">Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message. (required).</param>
    /// <param name="callbackUrl">If provided, the Notifications Portal will deliver a receipt back to the application   through the HTTP POST method for the provided URL.   If URL is not provided the default API URL will be used..</param>
    /// <param name="scheduledDeliveryDate">The date and time when the message will be scheduled for delivery.   For instant messaging provide the current date and time. (required).</param>
    public MessageRequest(List<Contact> contacts = default(List<Contact>), List<MessageContent> messageContent = default(List<MessageContent>), string clientReference = default(string), MessageType messageType = default(MessageType), MessagePriority messagePriority = default(MessagePriority), Guid senderId = default(Guid), string callbackUrl = default(string), DateTimeOffset scheduledDeliveryDate = default(DateTimeOffset))
    {
            // to ensure "clientReference" is required (not null)
            if (clientReference == null)
            {
                throw new ArgumentNullException("clientReference is a required property for MessageRequest and cannot be null");
            }
            this.ClientReference = clientReference;
            this.MessageType = messageType;
            this.MessagePriority = messagePriority;
            this.SenderId = senderId;
            this.ScheduledDeliveryDate = scheduledDeliveryDate;
            this.Contacts = contacts;
            this.MessageContent = messageContent;
            this.CallbackUrl = callbackUrl;
        }

    /// <summary>
    /// The Contact Address is the delivery address where the message will be sent to.  This can be either an MSISDN or e-mail address depending on the message type.
    /// </summary>
    /// <value>The Contact Address is the delivery address where the message will be sent to.  This can be either an MSISDN or e-mail address depending on the message type.</value>
    [DataMember(Name = "Contacts", EmitDefaultValue = true)]
    public List<Contact> Contacts { get; set; }

    /// <summary>
    /// Message Content.
    /// </summary>
    /// <value>Message Content.</value>
    [DataMember(Name = "MessageContent", EmitDefaultValue = true)]
    public List<MessageContent> MessageContent { get; set; }

    /// <summary>
    /// Unique reference generated by the client application.
    /// </summary>
    /// <value>Unique reference generated by the client application.</value>
    [DataMember(Name = "ClientReference", IsRequired = true, EmitDefaultValue = true)]
    public string ClientReference { get; set; }

    /// <summary>
    /// Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message.
    /// </summary>
    /// <value>Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message.</value>
    [DataMember(Name = "SenderId", IsRequired = true, EmitDefaultValue = true)]
    public Guid SenderId { get; set; }

    /// <summary>
    /// If provided, the Notifications Portal will deliver a receipt back to the application   through the HTTP POST method for the provided URL.   If URL is not provided the default API URL will be used.
    /// </summary>
    /// <value>If provided, the Notifications Portal will deliver a receipt back to the application   through the HTTP POST method for the provided URL.   If URL is not provided the default API URL will be used.</value>
    /// <example>https://domain.com/listener</example>
    [DataMember(Name = "CallbackUrl", EmitDefaultValue = true)]
    public string CallbackUrl { get; set; }

    /// <summary>
    /// The date and time when the message will be scheduled for delivery.   For instant messaging provide the current date and time.
    /// </summary>
    /// <value>The date and time when the message will be scheduled for delivery.   For instant messaging provide the current date and time.</value>
    [DataMember(Name = "ScheduledDeliveryDate", IsRequired = true, EmitDefaultValue = true)]
    public DateTimeOffset ScheduledDeliveryDate { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageRequest {\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  MessageContent: ").Append(MessageContent).Append("\n");
            sb.Append("  ClientReference: ").Append(ClientReference).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MessagePriority: ").Append(MessagePriority).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ScheduledDeliveryDate: ").Append(ScheduledDeliveryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
            // ClientReference (string) maxLength
            if (this.ClientReference != null && this.ClientReference.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientReference, length must be less than 64.", new [] { "ClientReference" });
            }

            // ClientReference (string) minLength
            if (this.ClientReference != null && this.ClientReference.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientReference, length must be greater than 0.", new [] { "ClientReference" });
            }

            // CallbackUrl (string) maxLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length > 800)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackUrl, length must be less than 800.", new [] { "CallbackUrl" });
            }

            // CallbackUrl (string) minLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackUrl, length must be greater than 0.", new [] { "CallbackUrl" });
            }

            yield break;
        }
}