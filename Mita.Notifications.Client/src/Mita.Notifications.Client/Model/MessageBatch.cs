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
/// Message batch information
/// </summary>
[DataContract(Name = "MessageBatch")]
public partial class MessageBatch : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageBatch" /> class.
    /// </summary>
    /// <param name="batchId">Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted..</param>
    public MessageBatch(Guid batchId = default(Guid))
    {
            this.BatchId = batchId;
        }

    /// <summary>
    /// Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted.
    /// </summary>
    /// <value>Unique reference generated by the Notifications Portal to identify a group of messages posted in bulk.   This is useful when in situations where a group of messages needs to be updated or deleted.</value>
    [DataMember(Name = "BatchId", EmitDefaultValue = true)]
    public Guid BatchId { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageBatch {\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
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