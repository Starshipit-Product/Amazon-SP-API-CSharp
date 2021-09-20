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
    /// An unexpected error occurred during this operation.
    /// </summary>
    [DataContract]
    public partial class FeesEstimateError : IEquatable<FeesEstimateError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimateError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeesEstimateError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimateError" /> class.
        /// </summary>
        /// <param name="Type">An error type, identifying either the receiver or the sender as the originator of the error. (required).</param>
        /// <param name="Code">An error code that identifies the type of error that occurred. (required).</param>
        /// <param name="Message">A message that describes the error condition in a human-readable form. (required).</param>
        /// <param name="Detail">Detail (required).</param>
        public FeesEstimateError(string Type = default(string), string Code = default(string), string Message = default(string), FeesEstimateErrorDetail Detail = default(FeesEstimateErrorDetail))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for FeesEstimateError and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for FeesEstimateError and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for FeesEstimateError and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "Detail" is required (not null)
            if (Detail == null)
            {
                throw new InvalidDataException("Detail is a required property for FeesEstimateError and cannot be null");
            }
            else
            {
                this.Detail = Detail;
            }
        }

        /// <summary>
        /// An error type, identifying either the receiver or the sender as the originator of the error.
        /// </summary>
        /// <value>An error type, identifying either the receiver or the sender as the originator of the error.</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// An error code that identifies the type of error that occurred.
        /// </summary>
        /// <value>An error code that identifies the type of error that occurred.</value>
        [DataMember(Name = "Code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A message that describes the error condition in a human-readable form.
        /// </summary>
        /// <value>A message that describes the error condition in a human-readable form.</value>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "Detail", EmitDefaultValue = false)]
        public FeesEstimateErrorDetail Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeesEstimateError {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as FeesEstimateError);
        }

        /// <summary>
        /// Returns true if FeesEstimateError instances are equal
        /// </summary>
        /// <param name="input">Instance of FeesEstimateError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeesEstimateError input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) &&
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) &&
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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
