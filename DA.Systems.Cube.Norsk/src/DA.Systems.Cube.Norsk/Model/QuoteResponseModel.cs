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
    /// QuoteResponseModel
    /// </summary>
    [DataContract(Name = "QuoteResponseModel")]
    public class QuoteResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteResponseModel" /> class.
        /// </summary>
        /// <param name="quotesValidFrom">quotesValidFrom.</param>
        /// <param name="currency">currency.</param>
        /// <param name="quotes">quotes.</param>
        public QuoteResponseModel(DateTimeOffset quotesValidFrom = default(DateTimeOffset), string currency = default(string), List<Quote> quotes = default(List<Quote>))
        {
            QuotesValidFrom = quotesValidFrom;
            Currency = currency;
            Quotes = quotes;
        }

        /// <summary>
        /// Gets or Sets QuotesValidFrom
        /// </summary>
        [DataMember(Name = "QuotesValidFrom", EmitDefaultValue = true)]
        public DateTimeOffset QuotesValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuotes
        /// </summary>
        [DataMember(Name = "TotalQuotes", EmitDefaultValue = true)]
        public int TotalQuotes { get; private set; }

        /// <summary>
        /// Returns false as TotalQuotes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalQuotes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Quotes
        /// </summary>
        [DataMember(Name = "Quotes", EmitDefaultValue = true)]
        public List<Quote> Quotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteResponseModel {\n");
            sb.Append("  QuotesValidFrom: ").Append(QuotesValidFrom).Append("\n");
            sb.Append("  TotalQuotes: ").Append(TotalQuotes).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
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