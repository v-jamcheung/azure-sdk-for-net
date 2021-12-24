// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobSupportedAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobSupportedAction
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "Cancellable")]
        Cancellable,
        [EnumMember(Value = "Retriable")]
        Retriable
    }
    internal static class JobSupportedActionEnumExtension
    {
        internal static string ToSerializedValue(this JobSupportedAction? value)
        {
            return value == null ? null : ((JobSupportedAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobSupportedAction value)
        {
            switch( value )
            {
                case JobSupportedAction.Invalid:
                    return "Invalid";
                case JobSupportedAction.Cancellable:
                    return "Cancellable";
                case JobSupportedAction.Retriable:
                    return "Retriable";
            }
            return null;
        }

        internal static JobSupportedAction? ParseJobSupportedAction(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return JobSupportedAction.Invalid;
                case "Cancellable":
                    return JobSupportedAction.Cancellable;
                case "Retriable":
                    return JobSupportedAction.Retriable;
            }
            return null;
        }
    }
}
