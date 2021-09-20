/* 
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductFees
{
    /// <summary>
    /// The type of fee, fee amount, and other details.
    /// </summary>
    [DataContract]
    public partial class FeeDetail : IEquatable<FeeDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeDetail" /> class.
        /// </summary>
        /// <param name="FeeType">The type of fee charged to a seller. (required).</param>
        /// <param name="FeeAmount">The amount charged for a given fee. (required).</param>
        /// <param name="FeePromotion">The promotion amount for a given fee..</param>
        /// <param name="TaxAmount">The tax amount for a given fee..</param>
        /// <param name="FinalFee">The final fee amount for a given fee. (required).</param>
        /// <param name="IncludedFeeDetailList">IncludedFeeDetailList.</param>
        public FeeDetail(string FeeType = default(string), MoneyType FeeAmount = default(MoneyType), MoneyType FeePromotion = default(MoneyType), MoneyType TaxAmount = default(MoneyType), MoneyType FinalFee = default(MoneyType), IncludedFeeDetailList IncludedFeeDetailList = default(IncludedFeeDetailList))
        {
            // to ensure "FeeType" is required (not null)
            if (FeeType == null)
            {
                throw new InvalidDataException("FeeType is a required property for FeeDetail and cannot be null");
            }
            else
            {
                this.FeeType = FeeType;
            }
            // to ensure "FeeAmount" is required (not null)
            if (FeeAmount == null)
            {
                throw new InvalidDataException("FeeAmount is a required property for FeeDetail and cannot be null");
            }
            else
            {
                this.FeeAmount = FeeAmount;
            }
            // to ensure "FinalFee" is required (not null)
            if (FinalFee == null)
            {
                throw new InvalidDataException("FinalFee is a required property for FeeDetail and cannot be null");
            }
            else
            {
                this.FinalFee = FinalFee;
            }
            this.FeePromotion = FeePromotion;
            this.TaxAmount = TaxAmount;
            this.IncludedFeeDetailList = IncludedFeeDetailList;
        }

        /// <summary>
        /// The type of fee charged to a seller.
        /// </summary>
        /// <value>The type of fee charged to a seller.</value>
        [DataMember(Name = "FeeType", EmitDefaultValue = false)]
        public string FeeType { get; set; }

        /// <summary>
        /// The amount charged for a given fee.
        /// </summary>
        /// <value>The amount charged for a given fee.</value>
        [DataMember(Name = "FeeAmount", EmitDefaultValue = false)]
        public MoneyType FeeAmount { get; set; }

        /// <summary>
        /// The promotion amount for a given fee.
        /// </summary>
        /// <value>The promotion amount for a given fee.</value>
        [DataMember(Name = "FeePromotion", EmitDefaultValue = false)]
        public MoneyType FeePromotion { get; set; }

        /// <summary>
        /// The tax amount for a given fee.
        /// </summary>
        /// <value>The tax amount for a given fee.</value>
        [DataMember(Name = "TaxAmount", EmitDefaultValue = false)]
        public MoneyType TaxAmount { get; set; }

        /// <summary>
        /// The final fee amount for a given fee.
        /// </summary>
        /// <value>The final fee amount for a given fee.</value>
        [DataMember(Name = "FinalFee", EmitDefaultValue = false)]
        public MoneyType FinalFee { get; set; }

        /// <summary>
        /// Gets or Sets IncludedFeeDetailList
        /// </summary>
        [DataMember(Name = "IncludedFeeDetailList", EmitDefaultValue = false)]
        public IncludedFeeDetailList IncludedFeeDetailList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeDetail {\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  FeePromotion: ").Append(FeePromotion).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  FinalFee: ").Append(FinalFee).Append("\n");
            sb.Append("  IncludedFeeDetailList: ").Append(IncludedFeeDetailList).Append("\n");
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
            return this.Equals(input as FeeDetail);
        }

        /// <summary>
        /// Returns true if FeeDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeDetail input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeeType == input.FeeType ||
                    (this.FeeType != null &&
                    this.FeeType.Equals(input.FeeType))
                ) &&
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) &&
                (
                    this.FeePromotion == input.FeePromotion ||
                    (this.FeePromotion != null &&
                    this.FeePromotion.Equals(input.FeePromotion))
                ) &&
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) &&
                (
                    this.FinalFee == input.FinalFee ||
                    (this.FinalFee != null &&
                    this.FinalFee.Equals(input.FinalFee))
                ) &&
                (
                    this.IncludedFeeDetailList == input.IncludedFeeDetailList ||
                    (this.IncludedFeeDetailList != null &&
                    this.IncludedFeeDetailList.Equals(input.IncludedFeeDetailList))
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
                if (this.FeeType != null)
                    hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.FeePromotion != null)
                    hashCode = hashCode * 59 + this.FeePromotion.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.FinalFee != null)
                    hashCode = hashCode * 59 + this.FinalFee.GetHashCode();
                if (this.IncludedFeeDetailList != null)
                    hashCode = hashCode * 59 + this.IncludedFeeDetailList.GetHashCode();
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
