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
    /// Custom text for shipping labels.
    /// </summary>
    [DataContract]
    public partial class LabelCustomization : IEquatable<LabelCustomization>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets StandardIdForLabel
        /// </summary>
        [DataMember(Name = "StandardIdForLabel", EmitDefaultValue = false)]
        public StandardIdForLabel? StandardIdForLabel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelCustomization" /> class.
        /// </summary>
        /// <param name="CustomTextForLabel">CustomTextForLabel.</param>
        /// <param name="StandardIdForLabel">StandardIdForLabel.</param>
        public LabelCustomization(CustomTextForLabel CustomTextForLabel = default(CustomTextForLabel), StandardIdForLabel? StandardIdForLabel = default(StandardIdForLabel?))
        {
            this.CustomTextForLabel = CustomTextForLabel;
            this.StandardIdForLabel = StandardIdForLabel;
        }

        /// <summary>
        /// Gets or Sets CustomTextForLabel
        /// </summary>
        [DataMember(Name = "CustomTextForLabel", EmitDefaultValue = false)]
        public CustomTextForLabel CustomTextForLabel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelCustomization {\n");
            sb.Append("  CustomTextForLabel: ").Append(CustomTextForLabel).Append("\n");
            sb.Append("  StandardIdForLabel: ").Append(StandardIdForLabel).Append("\n");
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
            return this.Equals(input as LabelCustomization);
        }

        /// <summary>
        /// Returns true if LabelCustomization instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelCustomization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelCustomization input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CustomTextForLabel == input.CustomTextForLabel ||
                    (this.CustomTextForLabel != null &&
                    this.CustomTextForLabel.Equals(input.CustomTextForLabel))
                ) &&
                (
                    this.StandardIdForLabel == input.StandardIdForLabel ||
                    (this.StandardIdForLabel != null &&
                    this.StandardIdForLabel.Equals(input.StandardIdForLabel))
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
                if (this.CustomTextForLabel != null)
                    hashCode = hashCode * 59 + this.CustomTextForLabel.GetHashCode();
                if (this.StandardIdForLabel != null)
                    hashCode = hashCode * 59 + this.StandardIdForLabel.GetHashCode();
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
