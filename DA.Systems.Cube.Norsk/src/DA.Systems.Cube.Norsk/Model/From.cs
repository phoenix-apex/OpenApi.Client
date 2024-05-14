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
    /// Represents the collection location for a shipment. This class is used to denote the precise place from   where a shipment will be picked up, providing crucial details such as ZIP code, town, and country.
    /// </summary>
    [DataContract(Name = "From")]
    public class From : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="From" /> class.
        /// </summary>
        /// <param name="zipcode">The ZIP code of the collection location..</param>
        /// <param name="town">The town of the collection location..</param>
        /// <param name="countryCode">The country code of the collection location..</param>
        public From(string zipcode = default(string), string town = default(string), string countryCode = default(string))
        {
            Zipcode = zipcode;
            Town = town;
            CountryCode = countryCode;
        }

        /// <summary>
        /// The ZIP code of the collection location.
        /// </summary>
        /// <value>The ZIP code of the collection location.</value>
        [DataMember(Name = "Zipcode", EmitDefaultValue = true)]
        public string Zipcode { get; set; }

        /// <summary>
        /// The town of the collection location.
        /// </summary>
        /// <value>The town of the collection location.</value>
        [DataMember(Name = "Town", EmitDefaultValue = true)]
        public string Town { get; set; }

        /// <summary>
        /// The country code of the collection location.
        /// </summary>
        /// <value>The country code of the collection location.</value>
        [DataMember(Name = "CountryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class From {\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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