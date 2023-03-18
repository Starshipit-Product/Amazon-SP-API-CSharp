﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The time window when the delivery is preferred.
    /// </summary>
    [DataContract]
    public partial class PreferredDeliveryTime : IEquatable<PreferredDeliveryTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreferredDeliveryTime" /> class.
        /// </summary>
        /// <param name="businessHours">Business hours when the business is open for deliveries..</param>
        /// <param name="exceptionDates">Dates when the business is closed in the next 30 days..</param>
        public PreferredDeliveryTime(List<BusinessHours> businessHours = default(List<BusinessHours>), List<ExceptionDates> exceptionDates = default(List<ExceptionDates>))
        {
            this.BusinessHours = businessHours;
            this.ExceptionDates = exceptionDates;
        }

        public PreferredDeliveryTime()
        {
        }

        /// <summary>
        /// Business hours when the business is open for deliveries.
        /// </summary>
        /// <value>Business hours when the business is open for deliveries.</value>
        [DataMember(Name = "BusinessHours", EmitDefaultValue = false)]
        public List<BusinessHours> BusinessHours { get; set; }

        /// <summary>
        /// Dates when the business is closed in the next 30 days.
        /// </summary>
        /// <value>Dates when the business is closed in the next 30 days.</value>
        [DataMember(Name = "ExceptionDates", EmitDefaultValue = false)]
        public List<ExceptionDates> ExceptionDates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreferredDeliveryTime {\n");
            sb.Append("  BusinessHours: ").Append(BusinessHours).Append("\n");
            sb.Append("  ExceptionDates: ").Append(ExceptionDates).Append("\n");
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
            return this.Equals(input as PreferredDeliveryTime);
        }

        /// <summary>
        /// Returns true if PreferredDeliveryTime instances are equal
        /// </summary>
        /// <param name="input">Instance of PreferredDeliveryTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreferredDeliveryTime input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BusinessHours == input.BusinessHours ||
                    this.BusinessHours != null
                ) &&
                (
                    this.ExceptionDates == input.ExceptionDates ||
                    this.ExceptionDates != null
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
                if (this.BusinessHours != null)
                    hashCode = hashCode * 59 + this.BusinessHours.GetHashCode();
                if (this.ExceptionDates != null)
                    hashCode = hashCode * 59 + this.ExceptionDates.GetHashCode();
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