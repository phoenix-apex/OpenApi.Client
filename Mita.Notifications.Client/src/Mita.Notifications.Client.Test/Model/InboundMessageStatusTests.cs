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
///  Class for testing InboundMessageStatus
/// </summary>
/// <remarks>
/// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
/// Please update the test case below to test the model.
/// </remarks>
public class InboundMessageStatusTests : IDisposable
{
    // TODO uncomment below to declare an instance variable for InboundMessageStatus
    //private InboundMessageStatus instance;

    public InboundMessageStatusTests()
    {
            // TODO uncomment below to create an instance of InboundMessageStatus
            //instance = new InboundMessageStatus();
        }

    public void Dispose()
    {
            // Cleanup when everything is done.
        }

    /// <summary>
    /// Test an instance of InboundMessageStatus
    /// </summary>
    [Fact]
    public void InboundMessageStatusInstanceTest()
    {
            // TODO uncomment below to test "IsType" InboundMessageStatus
            //Assert.IsType<InboundMessageStatus>(instance);
        }
}