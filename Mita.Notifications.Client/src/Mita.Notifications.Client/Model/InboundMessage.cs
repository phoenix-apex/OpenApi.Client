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
/// Inbound Message object containing details about a message request in the Notifications System inbound queue.
/// </summary>
[DataContract(Name = "InboundMessage")]
public partial class InboundMessage : IValidatableObject
{

    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    [DataMember(Name = "MessageType", EmitDefaultValue = true)]
    public MessageType? MessageType { get; set; }

    /// <summary>
    /// Gets or Sets MessagePriority
    /// </summary>
    [DataMember(Name = "MessagePriority", EmitDefaultValue = true)]
    public MessagePriority? MessagePriority { get; set; }

    /// <summary>
    /// Gets or Sets InboundMessageStatus
    /// </summary>
    [DataMember(Name = "InboundMessageStatus", EmitDefaultValue = true)]
    public InboundMessageStatus? InboundMessageStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="InboundMessage" /> class.
    /// </summary>
    /// <param name="inboundMessageId">Unique reference used to identify a message waiting processing in the inbound queue..</param>
    /// <param name="transactionId">Unique reference used to identify a group of batches in the inbound queue..</param>
    /// <param name="batchId">Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted..</param>
    /// <param name="senderId">Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message..</param>
    /// <param name="messageType">messageType.</param>
    /// <param name="messagePriority">messagePriority.</param>
    /// <param name="inboundMessageStatus">inboundMessageStatus.</param>
    /// <param name="failedAttempts">Number of failed attempts by the Notifications System Backend..</param>
    /// <param name="processingReport">This field contains the details of any failed attempts or system errors..</param>
    /// <param name="dateCreated">Date/time when the message was created..</param>
    /// <param name="dateUpdated">Date/time when the message was last updated..</param>
    public InboundMessage(Guid inboundMessageId = default(Guid), Guid transactionId = default(Guid), Guid batchId = default(Guid), Guid senderId = default(Guid), MessageType? messageType = default(MessageType?), MessagePriority? messagePriority = default(MessagePriority?), InboundMessageStatus? inboundMessageStatus = default(InboundMessageStatus?), int failedAttempts = default(int), string processingReport = default(string), DateTimeOffset dateCreated = default(DateTimeOffset), DateTimeOffset? dateUpdated = default(DateTimeOffset?))
    {
            this.InboundMessageId = inboundMessageId;
            this.TransactionId = transactionId;
            this.BatchId = batchId;
            this.SenderId = senderId;
            this.MessageType = messageType;
            this.MessagePriority = messagePriority;
            this.InboundMessageStatus = inboundMessageStatus;
            this.FailedAttempts = failedAttempts;
            this.ProcessingReport = processingReport;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
        }

    /// <summary>
    /// Unique reference used to identify a message waiting processing in the inbound queue.
    /// </summary>
    /// <value>Unique reference used to identify a message waiting processing in the inbound queue.</value>
    [DataMember(Name = "InboundMessageId", EmitDefaultValue = true)]
    public Guid InboundMessageId { get; set; }

    /// <summary>
    /// Unique reference used to identify a group of batches in the inbound queue.
    /// </summary>
    /// <value>Unique reference used to identify a group of batches in the inbound queue.</value>
    [DataMember(Name = "TransactionId", EmitDefaultValue = true)]
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted.
    /// </summary>
    /// <value>Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted.</value>
    [DataMember(Name = "BatchId", EmitDefaultValue = true)]
    public Guid BatchId { get; set; }

    /// <summary>
    /// Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message.
    /// </summary>
    /// <value>Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message.</value>
    [DataMember(Name = "SenderId", EmitDefaultValue = true)]
    public Guid SenderId { get; set; }

    /// <summary>
    /// Number of failed attempts by the Notifications System Backend.
    /// </summary>
    /// <value>Number of failed attempts by the Notifications System Backend.</value>
    [DataMember(Name = "FailedAttempts", EmitDefaultValue = true)]
    public int FailedAttempts { get; set; }

    /// <summary>
    /// This field contains the details of any failed attempts or system errors.
    /// </summary>
    /// <value>This field contains the details of any failed attempts or system errors.</value>
    [DataMember(Name = "ProcessingReport", EmitDefaultValue = true)]
    public string ProcessingReport { get; set; }

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboundMessage {\n");
            sb.Append("  InboundMessageId: ").Append(InboundMessageId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MessagePriority: ").Append(MessagePriority).Append("\n");
            sb.Append("  InboundMessageStatus: ").Append(InboundMessageStatus).Append("\n");
            sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
            sb.Append("  ProcessingReport: ").Append(ProcessingReport).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
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
            yield break;
        }
}