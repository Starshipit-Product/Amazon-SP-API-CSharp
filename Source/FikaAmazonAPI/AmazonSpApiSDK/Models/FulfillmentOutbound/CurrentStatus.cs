/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// The current delivery status of the package.
    /// </summary>
    /// <value>The current delivery status of the package.</value>

    public enum CurrentStatus
    {

        /// <summary>
        /// Enum INTRANSIT for value: IN_TRANSIT
        /// </summary>

        INTRANSIT,

        /// <summary>
        /// Enum INTRANSIT for value: IN_TRANSIT
        /// </summary>

        IN_TRANSIT,

        /// <summary>
        /// Enum DELIVERED for value: DELIVERED
        /// </summary>

        DELIVERED,

        /// <summary>
        /// Enum RETURNING for value: RETURNING
        /// </summary>

        RETURNING,

        /// <summary>
        /// Enum RETURNED for value: RETURNED
        /// </summary>

        RETURNED,

        /// <summary>
        /// Enum UNDELIVERABLE for value: UNDELIVERABLE
        /// </summary>

        UNDELIVERABLE,

        /// <summary>
        /// Enum DELAYED for value: DELAYED
        /// </summary>

        DELAYED,

        /// <summary>
        /// Enum AVAILABLEFORPICKUP for value: AVAILABLE_FOR_PICKUP
        /// </summary>

        AVAILABLEFORPICKUP,

        /// <summary>
        /// Enum CUSTOMERACTION for value: CUSTOMER_ACTION
        /// </summary>

        CUSTOMERACTION
    }

}
