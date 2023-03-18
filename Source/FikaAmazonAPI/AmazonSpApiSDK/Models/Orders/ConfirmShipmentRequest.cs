﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The request schema for an shipment confirmation.
    /// </summary>
    [DataContract]
    public partial class ConfirmShipmentRequest : IEquatable<ConfirmShipmentRequest>, IValidatableObject
    {
        /// <summary>
        /// The cod collection method, support in JP only. 
        /// </summary>
        /// <value>The cod collection method, support in JP only. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodCollectionMethodEnum
        {

            /// <summary>
            /// Enum DirectPayment for value: DirectPayment
            /// </summary>
            [EnumMember(Value = "DirectPayment")]
            DirectPayment = 1
        }

        /// <summary>
        /// The cod collection method, support in JP only. 
        /// </summary>
        /// <value>The cod collection method, support in JP only. </value>
        [DataMember(Name = "codCollectionMethod", EmitDefaultValue = false)]
        public CodCollectionMethodEnum? CodCollectionMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmShipmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConfirmShipmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmShipmentRequest" /> class.
        /// </summary>
        /// <param name="packageDetail">packageDetail (required).</param>
        /// <param name="codCollectionMethod">The cod collection method, support in JP only. .</param>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        public ConfirmShipmentRequest(PackageDetail packageDetail = default(PackageDetail), CodCollectionMethodEnum? codCollectionMethod = default(CodCollectionMethodEnum?), string marketplaceId = default(string))
        {
            // to ensure "packageDetail" is required (not null)
            if (packageDetail == null)
            {
                throw new InvalidDataException("packageDetail is a required property for ConfirmShipmentRequest and cannot be null");
            }
            else
            {
                this.PackageDetail = packageDetail;
            }
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ConfirmShipmentRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            this.CodCollectionMethod = codCollectionMethod;
        }

        /// <summary>
        /// Gets or Sets PackageDetail
        /// </summary>
        [DataMember(Name = "packageDetail", EmitDefaultValue = false)]
        public PackageDetail PackageDetail { get; set; }


        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmShipmentRequest {\n");
            sb.Append("  PackageDetail: ").Append(PackageDetail).Append("\n");
            sb.Append("  CodCollectionMethod: ").Append(CodCollectionMethod).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
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
            return this.Equals(input as ConfirmShipmentRequest);
        }

        /// <summary>
        /// Returns true if ConfirmShipmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmShipmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmShipmentRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PackageDetail == input.PackageDetail ||
                    (this.PackageDetail != null &&
                    this.PackageDetail.Equals(input.PackageDetail))
                ) &&
                (
                    this.CodCollectionMethod == input.CodCollectionMethod ||
                    (this.CodCollectionMethod != null &&
                    this.CodCollectionMethod.Equals(input.CodCollectionMethod))
                ) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
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
                if (this.PackageDetail != null)
                    hashCode = hashCode * 59 + this.PackageDetail.GetHashCode();
                if (this.CodCollectionMethod != null)
                    hashCode = hashCode * 59 + this.CodCollectionMethod.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
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