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
/// Defines Language
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Language
{
    /// <summary>
    /// Enum En for value: en
    /// </summary>
    [EnumMember(Value = "en")]
    En = 1,

    /// <summary>
    /// Enum It for value: it
    /// </summary>
    [EnumMember(Value = "it")]
    It = 2,

    /// <summary>
    /// Enum De for value: de
    /// </summary>
    [EnumMember(Value = "de")]
    De = 3,

    /// <summary>
    /// Enum Fr for value: fr
    /// </summary>
    [EnumMember(Value = "fr")]
    Fr = 4,

    /// <summary>
    /// Enum Es for value: es
    /// </summary>
    [EnumMember(Value = "es")]
    Es = 5,

    /// <summary>
    /// Enum Mt for value: mt
    /// </summary>
    [EnumMember(Value = "mt")]
    Mt = 6
}