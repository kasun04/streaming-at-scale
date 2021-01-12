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
    using System.Linq;

    /// <summary>
    /// The time range to the left and right of the search span to be used for
    /// Interpolation. This is helpful in scenarios where the data points are
    /// missing close to the start or end of the input search span. Can be
    /// null.
    /// </summary>
    public partial class InterpolationBoundary
    {
        /// <summary>
        /// Initializes a new instance of the InterpolationBoundary class.
        /// </summary>
        public InterpolationBoundary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InterpolationBoundary class.
        /// </summary>
        public InterpolationBoundary(System.TimeSpan? span = default(System.TimeSpan?))
        {
            Span = span;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "span")]
        public System.TimeSpan? Span { get; set; }

    }
}
