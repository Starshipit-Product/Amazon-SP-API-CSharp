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
    /// Additional information required to purchase shipping.
    /// </summary>
    [DataContract]
    public partial class AdditionalSellerInput : IEquatable<AdditionalSellerInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalSellerInput" /> class.
        /// </summary>
        /// <param name="DataType">The data type of the additional information..</param>
        /// <param name="ValueAsString">The value when the data type is string..</param>
        /// <param name="ValueAsBoolean">The value when the data type is boolean..</param>
        /// <param name="ValueAsInteger">The value when the data type is integer..</param>
        /// <param name="ValueAsTimestamp">The value when the data type is a date-time formatted string..</param>
        /// <param name="ValueAsAddress">ValueAsAddress.</param>
        /// <param name="ValueAsWeight">ValueAsWeight.</param>
        /// <param name="ValueAsDimension">ValueAsDimension.</param>
        /// <param name="ValueAsCurrency">ValueAsCurrency.</param>
        public AdditionalSellerInput(string DataType = default(string), string ValueAsString = default(string), bool? ValueAsBoolean = default(bool?), int? ValueAsInteger = default(int?), Timestamp ValueAsTimestamp = default(Timestamp), Address ValueAsAddress = default(Address), Weight ValueAsWeight = default(Weight), Length ValueAsDimension = default(Length), CurrencyAmount ValueAsCurrency = default(CurrencyAmount))
        {
            this.DataType = DataType;
            this.ValueAsString = ValueAsString;
            this.ValueAsBoolean = ValueAsBoolean;
            this.ValueAsInteger = ValueAsInteger;
            this.ValueAsTimestamp = ValueAsTimestamp;
            this.ValueAsAddress = ValueAsAddress;
            this.ValueAsWeight = ValueAsWeight;
            this.ValueAsDimension = ValueAsDimension;
            this.ValueAsCurrency = ValueAsCurrency;
        }

        /// <summary>
        /// The data type of the additional information.
        /// </summary>
        /// <value>The data type of the additional information.</value>
        [DataMember(Name = "DataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// The value when the data type is string.
        /// </summary>
        /// <value>The value when the data type is string.</value>
        [DataMember(Name = "ValueAsString", EmitDefaultValue = false)]
        public string ValueAsString { get; set; }

        /// <summary>
        /// The value when the data type is boolean.
        /// </summary>
        /// <value>The value when the data type is boolean.</value>
        [DataMember(Name = "ValueAsBoolean", EmitDefaultValue = false)]
        public bool? ValueAsBoolean { get; set; }

        /// <summary>
        /// The value when the data type is integer.
        /// </summary>
        /// <value>The value when the data type is integer.</value>
        [DataMember(Name = "ValueAsInteger", EmitDefaultValue = false)]
        public int? ValueAsInteger { get; set; }

        /// <summary>
        /// The value when the data type is a date-time formatted string.
        /// </summary>
        /// <value>The value when the data type is a date-time formatted string.</value>
        [DataMember(Name = "ValueAsTimestamp", EmitDefaultValue = false)]
        public Timestamp ValueAsTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets ValueAsAddress
        /// </summary>
        [DataMember(Name = "ValueAsAddress", EmitDefaultValue = false)]
        public Address ValueAsAddress { get; set; }

        /// <summary>
        /// Gets or Sets ValueAsWeight
        /// </summary>
        [DataMember(Name = "ValueAsWeight", EmitDefaultValue = false)]
        public Weight ValueAsWeight { get; set; }

        /// <summary>
        /// Gets or Sets ValueAsDimension
        /// </summary>
        [DataMember(Name = "ValueAsDimension", EmitDefaultValue = false)]
        public Length ValueAsDimension { get; set; }

        /// <summary>
        /// Gets or Sets ValueAsCurrency
        /// </summary>
        [DataMember(Name = "ValueAsCurrency", EmitDefaultValue = false)]
        public CurrencyAmount ValueAsCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalSellerInput {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ValueAsString: ").Append(ValueAsString).Append("\n");
            sb.Append("  ValueAsBoolean: ").Append(ValueAsBoolean).Append("\n");
            sb.Append("  ValueAsInteger: ").Append(ValueAsInteger).Append("\n");
            sb.Append("  ValueAsTimestamp: ").Append(ValueAsTimestamp).Append("\n");
            sb.Append("  ValueAsAddress: ").Append(ValueAsAddress).Append("\n");
            sb.Append("  ValueAsWeight: ").Append(ValueAsWeight).Append("\n");
            sb.Append("  ValueAsDimension: ").Append(ValueAsDimension).Append("\n");
            sb.Append("  ValueAsCurrency: ").Append(ValueAsCurrency).Append("\n");
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
            return this.Equals(input as AdditionalSellerInput);
        }

        /// <summary>
        /// Returns true if AdditionalSellerInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalSellerInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalSellerInput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) &&
                (
                    this.ValueAsString == input.ValueAsString ||
                    (this.ValueAsString != null &&
                    this.ValueAsString.Equals(input.ValueAsString))
                ) &&
                (
                    this.ValueAsBoolean == input.ValueAsBoolean ||
                    (this.ValueAsBoolean != null &&
                    this.ValueAsBoolean.Equals(input.ValueAsBoolean))
                ) &&
                (
                    this.ValueAsInteger == input.ValueAsInteger ||
                    (this.ValueAsInteger != null &&
                    this.ValueAsInteger.Equals(input.ValueAsInteger))
                ) &&
                (
                    this.ValueAsTimestamp == input.ValueAsTimestamp ||
                    (this.ValueAsTimestamp != null &&
                    this.ValueAsTimestamp.Equals(input.ValueAsTimestamp))
                ) &&
                (
                    this.ValueAsAddress == input.ValueAsAddress ||
                    (this.ValueAsAddress != null &&
                    this.ValueAsAddress.Equals(input.ValueAsAddress))
                ) &&
                (
                    this.ValueAsWeight == input.ValueAsWeight ||
                    (this.ValueAsWeight != null &&
                    this.ValueAsWeight.Equals(input.ValueAsWeight))
                ) &&
                (
                    this.ValueAsDimension == input.ValueAsDimension ||
                    (this.ValueAsDimension != null &&
                    this.ValueAsDimension.Equals(input.ValueAsDimension))
                ) &&
                (
                    this.ValueAsCurrency == input.ValueAsCurrency ||
                    (this.ValueAsCurrency != null &&
                    this.ValueAsCurrency.Equals(input.ValueAsCurrency))
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
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.ValueAsString != null)
                    hashCode = hashCode * 59 + this.ValueAsString.GetHashCode();
                if (this.ValueAsBoolean != null)
                    hashCode = hashCode * 59 + this.ValueAsBoolean.GetHashCode();
                if (this.ValueAsInteger != null)
                    hashCode = hashCode * 59 + this.ValueAsInteger.GetHashCode();
                if (this.ValueAsTimestamp != null)
                    hashCode = hashCode * 59 + this.ValueAsTimestamp.GetHashCode();
                if (this.ValueAsAddress != null)
                    hashCode = hashCode * 59 + this.ValueAsAddress.GetHashCode();
                if (this.ValueAsWeight != null)
                    hashCode = hashCode * 59 + this.ValueAsWeight.GetHashCode();
                if (this.ValueAsDimension != null)
                    hashCode = hashCode * 59 + this.ValueAsDimension.GetHashCode();
                if (this.ValueAsCurrency != null)
                    hashCode = hashCode * 59 + this.ValueAsCurrency.GetHashCode();
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
