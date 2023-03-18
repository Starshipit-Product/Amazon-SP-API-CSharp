﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The error response schema for an shipment confirmation.
    /// </summary>
    [DataContract]
    public partial class ConfirmShipmentErrorResponse : IEquatable<ConfirmShipmentErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmShipmentErrorResponse" /> class.
        /// </summary>
        /// <param name="errors">One or more unexpected errors occurred during the confirmShipment operation..</param>
        public ConfirmShipmentErrorResponse(ErrorList errors = default(ErrorList))
        {
            this.Errors = errors;
        }
        public ConfirmShipmentErrorResponse()
        {
        }

        /// <summary>
        /// One or more unexpected errors occurred during the confirmShipment operation.
        /// </summary>
        /// <value>One or more unexpected errors occurred during the confirmShipment operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmShipmentErrorResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as ConfirmShipmentErrorResponse);
        }

        /// <summary>
        /// Returns true if ConfirmShipmentErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmShipmentErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmShipmentErrorResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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