// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Status of a benefit utilization summaries report. Provides Async Benefit Utilization Summaries Request input, status, and report sas url. </summary>
    public partial class BenefitUtilizationSummariesOperationStatus
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BenefitUtilizationSummariesOperationStatus"/>. </summary>
        internal BenefitUtilizationSummariesOperationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BenefitUtilizationSummariesOperationStatus"/>. </summary>
        /// <param name="input"> Input given to create the benefit utilization summaries report. </param>
        /// <param name="status"> The status of the creation of the benefit utilization summaries report. </param>
        /// <param name="properties"> Contains sas url to the async benefit utilization summaries report and a date that the url is valid until. These values will be empty if the report is in a Running or Failed state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BenefitUtilizationSummariesOperationStatus(BenefitUtilizationSummariesContent input, OperationStatusType? status, AsyncOperationStatusProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            Status = status;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Input given to create the benefit utilization summaries report. </summary>
        public BenefitUtilizationSummariesContent Input { get; }
        /// <summary> The status of the creation of the benefit utilization summaries report. </summary>
        public OperationStatusType? Status { get; }
        /// <summary> Contains sas url to the async benefit utilization summaries report and a date that the url is valid until. These values will be empty if the report is in a Running or Failed state. </summary>
        public AsyncOperationStatusProperties Properties { get; }
    }
}
