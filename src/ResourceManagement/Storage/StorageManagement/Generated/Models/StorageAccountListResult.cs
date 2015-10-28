// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The list storage accounts operation response.
    /// </summary>
    public partial class StorageAccountListResult
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountListResult class.
        /// </summary>
        public StorageAccountListResult() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountListResult class.
        /// </summary>
        public StorageAccountListResult(IList<StorageAccount> value = default(IList<StorageAccount>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets the list of storage accounts and their properties.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<StorageAccount> Value { get; set; }

    }
}
