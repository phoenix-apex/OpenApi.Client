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
///  Class for testing UpdateSubscriberRequest
/// </summary>
/// <remarks>
/// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
/// Please update the test case below to test the model.
/// </remarks>
public class UpdateSubscriberRequestTests : IDisposable
{
    // TODO uncomment below to declare an instance variable for UpdateSubscriberRequest
    //private UpdateSubscriberRequest instance;

    public UpdateSubscriberRequestTests()
    {
            // TODO uncomment below to create an instance of UpdateSubscriberRequest
            //instance = new UpdateSubscriberRequest();
        }

    public void Dispose()
    {
            // Cleanup when everything is done.
        }

    /// <summary>
    /// Test an instance of UpdateSubscriberRequest
    /// </summary>
    [Fact]
    public void UpdateSubscriberRequestInstanceTest()
    {
            // TODO uncomment below to test "IsType" UpdateSubscriberRequest
            //Assert.IsType<UpdateSubscriberRequest>(instance);
        }

    /// <summary>
    /// Test the property 'Address'
    /// </summary>
    [Fact]
    public void AddressTest()
    {
            // TODO unit test for the property 'Address'
        }

    /// <summary>
    /// Test the property 'Locality'
    /// </summary>
    [Fact]
    public void LocalityTest()
    {
            // TODO unit test for the property 'Locality'
        }

    /// <summary>
    /// Test the property 'PostCode'
    /// </summary>
    [Fact]
    public void PostCodeTest()
    {
            // TODO unit test for the property 'PostCode'
        }

    /// <summary>
    /// Test the property 'PhoneNo'
    /// </summary>
    [Fact]
    public void PhoneNoTest()
    {
            // TODO unit test for the property 'PhoneNo'
        }

    /// <summary>
    /// Test the property 'PhoneNoAlt'
    /// </summary>
    [Fact]
    public void PhoneNoAltTest()
    {
            // TODO unit test for the property 'PhoneNoAlt'
        }

    /// <summary>
    /// Test the property 'Country'
    /// </summary>
    [Fact]
    public void CountryTest()
    {
            // TODO unit test for the property 'Country'
        }

    /// <summary>
    /// Test the property 'DisplayName'
    /// </summary>
    [Fact]
    public void DisplayNameTest()
    {
            // TODO unit test for the property 'DisplayName'
        }

    /// <summary>
    /// Test the property 'Title'
    /// </summary>
    [Fact]
    public void TitleTest()
    {
            // TODO unit test for the property 'Title'
        }

    /// <summary>
    /// Test the property 'FirstName'
    /// </summary>
    [Fact]
    public void FirstNameTest()
    {
            // TODO unit test for the property 'FirstName'
        }

    /// <summary>
    /// Test the property 'LastName'
    /// </summary>
    [Fact]
    public void LastNameTest()
    {
            // TODO unit test for the property 'LastName'
        }

    /// <summary>
    /// Test the property 'Email'
    /// </summary>
    [Fact]
    public void EmailTest()
    {
            // TODO unit test for the property 'Email'
        }

    /// <summary>
    /// Test the property 'MobileNo'
    /// </summary>
    [Fact]
    public void MobileNoTest()
    {
            // TODO unit test for the property 'MobileNo'
        }

    /// <summary>
    /// Test the property 'PreferredLanguage'
    /// </summary>
    [Fact]
    public void PreferredLanguageTest()
    {
            // TODO unit test for the property 'PreferredLanguage'
        }
}