/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// Maps the additional seller input to the definition. The key to the map is the field name.
    /// </summary>
    [DataContract]
    public partial class AdditionalInputs : IEquatable<AdditionalInputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalInputs" /> class.
        /// </summary>
        /// <param name="AdditionalInputFieldName">The field name..</param>
        /// <param name="SellerInputDefinition">SellerInputDefinition.</param>
        public AdditionalInputs(string AdditionalInputFieldName = default(string), SellerInputDefinition SellerInputDefinition = default(SellerInputDefinition))
        {
            this.AdditionalInputFieldName = AdditionalInputFieldName;
            this.SellerInputDefinition = SellerInputDefinition;
        }

        /// <summary>
        /// The field name.
        /// </summary>
        /// <value>The field name.</value>
        [DataMember(Name = "AdditionalInputFieldName", EmitDefaultValue = false)]
        public string AdditionalInputFieldName { get; set; }

        /// <summary>
        /// Gets or Sets SellerInputDefinition
        /// </summary>
        [DataMember(Name = "SellerInputDefinition", EmitDefaultValue = false)]
        public SellerInputDefinition SellerInputDefinition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalInputs {\n");
            sb.Append("  AdditionalInputFieldName: ").Append(AdditionalInputFieldName).Append("\n");
            sb.Append("  SellerInputDefinition: ").Append(SellerInputDefinition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as AdditionalInputs);
        }

        /// <summary>
        /// Returns true if AdditionalInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalInputs input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdditionalInputFieldName == input.AdditionalInputFieldName ||
                    (this.AdditionalInputFieldName != null &&
                    this.AdditionalInputFieldName.Equals(input.AdditionalInputFieldName))
                ) &&
                (
                    this.SellerInputDefinition == input.SellerInputDefinition ||
                    (this.SellerInputDefinition != null &&
                    this.SellerInputDefinition.Equals(input.SellerInputDefinition))
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
                if (this.AdditionalInputFieldName != null)
                    hashCode = hashCode * 59 + this.AdditionalInputFieldName.GetHashCode();
                if (this.SellerInputDefinition != null)
                    hashCode = hashCode * 59 + this.SellerInputDefinition.GetHashCode();
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
