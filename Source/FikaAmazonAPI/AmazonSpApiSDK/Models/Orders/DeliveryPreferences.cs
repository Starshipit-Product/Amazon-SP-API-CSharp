﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// Contains all of the delivery instructions provided by the customer for the shipping address.
    /// </summary>
    [DataContract]
    public partial class DeliveryPreferences : IEquatable<DeliveryPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryPreferences" /> class.
        /// </summary>
        /// <param name="dropOffLocation">Drop-off location selected by the customer..</param>
        /// <param name="preferredDeliveryTime">Business hours and days when the delivery is preferred..</param>
        /// <param name="otherAttributes">Enumerated list of miscellaneous delivery attributes associated with the shipping address..</param>
        /// <param name="addressInstructions">Building instructions, nearby landmark or navigation instructions..</param>
        public DeliveryPreferences(string dropOffLocation = default(string), PreferredDeliveryTime preferredDeliveryTime = default(PreferredDeliveryTime), List<OtherDeliveryAttributes> otherAttributes = default(List<OtherDeliveryAttributes>), string addressInstructions = default(string))
        {
            this.DropOffLocation = dropOffLocation;
            this.PreferredDeliveryTime = preferredDeliveryTime;
            this.OtherAttributes = otherAttributes;
            this.AddressInstructions = addressInstructions;
        }

        public DeliveryPreferences()
        {
        }
        /// <summary>
        /// Drop-off location selected by the customer.
        /// </summary>
        /// <value>Drop-off location selected by the customer.</value>
        [DataMember(Name = "DropOffLocation", EmitDefaultValue = false)]
        public string DropOffLocation { get; set; }

        /// <summary>
        /// Business hours and days when the delivery is preferred.
        /// </summary>
        /// <value>Business hours and days when the delivery is preferred.</value>
        [DataMember(Name = "PreferredDeliveryTime", EmitDefaultValue = false)]
        public PreferredDeliveryTime PreferredDeliveryTime { get; set; }

        /// <summary>
        /// Enumerated list of miscellaneous delivery attributes associated with the shipping address.
        /// </summary>
        /// <value>Enumerated list of miscellaneous delivery attributes associated with the shipping address.</value>
        [DataMember(Name = "OtherAttributes", EmitDefaultValue = false)]
        public List<OtherDeliveryAttributes> OtherAttributes { get; set; }

        /// <summary>
        /// Building instructions, nearby landmark or navigation instructions.
        /// </summary>
        /// <value>Building instructions, nearby landmark or navigation instructions.</value>
        [DataMember(Name = "AddressInstructions", EmitDefaultValue = false)]
        public string AddressInstructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryPreferences {\n");
            sb.Append("  DropOffLocation: ").Append(DropOffLocation).Append("\n");
            sb.Append("  PreferredDeliveryTime: ").Append(PreferredDeliveryTime).Append("\n");
            sb.Append("  OtherAttributes: ").Append(OtherAttributes).Append("\n");
            sb.Append("  AddressInstructions: ").Append(AddressInstructions).Append("\n");
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
            return this.Equals(input as DeliveryPreferences);
        }

        /// <summary>
        /// Returns true if DeliveryPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryPreferences input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DropOffLocation == input.DropOffLocation ||
                    (this.DropOffLocation != null &&
                    this.DropOffLocation.Equals(input.DropOffLocation))
                ) &&
                (
                    this.PreferredDeliveryTime == input.PreferredDeliveryTime ||
                    (this.PreferredDeliveryTime != null &&
                    this.PreferredDeliveryTime.Equals(input.PreferredDeliveryTime))
                ) &&
                (
                    this.AddressInstructions == input.AddressInstructions ||
                    (this.AddressInstructions != null &&
                    this.AddressInstructions.Equals(input.AddressInstructions))
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
                if (this.DropOffLocation != null)
                    hashCode = hashCode * 59 + this.DropOffLocation.GetHashCode();
                if (this.PreferredDeliveryTime != null)
                    hashCode = hashCode * 59 + this.PreferredDeliveryTime.GetHashCode();
                if (this.OtherAttributes != null)
                    hashCode = hashCode * 59 + this.OtherAttributes.GetHashCode();
                if (this.AddressInstructions != null)
                    hashCode = hashCode * 59 + this.AddressInstructions.GetHashCode();
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

