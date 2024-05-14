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
    /// Defines QuoteSpecials
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuoteSpecials
    {
        /// <summary>
        /// Enum Pallet for value: Pallet
        /// </summary>
        [EnumMember(Value = "Pallet")]
        Pallet = 1,

        /// <summary>
        /// Enum Ddp for value: Ddp
        /// </summary>
        [EnumMember(Value = "Ddp")]
        Ddp = 2,

        /// <summary>
        /// Enum NonStackablePallet for value: NonStackablePallet
        /// </summary>
        [EnumMember(Value = "NonStackablePallet")]
        NonStackablePallet = 3
    }

}