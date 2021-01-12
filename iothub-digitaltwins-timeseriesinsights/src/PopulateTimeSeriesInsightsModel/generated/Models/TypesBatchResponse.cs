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
    /// Response of a single operation on a batch of time series types. Exactly
    /// one of "get", "put" or "delete" will be set.
    /// </summary>
    public partial class TypesBatchResponse
    {
        /// <summary>
        /// Initializes a new instance of the TypesBatchResponse class.
        /// </summary>
        public TypesBatchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypesBatchResponse class.
        /// </summary>
        /// <param name="get">List of types or error objects corresponding by
        /// position to the "get" array in the request. Type object is set when
        /// operation is successful and error object is set when operation is
        /// unsuccessful.</param>
        /// <param name="put">List of types or error objects corresponding by
        /// position to the "put" array in the request. Type object is set when
        /// operation is successful and error object is set when operation is
        /// unsuccessful.</param>
        /// <param name="delete">List of error objects corresponding by
        /// position to the "delete" array in the request - null when the
        /// operation is successful.</param>
        public TypesBatchResponse(IList<TimeSeriesTypeOrError> get = default(IList<TimeSeriesTypeOrError>), IList<TimeSeriesTypeOrError> put = default(IList<TimeSeriesTypeOrError>), IList<TsiErrorBody> delete = default(IList<TsiErrorBody>))
        {
            Get = get;
            Put = put;
            Delete = delete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of types or error objects corresponding by position to
        /// the "get" array in the request. Type object is set when operation
        /// is successful and error object is set when operation is
        /// unsuccessful.
        /// </summary>
        [JsonProperty(PropertyName = "get")]
        public IList<TimeSeriesTypeOrError> Get { get; private set; }

        /// <summary>
        /// Gets list of types or error objects corresponding by position to
        /// the "put" array in the request. Type object is set when operation
        /// is successful and error object is set when operation is
        /// unsuccessful.
        /// </summary>
        [JsonProperty(PropertyName = "put")]
        public IList<TimeSeriesTypeOrError> Put { get; private set; }

        /// <summary>
        /// Gets list of error objects corresponding by position to the
        /// "delete" array in the request - null when the operation is
        /// successful.
        /// </summary>
        [JsonProperty(PropertyName = "delete")]
        public IList<TsiErrorBody> Delete { get; private set; }

    }
}
