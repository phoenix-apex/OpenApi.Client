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
    /// Product
    /// </summary>
    [DataContract(Name = "Product")]
    public class Product : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Product() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="productDescription">productDescription (required).</param>
        /// <param name="countryOfManufacture">Country of manufacture specifed as a two letter ISO code (required).</param>
        /// <param name="hSCode">hSCode.</param>
        /// <param name="productUnitValue">productUnitValue.</param>
        /// <param name="currency">If left unspecified then GBP will be used..</param>
        /// <param name="productUnitWeight">Product weight specified in KG.</param>
        /// <param name="productQuantity">productQuantity.</param>
        public Product(string productDescription = default(string), string countryOfManufacture = default(string), string hSCode = default(string), double productUnitValue = default(double), string currency = default(string), double productUnitWeight = default(double), int productQuantity = default(int))
        {
            // to ensure "productDescription" is required (not null)
            if (productDescription == null)
            {
                throw new ArgumentNullException("productDescription is a required property for Product and cannot be null");
            }
            ProductDescription = productDescription;
            // to ensure "countryOfManufacture" is required (not null)
            if (countryOfManufacture == null)
            {
                throw new ArgumentNullException("countryOfManufacture is a required property for Product and cannot be null");
            }
            CountryOfManufacture = countryOfManufacture;
            HSCode = hSCode;
            ProductUnitValue = productUnitValue;
            Currency = currency;
            ProductUnitWeight = productUnitWeight;
            ProductQuantity = productQuantity;
        }

        /// <summary>
        /// Gets or Sets ProductDescription
        /// </summary>
        [DataMember(Name = "ProductDescription", IsRequired = true, EmitDefaultValue = true)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Country of manufacture specifed as a two letter ISO code
        /// </summary>
        /// <value>Country of manufacture specifed as a two letter ISO code</value>
        [DataMember(Name = "CountryOfManufacture", IsRequired = true, EmitDefaultValue = true)]
        public string CountryOfManufacture { get; set; }

        /// <summary>
        /// Gets or Sets HSCode
        /// </summary>
        [DataMember(Name = "HSCode", EmitDefaultValue = true)]
        public string HSCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductUnitValue
        /// </summary>
        [DataMember(Name = "ProductUnitValue", EmitDefaultValue = true)]
        public double ProductUnitValue { get; set; }

        /// <summary>
        /// If left unspecified then GBP will be used.
        /// </summary>
        /// <value>If left unspecified then GBP will be used.</value>
        [DataMember(Name = "Currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Product weight specified in KG
        /// </summary>
        /// <value>Product weight specified in KG</value>
        [DataMember(Name = "ProductUnitWeight", EmitDefaultValue = true)]
        public double ProductUnitWeight { get; set; }

        /// <summary>
        /// Gets or Sets ProductQuantity
        /// </summary>
        [DataMember(Name = "ProductQuantity", EmitDefaultValue = true)]
        public int ProductQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  CountryOfManufacture: ").Append(CountryOfManufacture).Append("\n");
            sb.Append("  HSCode: ").Append(HSCode).Append("\n");
            sb.Append("  ProductUnitValue: ").Append(ProductUnitValue).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ProductUnitWeight: ").Append(ProductUnitWeight).Append("\n");
            sb.Append("  ProductQuantity: ").Append(ProductQuantity).Append("\n");
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
            // ProductDescription (string) maxLength
            if (ProductDescription != null && ProductDescription.Length > 150)
            {
                yield return new ValidationResult("Invalid value for ProductDescription, length must be less than 150.", new [] { "ProductDescription" });
            }

            // ProductDescription (string) minLength
            if (ProductDescription != null && ProductDescription.Length < 2)
            {
                yield return new ValidationResult("Invalid value for ProductDescription, length must be greater than 2.", new [] { "ProductDescription" });
            }

            // CountryOfManufacture (string) minLength
            if (CountryOfManufacture != null && CountryOfManufacture.Length < 1)
            {
                yield return new ValidationResult("Invalid value for CountryOfManufacture, length must be greater than 1.", new [] { "CountryOfManufacture" });
            }

            // ProductUnitValue (double) minimum
            if (ProductUnitValue < (double)0)
            {
                yield return new ValidationResult("Invalid value for ProductUnitValue, must be a value greater than or equal to 0.", new [] { "ProductUnitValue" });
            }

            // ProductUnitWeight (double) maximum
            if (ProductUnitWeight > (double)1000)
            {
                yield return new ValidationResult("Invalid value for ProductUnitWeight, must be a value less than or equal to 1000.", new [] { "ProductUnitWeight" });
            }

            // ProductUnitWeight (double) minimum
            if (ProductUnitWeight < (double)0)
            {
                yield return new ValidationResult("Invalid value for ProductUnitWeight, must be a value greater than or equal to 0.", new [] { "ProductUnitWeight" });
            }

            // ProductQuantity (int) minimum
            if (ProductQuantity < (int)0)
            {
                yield return new ValidationResult("Invalid value for ProductQuantity, must be a value greater than or equal to 0.", new [] { "ProductQuantity" });
            }

            yield break;
        }
    }

}