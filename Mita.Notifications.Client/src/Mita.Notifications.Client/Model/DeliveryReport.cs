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
/// Delivery Report object
/// </summary>
[DataContract(Name = "DeliveryReport")]
public partial class DeliveryReport : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name = "Language", EmitDefaultValue = true)]
    public Language? Language { get; set; }

    /// <summary>
    /// Gets or Sets MessageStatus
    /// </summary>
    [DataMember(Name = "MessageStatus", EmitDefaultValue = true)]
    public MessageStatus? MessageStatus { get; set; }

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
    /// Initializes a new instance of the <see cref="DeliveryReport" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DeliveryReport() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DeliveryReport" /> class.
    /// </summary>
    /// <param name="messageId">Notifications Portal unique identifier..</param>
    /// <param name="batchId">Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted..</param>
    /// <param name="contact">contact.</param>
    /// <param name="language">language.</param>
    /// <param name="subject">Message Subject.  Conditional - Used only for e-mail message types or message types requiring a Subject..</param>
    /// <param name="messageBody">Message Body..</param>
    /// <param name="attachments">Message attachment list.  Optional - Used only for e-mail message types or message types allowing an attachment..</param>
    /// <param name="messageStatus">messageStatus.</param>
    /// <param name="dateCreated">Date/time when the message was created..</param>
    /// <param name="dateUpdated">Date/time when the message was last updated..</param>
    /// <param name="clientReference">Unique reference generated by the client application. (required).</param>
    /// <param name="messageType">messageType (required).</param>
    /// <param name="messagePriority">messagePriority (required).</param>
    /// <param name="senderId">Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message. (required).</param>
    /// <param name="callbackUrl">If provided, the Notifications Portal will deliver a receipt back to the application   through the HTTP POST method for the provided URL.   If URL is not provided the default API URL will be used..</param>
    /// <param name="scheduledDeliveryDate">The date and time when the message will be scheduled for delivery.   For instant messaging provide the current date and time. (required).</param>
    public DeliveryReport(Guid messageId = default(Guid), Guid batchId = default(Guid), Contact contact = default(Contact), Language? language = default(Language?), string subject = default(string), string messageBody = default(string), List<AttachmentUri> attachments = default(List<AttachmentUri>), MessageStatus? messageStatus = default(MessageStatus?), DateTimeOffset dateCreated = default(DateTimeOffset), DateTimeOffset? dateUpdated = default(DateTimeOffset?), string clientReference = default(string), MessageType messageType = default(MessageType), MessagePriority messagePriority = default(MessagePriority), Guid senderId = default(Guid), string callbackUrl = default(string), DateTimeOffset scheduledDeliveryDate = default(DateTimeOffset))
    {
            // to ensure "clientReference" is required (not null)
            if (clientReference == null)
            {
                throw new ArgumentNullException("clientReference is a required property for DeliveryReport and cannot be null");
            }
            this.ClientReference = clientReference;
            this.MessageType = messageType;
            this.MessagePriority = messagePriority;
            this.SenderId = senderId;
            this.ScheduledDeliveryDate = scheduledDeliveryDate;
            this.MessageId = messageId;
            this.BatchId = batchId;
            this.Contact = contact;
            this.Language = language;
            this.Subject = subject;
            this.MessageBody = messageBody;
            this.Attachments = attachments;
            this.MessageStatus = messageStatus;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
            this.CallbackUrl = callbackUrl;
        }

    /// <summary>
    /// Notifications Portal unique identifier.
    /// </summary>
    /// <value>Notifications Portal unique identifier.</value>
    [DataMember(Name = "MessageId", EmitDefaultValue = true)]
    public Guid MessageId { get; set; }

    /// <summary>
    /// Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted.
    /// </summary>
    /// <value>Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted.</value>
    [DataMember(Name = "BatchId", EmitDefaultValue = true)]
    public Guid BatchId { get; set; }

    /// <summary>
    /// Gets or Sets Contact
    /// </summary>
    [DataMember(Name = "Contact", EmitDefaultValue = true)]
    public Contact Contact { get; set; }

    /// <summary>
    /// Message Subject.  Conditional - Used only for e-mail message types or message types requiring a Subject.
    /// </summary>
    /// <value>Message Subject.  Conditional - Used only for e-mail message types or message types requiring a Subject.</value>
    [DataMember(Name = "Subject", EmitDefaultValue = true)]
    public string Subject { get; set; }

    /// <summary>
    /// Message Body.
    /// </summary>
    /// <value>Message Body.</value>
    [DataMember(Name = "MessageBody", EmitDefaultValue = true)]
    public string MessageBody { get; set; }

    /// <summary>
    /// Message attachment list.  Optional - Used only for e-mail message types or message types allowing an attachment.
    /// </summary>
    /// <value>Message attachment list.  Optional - Used only for e-mail message types or message types allowing an attachment.</value>
    [DataMember(Name = "Attachments", EmitDefaultValue = true)]
    public List<AttachmentUri> Attachments { get; set; }

    /// <summary>
    /// Date/time when the message was created.
    /// </summary>
    /// <value>Date/time when the message was created.</value>
    [DataMember(Name = "DateCreated", EmitDefaultValue = true)]
    public DateTimeOffset DateCreated { get; set; }

    /// <summary>
    /// Date/time when the message was last updated.
    /// </summary>
    /// <value>Date/time when the message was last updated.</value>
    [DataMember(Name = "DateUpdated", EmitDefaultValue = true)]
    public DateTimeOffset? DateUpdated { get; set; }

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
            sb.Append("class DeliveryReport {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  MessageBody: ").Append(MessageBody).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
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