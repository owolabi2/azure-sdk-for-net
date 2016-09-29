// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the RegenerateKey operation.
    /// </summary>
    public partial class BatchAccountRegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BatchAccountRegenerateKeyParameters class.
        /// </summary>
        public BatchAccountRegenerateKeyParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// BatchAccountRegenerateKeyParameters class.
        /// </summary>
        /// <param name="keyName">The type of account key to regenerate.
        /// Possible values include: 'Primary', 'Secondary'</param>
        public BatchAccountRegenerateKeyParameters(AccountKeyType keyName)
        {
            KeyName = keyName;
        }

        /// <summary>
        /// Gets or sets the type of account key to regenerate. Possible
        /// values include: 'Primary', 'Secondary'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyName")]
        public AccountKeyType KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}