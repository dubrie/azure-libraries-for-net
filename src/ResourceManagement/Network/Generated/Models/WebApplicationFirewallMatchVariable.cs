// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for WebApplicationFirewallMatchVariable.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<WebApplicationFirewallMatchVariable>))]
    public class WebApplicationFirewallMatchVariable : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<WebApplicationFirewallMatchVariable>
    {
        public static readonly WebApplicationFirewallMatchVariable RemoteAddr = Parse("RemoteAddr");
        public static readonly WebApplicationFirewallMatchVariable RequestMethod = Parse("RequestMethod");
        public static readonly WebApplicationFirewallMatchVariable QueryString = Parse("QueryString");
        public static readonly WebApplicationFirewallMatchVariable PostArgs = Parse("PostArgs");
        public static readonly WebApplicationFirewallMatchVariable RequestUri = Parse("RequestUri");
        public static readonly WebApplicationFirewallMatchVariable RequestHeaders = Parse("RequestHeaders");
        public static readonly WebApplicationFirewallMatchVariable RequestBody = Parse("RequestBody");
        public static readonly WebApplicationFirewallMatchVariable RequestCookies = Parse("RequestCookies");
    }
}