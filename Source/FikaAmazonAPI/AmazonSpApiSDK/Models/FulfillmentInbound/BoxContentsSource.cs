/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Where the seller provided box contents information for a shipment.
    /// </summary>
    /// <value>Where the seller provided box contents information for a shipment.</value>

    public enum BoxContentsSource
    {

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>

        NONE,

        /// <summary>
        /// Enum FEED for value: FEED
        /// </summary>

        FEED,

        /// <summary>
        /// Enum _2DBARCODE for value: 2D_BARCODE
        /// </summary>
        [EnumMember(Value = "2D_BARCODE")]
        _2DBARCODE,

        /// <summary>
        /// Enum INTERACTIVE for value: INTERACTIVE
        /// </summary>

        INTERACTIVE
    }

}
