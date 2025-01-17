// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisEnvironment
    {
        internal static SynapseSsisEnvironment DeserializeSynapseSsisEnvironment(JsonElement element)
        {
            Optional<long> folderId = default;
            Optional<IReadOnlyList<SynapseSsisVariable>> variables = default;
            SynapseSsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("variables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SynapseSsisVariable> array = new List<SynapseSsisVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisVariable.DeserializeSynapseSsisVariable(item));
                    }
                    variables = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SynapseSsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseSsisEnvironment(type, Optional.ToNullable(id), name.Value, description.Value, Optional.ToNullable(folderId), Optional.ToList(variables));
        }
    }
}
