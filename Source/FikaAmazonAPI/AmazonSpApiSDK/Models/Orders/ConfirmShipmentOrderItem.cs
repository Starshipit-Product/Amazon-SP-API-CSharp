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
    /// A single order item.
    /// </summary>
    [DataContract]
    public partial class ConfirmShipmentOrderItem : IEquatable<ConfirmShipmentOrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmShipmentOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfirmShipmentOrderItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmShipmentOrderItem" /> class.
        /// </summary>
        /// <param name="orderItemId">The unique identifier of the order item. (required).</param>
        /// <param name="quantity">The quantity of the item. (required).</param>
        /// <param name="transparencyCodes">The list of transparency codes..</param>
        public ConfirmShipmentOrderItem(string orderItemId = default(string), int? quantity = default(int?), TransparencyCodeList transparencyCodes = default(TransparencyCodeList))
        {
            // to ensure "orderItemId" is required (not null)
            if (orderItemId == null)
            {
                throw new InvalidDataException("orderItemId is a required property for ConfirmShipmentOrderItem and cannot be null");
            }
            else
            {
                this.OrderItemId = orderItemId;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for ConfirmShipmentOrderItem and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            this.TransparencyCodes = transparencyCodes;
        }

        /// <summary>
        /// The unique identifier of the order item.
        /// </summary>
        /// <value>The unique identifier of the order item.</value>
        [DataMember(Name = "orderItemId", EmitDefaultValue = false)]
        public string OrderItemId { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        /// <value>The quantity of the item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The list of transparency codes.
        /// </summary>
        /// <value>The list of transparency codes.</value>
        [DataMember(Name = "transparencyCodes", EmitDefaultValue = false)]
        public TransparencyCodeList TransparencyCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmShipmentOrderItem {\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TransparencyCodes: ").Append(TransparencyCodes).Append("\n");
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
            return this.Equals(input as ConfirmShipmentOrderItem);
        }

        /// <summary>
        /// Returns true if ConfirmShipmentOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmShipmentOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmShipmentOrderItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OrderItemId == input.OrderItemId ||
                    (this.OrderItemId != null &&
                    this.OrderItemId.Equals(input.OrderItemId))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) &&
                (
                    this.TransparencyCodes == input.TransparencyCodes ||
                    (this.TransparencyCodes != null &&
                    this.TransparencyCodes.Equals(input.TransparencyCodes))
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
                if (this.OrderItemId != null)
                    hashCode = hashCode * 59 + this.OrderItemId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TransparencyCodes != null)
                    hashCode = hashCode * 59 + this.TransparencyCodes.GetHashCode();
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

