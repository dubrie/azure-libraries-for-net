// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for PrimaryAggregationType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<PrimaryAggregationType>))]
    public class PrimaryAggregationType : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<PrimaryAggregationType>
    {
        public static readonly PrimaryAggregationType None = Parse("None");
        public static readonly PrimaryAggregationType Average = Parse("Average");
        public static readonly PrimaryAggregationType Count = Parse("Count");
        public static readonly PrimaryAggregationType Minimum = Parse("Minimum");
        public static readonly PrimaryAggregationType Maximum = Parse("Maximum");
        public static readonly PrimaryAggregationType Total = Parse("Total");
    }
}
