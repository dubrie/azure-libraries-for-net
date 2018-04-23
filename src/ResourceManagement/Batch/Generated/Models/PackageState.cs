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
    /// Defines values for PackageState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageState
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Unmapped")]
        Unmapped
    }
    internal static class PackageStateEnumExtension
    {
        internal static string ToSerializedValue(this PackageState? value)
        {
            return value == null ? null : ((PackageState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PackageState value)
        {
            switch( value )
            {
                case PackageState.Pending:
                    return "Pending";
                case PackageState.Active:
                    return "Active";
                case PackageState.Unmapped:
                    return "Unmapped";
            }
            return null;
        }

        internal static PackageState? ParsePackageState(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return PackageState.Pending;
                case "Active":
                    return PackageState.Active;
                case "Unmapped":
                    return PackageState.Unmapped;
            }
            return null;
        }
    }
}
