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
    /// Location the shipment is being booked from
    /// </summary>
    [DataContract(Name = "SiteDetails")]
    public class SiteDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteDetails" /> class.
        /// </summary>
        /// <param name="location">(optional) Location code such as airport code.</param>
        /// <param name="containerReference">(optional) A reference to a container the shipment is intended to arrive in.</param>
        public SiteDetails(string location = default(string), string containerReference = default(string))
        {
            Location = location;
            ContainerReference = containerReference;
        }

        /// <summary>
        /// (optional) Location code such as airport code
        /// </summary>
        /// <value>(optional) Location code such as airport code</value>
        [DataMember(Name = "Location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// (optional) A reference to a container the shipment is intended to arrive in
        /// </summary>
        /// <value>(optional) A reference to a container the shipment is intended to arrive in</value>
        [DataMember(Name = "ContainerReference", EmitDefaultValue = true)]
        public string ContainerReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SiteDetails {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ContainerReference: ").Append(ContainerReference).Append("\n");
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
