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
/// Message Schedule
/// </summary>
[DataContract(Name = "UpdateScheduledMessageRequest")]
public partial class UpdateScheduledMessageRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateScheduledMessageRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateScheduledMessageRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateScheduledMessageRequest" /> class.
    /// </summary>
    /// <param name="scheduledDeliveryDate">The date and time when the message will be scheduled for delivery. (required).</param>
    public UpdateScheduledMessageRequest(DateTimeOffset scheduledDeliveryDate = default(DateTimeOffset))
    {
            this.ScheduledDeliveryDate = scheduledDeliveryDate;
        }

    /// <summary>
    /// The date and time when the message will be scheduled for delivery.
    /// </summary>
    /// <value>The date and time when the message will be scheduled for delivery.</value>
    [DataMember(Name = "ScheduledDeliveryDate", IsRequired = true, EmitDefaultValue = true)]
    public DateTimeOffset ScheduledDeliveryDate { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateScheduledMessageRequest {\n");
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
            yield break;
        }
}