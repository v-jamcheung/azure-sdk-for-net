// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// GraphQL API Resolver details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ResolverContract : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ResolverContract class.
        /// </summary>
        public ResolverContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResolverContract class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="displayName">Resolver Name.</param>
        /// <param name="path">Path is type/field being resolved.</param>
        /// <param name="description">Description of the resolver. May include
        /// HTML formatting tags.</param>
        public ResolverContract(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string path = default(string), string description = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Path = path;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resolver Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets path is type/field being resolved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets description of the resolver. May include HTML
        /// formatting tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName != null)
            {
                if (DisplayName.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 300);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
            }
            if (Path != null)
            {
                if (Path.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Path", 300);
                }
                if (Path.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Path", 1);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 1000);
                }
            }
        }
    }
}
