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

namespace Mita.Notifications.Client.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error content (body json object)
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public object ErrorContent { get; private set; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public Multimap<string, string> Headers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        public ApiException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        /// <param name="headers">HTTP Headers.</param>
        public ApiException(int errorCode, string message, object errorContent = null, Multimap<string, string> headers = null) : base(message)
        {
            this.ErrorCode = errorCode;
            this.ErrorContent = errorContent;
            this.Headers = headers;
        }
    }

}
