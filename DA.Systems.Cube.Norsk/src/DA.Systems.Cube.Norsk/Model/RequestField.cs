/*
 * Norsk API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: helpdesk@norsk-global.com
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
using FileParameter = DA.Systems.Cube.Norsk.Client.FileParameter;
using OpenAPIDateConverter = DA.Systems.Cube.Norsk.Client.OpenAPIDateConverter;

namespace DA.Systems.Cube.Norsk.Model
{
    /// <summary>
    /// RequestField
    /// </summary>
    [DataContract(Name = "RequestField")]
    public class RequestField : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestField" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="errors">errors.</param>
        public RequestField(string name = default(string), List<string> errors = default(List<string>))
        {
            Name = name;
            Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "Errors", EmitDefaultValue = true)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}