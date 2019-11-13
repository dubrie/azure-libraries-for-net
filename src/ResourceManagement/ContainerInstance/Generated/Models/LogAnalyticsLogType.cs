// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Newtonsoft.Json;

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{

    /// <summary>
    /// Defines values for LogAnalyticsLogType.
    /// </summary>
    [JsonConverter(typeof(ExpandableStringEnumConverter<LogAnalyticsLogType>))]
    public class LogAnalyticsLogType : ExpandableStringEnum<LogAnalyticsLogType>
    {
        public static readonly LogAnalyticsLogType ContainerInsights = Parse("ContainerInsights");
        public static readonly LogAnalyticsLogType ContainerInstanceLogs = Parse("ContainerInstanceLogs");
    }
}
