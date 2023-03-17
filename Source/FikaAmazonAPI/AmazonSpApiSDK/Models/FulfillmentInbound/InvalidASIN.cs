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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// InvalidASIN
    /// </summary>
    [DataContract]
    public partial class InvalidASIN : IEquatable<InvalidASIN>, IValidatableObject
    {
        /// <summary>
        /// The reason that the ASIN is invalid.
        /// </summary>
        /// <value>The reason that the ASIN is invalid.</value>
        [DataMember(Name = "ErrorReason", EmitDefaultValue = false)]
        public ErrorReason? ErrorReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidASIN" /> class.
        /// </summary>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN) of the item..</param>
        /// <param name="errorReason">The reason that the ASIN is invalid..</param>
        public InvalidASIN(string aSIN = default(string), ErrorReason? errorReason = default(ErrorReason?))
        {
            this.ASIN = aSIN;
            this.ErrorReason = errorReason;
        }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvalidASIN {\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
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
            return this.Equals(input as InvalidASIN);
        }

        /// <summary>
        /// Returns true if InvalidASIN instances are equal
        /// </summary>
        /// <param name="input">Instance of InvalidASIN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvalidASIN input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ASIN == input.ASIN ||
                    (this.ASIN != null &&
                    this.ASIN.Equals(input.ASIN))
                ) &&
                (
                    this.ErrorReason == input.ErrorReason ||
                    (this.ErrorReason != null &&
                    this.ErrorReason.Equals(input.ErrorReason))
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
                if (this.ASIN != null)
                    hashCode = hashCode * 59 + this.ASIN.GetHashCode();
                if (this.ErrorReason != null)
                    hashCode = hashCode * 59 + this.ErrorReason.GetHashCode();
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