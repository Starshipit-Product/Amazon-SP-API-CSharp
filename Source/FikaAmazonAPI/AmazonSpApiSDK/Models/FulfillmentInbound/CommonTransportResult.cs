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
    /// CommonTransportResult
    /// </summary>
    [DataContract]
    public partial class CommonTransportResult : IEquatable<CommonTransportResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonTransportResult" /> class.
        /// </summary>
        /// <param name="transportResult">transportResult.</param>
        public CommonTransportResult(TransportResult transportResult = default(TransportResult))
        {
            this.TransportResult = transportResult;
        }

        /// <summary>
        /// Gets or Sets TransportResult
        /// </summary>
        [DataMember(Name = "TransportResult", EmitDefaultValue = false)]
        public TransportResult TransportResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonTransportResult {\n");
            sb.Append("  TransportResult: ").Append(TransportResult).Append("\n");
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
            return this.Equals(input as CommonTransportResult);
        }

        /// <summary>
        /// Returns true if CommonTransportResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonTransportResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonTransportResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TransportResult == input.TransportResult ||
                    (this.TransportResult != null &&
                    this.TransportResult.Equals(input.TransportResult))
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
                if (this.TransportResult != null)
                    hashCode = hashCode * 59 + this.TransportResult.GetHashCode();
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