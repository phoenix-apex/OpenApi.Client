/*
 * MITA Notifications Platform REST API
 *
 * The Notifications REST API allows programmatic access to the Notifications Portal message funtionality. To use the REST API, you will need a Notifications Portal Account and an API key and secret. You can generate from the Notifications Portal using the API Key Manager.The REST API takes full advantage of all HTTP headers. Each part of a request and response is meaningful, including the request method (GET/POST, etc.), the individual headers (Location, Content-Type, Accept, etc.), and the response status code (200, 400, 404, etc.). Use of this API assumes a working knowledge of these HTTP components, and general use of RESTful web APIs.
 *
 * The version of the OpenAPI document: v1
 * Contact: notifications.mita@gov.mt
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Mita.Notifications.Client.Model;
using Mita.Notifications.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Mita.Notifications.Client.Test.Model;

/// <summary>
///  Class for testing ApiKey
/// </summary>
/// <remarks>
/// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
/// Please update the test case below to test the model.
/// </remarks>
public class ApiKeyTests : IDisposable
{
    // TODO uncomment below to declare an instance variable for ApiKey
    //private ApiKey instance;

    public ApiKeyTests()
    {
            // TODO uncomment below to create an instance of ApiKey
            //instance = new ApiKey();
        }

    public void Dispose()
    {
            // Cleanup when everything is done.
        }

    /// <summary>
    /// Test an instance of ApiKey
    /// </summary>
    [Fact]
    public void ApiKeyInstanceTest()
    {
            // TODO uncomment below to test "IsType" ApiKey
            //Assert.IsType<ApiKey>(instance);
        }

    /// <summary>
    /// Test the property 'Name'
    /// </summary>
    [Fact]
    public void NameTest()
    {
            // TODO unit test for the property 'Name'
        }

    /// <summary>
    /// Test the property 'Key'
    /// </summary>
    [Fact]
    public void KeyTest()
    {
            // TODO unit test for the property 'Key'
        }

    /// <summary>
    /// Test the property 'Secret'
    /// </summary>
    [Fact]
    public void SecretTest()
    {
            // TODO unit test for the property 'Secret'
        }

    /// <summary>
    /// Test the property 'ExpiryDate'
    /// </summary>
    [Fact]
    public void ExpiryDateTest()
    {
            // TODO unit test for the property 'ExpiryDate'
        }
}