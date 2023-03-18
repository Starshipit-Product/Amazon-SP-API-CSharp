﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// A single item&#39;s buyer information.
    /// </summary>
    [DataContract]
    public partial class ItemBuyerInfo : IEquatable<ItemBuyerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBuyerInfo" /> class.
        /// </summary>
        /// <param name="buyerCustomizedInfo">Buyer information for custom orders from the Amazon Custom program..</param>
        /// <param name="giftWrapPrice">The gift wrap price of the item..</param>
        /// <param name="giftWrapTax">The tax on the gift wrap price..</param>
        /// <param name="giftMessageText">A gift message provided by the buyer..</param>
        /// <param name="giftWrapLevel">The gift wrap level specified by the buyer..</param>
        public ItemBuyerInfo(BuyerCustomizedInfoDetail buyerCustomizedInfo = default(BuyerCustomizedInfoDetail), Money giftWrapPrice = default(Money), Money giftWrapTax = default(Money), string giftMessageText = default(string), string giftWrapLevel = default(string))
        {
            this.BuyerCustomizedInfo = buyerCustomizedInfo;
            this.GiftWrapPrice = giftWrapPrice;
            this.GiftWrapTax = giftWrapTax;
            this.GiftMessageText = giftMessageText;
            this.GiftWrapLevel = giftWrapLevel;
        }

        /// <summary>
        /// Buyer information for custom orders from the Amazon Custom program.
        /// </summary>
        /// <value>Buyer information for custom orders from the Amazon Custom program.</value>
        [DataMember(Name = "BuyerCustomizedInfo", EmitDefaultValue = false)]
        public BuyerCustomizedInfoDetail BuyerCustomizedInfo { get; set; }

        /// <summary>
        /// The gift wrap price of the item.
        /// </summary>
        /// <value>The gift wrap price of the item.</value>
        [DataMember(Name = "GiftWrapPrice", EmitDefaultValue = false)]
        public Money GiftWrapPrice { get; set; }

        /// <summary>
        /// The tax on the gift wrap price.
        /// </summary>
        /// <value>The tax on the gift wrap price.</value>
        [DataMember(Name = "GiftWrapTax", EmitDefaultValue = false)]
        public Money GiftWrapTax { get; set; }

        /// <summary>
        /// A gift message provided by the buyer.
        /// </summary>
        /// <value>A gift message provided by the buyer.</value>
        [DataMember(Name = "GiftMessageText", EmitDefaultValue = false)]
        public string GiftMessageText { get; set; }

        /// <summary>
        /// The gift wrap level specified by the buyer.
        /// </summary>
        /// <value>The gift wrap level specified by the buyer.</value>
        [DataMember(Name = "GiftWrapLevel", EmitDefaultValue = false)]
        public string GiftWrapLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemBuyerInfo {\n");
            sb.Append("  BuyerCustomizedInfo: ").Append(BuyerCustomizedInfo).Append("\n");
            sb.Append("  GiftWrapPrice: ").Append(GiftWrapPrice).Append("\n");
            sb.Append("  GiftWrapTax: ").Append(GiftWrapTax).Append("\n");
            sb.Append("  GiftMessageText: ").Append(GiftMessageText).Append("\n");
            sb.Append("  GiftWrapLevel: ").Append(GiftWrapLevel).Append("\n");
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
            return this.Equals(input as ItemBuyerInfo);
        }

        /// <summary>
        /// Returns true if ItemBuyerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemBuyerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemBuyerInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BuyerCustomizedInfo == input.BuyerCustomizedInfo ||
                    (this.BuyerCustomizedInfo != null &&
                    this.BuyerCustomizedInfo.Equals(input.BuyerCustomizedInfo))
                ) &&
                (
                    this.GiftWrapPrice == input.GiftWrapPrice ||
                    (this.GiftWrapPrice != null &&
                    this.GiftWrapPrice.Equals(input.GiftWrapPrice))
                ) &&
                (
                    this.GiftWrapTax == input.GiftWrapTax ||
                    (this.GiftWrapTax != null &&
                    this.GiftWrapTax.Equals(input.GiftWrapTax))
                ) &&
                (
                    this.GiftMessageText == input.GiftMessageText ||
                    (this.GiftMessageText != null &&
                    this.GiftMessageText.Equals(input.GiftMessageText))
                ) &&
                (
                    this.GiftWrapLevel == input.GiftWrapLevel ||
                    (this.GiftWrapLevel != null &&
                    this.GiftWrapLevel.Equals(input.GiftWrapLevel))
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
                if (this.BuyerCustomizedInfo != null)
                    hashCode = hashCode * 59 + this.BuyerCustomizedInfo.GetHashCode();
                if (this.GiftWrapPrice != null)
                    hashCode = hashCode * 59 + this.GiftWrapPrice.GetHashCode();
                if (this.GiftWrapTax != null)
                    hashCode = hashCode * 59 + this.GiftWrapTax.GetHashCode();
                if (this.GiftMessageText != null)
                    hashCode = hashCode * 59 + this.GiftMessageText.GetHashCode();
                if (this.GiftWrapLevel != null)
                    hashCode = hashCode * 59 + this.GiftWrapLevel.GetHashCode();
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