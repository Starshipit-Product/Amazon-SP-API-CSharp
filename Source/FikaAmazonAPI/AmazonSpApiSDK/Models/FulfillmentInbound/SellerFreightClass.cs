/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// The freight class of the shipment. For information about determining the freight class, contact the carrier.
    /// </summary>
    /// <value>The freight class of the shipment. For information about determining the freight class, contact the carrier.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum SellerFreightClass
    {

        /// <summary>
        /// Enum _50 for value: 50
        /// </summary>
        [EnumMember(Value = "50")]
        _50 = 1,

        /// <summary>
        /// Enum _55 for value: 55
        /// </summary>
        [EnumMember(Value = "55")]
        _55 = 2,

        /// <summary>
        /// Enum _60 for value: 60
        /// </summary>
        [EnumMember(Value = "60")]
        _60 = 3,

        /// <summary>
        /// Enum _65 for value: 65
        /// </summary>
        [EnumMember(Value = "65")]
        _65 = 4,

        /// <summary>
        /// Enum _70 for value: 70
        /// </summary>
        [EnumMember(Value = "70")]
        _70 = 5,

        /// <summary>
        /// Enum _775 for value: 77.5
        /// </summary>
        [EnumMember(Value = "77.5")]
        _775 = 6,

        /// <summary>
        /// Enum _85 for value: 85
        /// </summary>
        [EnumMember(Value = "85")]
        _85 = 7,

        /// <summary>
        /// Enum _925 for value: 92.5
        /// </summary>
        [EnumMember(Value = "92.5")]
        _925 = 8,

        /// <summary>
        /// Enum _100 for value: 100
        /// </summary>
        [EnumMember(Value = "100")]
        _100 = 9,

        /// <summary>
        /// Enum _110 for value: 110
        /// </summary>
        [EnumMember(Value = "110")]
        _110 = 10,

        /// <summary>
        /// Enum _125 for value: 125
        /// </summary>
        [EnumMember(Value = "125")]
        _125 = 11,

        /// <summary>
        /// Enum _150 for value: 150
        /// </summary>
        [EnumMember(Value = "150")]
        _150 = 12,

        /// <summary>
        /// Enum _175 for value: 175
        /// </summary>
        [EnumMember(Value = "175")]
        _175 = 13,

        /// <summary>
        /// Enum _200 for value: 200
        /// </summary>
        [EnumMember(Value = "200")]
        _200 = 14,

        /// <summary>
        /// Enum _250 for value: 250
        /// </summary>
        [EnumMember(Value = "250")]
        _250 = 15,

        /// <summary>
        /// Enum _300 for value: 300
        /// </summary>
        [EnumMember(Value = "300")]
        _300 = 16,

        /// <summary>
        /// Enum _400 for value: 400
        /// </summary>
        [EnumMember(Value = "400")]
        _400 = 17,

        /// <summary>
        /// Enum _500 for value: 500
        /// </summary>
        [EnumMember(Value = "500")]
        _500 = 18
    }

}
