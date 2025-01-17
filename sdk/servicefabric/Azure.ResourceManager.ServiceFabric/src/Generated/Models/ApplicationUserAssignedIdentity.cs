// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The ApplicationUserAssignedIdentity. </summary>
    public partial class ApplicationUserAssignedIdentity
    {
        /// <summary> Initializes a new instance of ApplicationUserAssignedIdentity. </summary>
        /// <param name="name"> The friendly name of user assigned identity. </param>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ApplicationUserAssignedIdentity(string name, Guid principalId)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            PrincipalId = principalId;
        }

        /// <summary> The friendly name of user assigned identity. </summary>
        public string Name { get; set; }
        /// <summary> The principal id of user assigned identity. </summary>
        public Guid PrincipalId { get; set; }
    }
}
