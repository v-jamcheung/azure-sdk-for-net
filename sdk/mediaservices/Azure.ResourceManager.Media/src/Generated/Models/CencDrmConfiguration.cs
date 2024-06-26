// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify DRM configurations of CommonEncryptionCenc scheme in Streaming Policy. </summary>
    public partial class CencDrmConfiguration
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

        /// <summary> Initializes a new instance of <see cref="CencDrmConfiguration"/>. </summary>
        public CencDrmConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CencDrmConfiguration"/>. </summary>
        /// <param name="playReady"> PlayReady configurations. </param>
        /// <param name="widevine"> Widevine configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CencDrmConfiguration(StreamingPolicyPlayReadyConfiguration playReady, StreamingPolicyWidevineConfiguration widevine, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PlayReady = playReady;
            Widevine = widevine;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> PlayReady configurations. </summary>
        public StreamingPolicyPlayReadyConfiguration PlayReady { get; set; }
        /// <summary> Widevine configurations. </summary>
        internal StreamingPolicyWidevineConfiguration Widevine { get; set; }
        /// <summary> Template for the URL of the custom service delivering licenses to end user players.  Not required when using Azure Media Services for issuing licenses.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </summary>
        public string WidevineCustomLicenseAcquisitionUriTemplate
        {
            get => Widevine is null ? default : Widevine.CustomLicenseAcquisitionUriTemplate;
            set
            {
                if (Widevine is null)
                    Widevine = new StreamingPolicyWidevineConfiguration();
                Widevine.CustomLicenseAcquisitionUriTemplate = value;
            }
        }
    }
}
