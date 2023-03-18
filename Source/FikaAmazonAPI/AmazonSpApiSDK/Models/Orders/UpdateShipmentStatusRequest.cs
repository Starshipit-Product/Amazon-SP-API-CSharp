﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The request body for the updateShipmentStatus operation.
    /// </summary>
    [DataContract]
    public partial class UpdateShipmentStatusRequest : IEquatable<UpdateShipmentStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [DataMember(Name = "shipmentStatus", EmitDefaultValue = false)]
        public ShipmentStatus ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentStatusRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UpdateShipmentStatusRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentStatusRequest" /> class.
        /// </summary>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        /// <param name="shipmentStatus">shipmentStatus (required).</param>
        /// <param name="orderItems">orderItems.</param>
        public UpdateShipmentStatusRequest(string marketplaceId = default(string), ShipmentStatus shipmentStatus = default(ShipmentStatus), OrderItems orderItems = default(OrderItems))
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for UpdateShipmentStatusRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            // to ensure "shipmentStatus" is required (not null)
            if (shipmentStatus == null)
            {
                throw new InvalidDataException("shipmentStatus is a required property for UpdateShipmentStatusRequest and cannot be null");
            }
            else
            {
                this.ShipmentStatus = shipmentStatus;
            }
            this.OrderItems = orderItems;
        }

        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }


        /// <summary>
        /// Gets or Sets OrderItems
        /// </summary>
        [DataMember(Name = "orderItems", EmitDefaultValue = false)]
        public OrderItems OrderItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShipmentStatusRequest {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  OrderItems: ").Append(OrderItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateShipmentStatusRequest);
        }

        /// <summary>
        /// Returns true if UpdateShipmentStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateShipmentStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShipmentStatusRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.ShipmentStatus == input.ShipmentStatus ||
                    (this.ShipmentStatus != null &&
                    this.ShipmentStatus.Equals(input.ShipmentStatus))
                ) &&
                (
                    this.OrderItems == input.OrderItems ||
                    (this.OrderItems != null &&
                    this.OrderItems.Equals(input.OrderItems))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.ShipmentStatus != null)
                    hashCode = hashCode * 59 + this.ShipmentStatus.GetHashCode();
                if (this.OrderItems != null)
                    hashCode = hashCode * 59 + this.OrderItems.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}