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
/// Message Quote Request
/// </summary>
[DataContract(Name = "CalculateMessageCost")]
public partial class CalculateMessageCost : IValidatableObject
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
    /// Initializes a new instance of the <see cref="CalculateMessageCost" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CalculateMessageCost() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CalculateMessageCost" /> class.
    /// </summary>
    /// <param name="senderId">Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message. (required).</param>
    /// <param name="messageType">messageType (required).</param>
    /// <param name="messagePriority">messagePriority (required).</param>
    /// <param name="contacts">The Contact Address is the delivery address where the message will be sent to.  This can be either an MSISDN or e-mail address depending on the message type..</param>
    /// <param name="messageContent">Message Content..</param>
    public CalculateMessageCost(Guid senderId = default(Guid), MessageType messageType = default(MessageType), MessagePriority messagePriority = default(MessagePriority), List<Contact> contacts = default(List<Contact>), List<MessageContent> messageContent = default(List<MessageContent>))
    {
            this.SenderId = senderId;
            this.MessageType = messageType;
            this.MessagePriority = messagePriority;
            this.Contacts = contacts;
            this.MessageContent = messageContent;
        }

    /// <summary>
    /// Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message.
    /// </summary>
    /// <value>Sender identifier. This field is used by the Notifications Portal to specify the sender name for the message.</value>
    [DataMember(Name = "SenderId", IsRequired = true, EmitDefaultValue = true)]
    public Guid SenderId { get; set; }

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculateMessageCost {\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MessagePriority: ").Append(MessagePriority).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  MessageContent: ").Append(MessageContent).Append("\n");
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