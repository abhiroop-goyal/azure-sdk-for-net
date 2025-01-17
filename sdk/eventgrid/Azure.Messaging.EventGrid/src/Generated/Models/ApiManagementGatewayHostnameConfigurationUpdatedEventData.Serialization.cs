// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementGatewayHostnameConfigurationUpdatedEventDataConverter))]
    public partial class ApiManagementGatewayHostnameConfigurationUpdatedEventData
    {
        internal static ApiManagementGatewayHostnameConfigurationUpdatedEventData DeserializeApiManagementGatewayHostnameConfigurationUpdatedEventData(JsonElement element)
        {
            Optional<string> resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementGatewayHostnameConfigurationUpdatedEventData(resourceUri.Value);
        }

        internal partial class ApiManagementGatewayHostnameConfigurationUpdatedEventDataConverter : JsonConverter<ApiManagementGatewayHostnameConfigurationUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementGatewayHostnameConfigurationUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementGatewayHostnameConfigurationUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementGatewayHostnameConfigurationUpdatedEventData(document.RootElement);
            }
        }
    }
}
