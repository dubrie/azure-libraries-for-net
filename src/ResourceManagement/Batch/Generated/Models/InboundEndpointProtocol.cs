// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InboundEndpointProtocol.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InboundEndpointProtocol
    {
        [EnumMember(Value = "TCP")]
        TCP,
        [EnumMember(Value = "UDP")]
        UDP
    }
    internal static class InboundEndpointProtocolEnumExtension
    {
        internal static string ToSerializedValue(this InboundEndpointProtocol? value)
        {
            return value == null ? null : ((InboundEndpointProtocol)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this InboundEndpointProtocol value)
        {
            switch( value )
            {
                case InboundEndpointProtocol.TCP:
                    return "TCP";
                case InboundEndpointProtocol.UDP:
                    return "UDP";
            }
            return null;
        }

        internal static InboundEndpointProtocol? ParseInboundEndpointProtocol(this string value)
        {
            switch( value )
            {
                case "TCP":
                    return InboundEndpointProtocol.TCP;
                case "UDP":
                    return InboundEndpointProtocol.UDP;
            }
            return null;
        }
    }
}
