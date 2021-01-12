// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A particular API error with an error code and a message.
    /// </summary>
    public partial class TsiErrorBody
    {
        /// <summary>
        /// Initializes a new instance of the TsiErrorBody class.
        /// </summary>
        public TsiErrorBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TsiErrorBody class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="code">Language-independent, human-readable string that
        /// defines a service-specific error code. This code serves as a more
        /// specific indicator for the HTTP error code specified in the
        /// response. Can be used to programmatically handle specific error
        /// cases.</param>
        /// <param name="message">Human-readable, language-independent
        /// representation of the error. It is intended as an aid to developers
        /// and is not suitable for exposure to end users.</param>
        /// <param name="target">Target of the particular error (for example,
        /// the name of the property in error). May be null.</param>
        /// <param name="innerError">Contains more specific error that narrows
        /// down the cause. May be null.</param>
        /// <param name="details">Contains additional error information. May be
        /// null.</param>
        public TsiErrorBody(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string code = default(string), string message = default(string), string target = default(string), TsiErrorBody innerError = default(TsiErrorBody), IList<TsiErrorDetails> details = default(IList<TsiErrorDetails>))
        {
            AdditionalProperties = additionalProperties;
            Code = code;
            Message = message;
            Target = target;
            InnerError = innerError;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets language-independent, human-readable string that defines a
        /// service-specific error code. This code serves as a more specific
        /// indicator for the HTTP error code specified in the response. Can be
        /// used to programmatically handle specific error cases.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets human-readable, language-independent representation of the
        /// error. It is intended as an aid to developers and is not suitable
        /// for exposure to end users.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets target of the particular error (for example, the name of the
        /// property in error). May be null.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

        /// <summary>
        /// Gets contains more specific error that narrows down the cause. May
        /// be null.
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public TsiErrorBody InnerError { get; private set; }

        /// <summary>
        /// Gets contains additional error information. May be null.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<TsiErrorDetails> Details { get; private set; }

    }
}
