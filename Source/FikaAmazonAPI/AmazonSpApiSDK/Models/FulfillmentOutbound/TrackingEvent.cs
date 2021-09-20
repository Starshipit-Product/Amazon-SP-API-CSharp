/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Information for tracking package deliveries.
    /// </summary>
    [DataContract]
    public partial class TrackingEvent : IEquatable<TrackingEvent>, IValidatableObject
    {
        /// <summary>
        /// The event code for the delivery event.
        /// </summary>
        /// <value>The event code for the delivery event.</value>
        [DataMember(Name = "EventCode", EmitDefaultValue = false)]
        public EventCode EventCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEvent" /> class.
        /// </summary>
        /// <param name="EventDate">The date and time that the delivery event took place, in ISO 8601 date time format. (required).</param>
        /// <param name="EventAddress">The city where the delivery event took place. (required).</param>
        /// <param name="EventCode">The event code for the delivery event. (required).</param>
        public TrackingEvent(Timestamp EventDate = default(Timestamp), TrackingAddress EventAddress = default(TrackingAddress), EventCode EventCode = default(EventCode))
        {
            // to ensure "EventDate" is required (not null)
            if (EventDate == null)
            {
                throw new InvalidDataException("EventDate is a required property for TrackingEvent and cannot be null");
            }
            else
            {
                this.EventDate = EventDate;
            }
            // to ensure "EventAddress" is required (not null)
            if (EventAddress == null)
            {
                throw new InvalidDataException("EventAddress is a required property for TrackingEvent and cannot be null");
            }
            else
            {
                this.EventAddress = EventAddress;
            }
            // to ensure "EventCode" is required (not null)
            if (EventCode == null)
            {
                throw new InvalidDataException("EventCode is a required property for TrackingEvent and cannot be null");
            }
            else
            {
                this.EventCode = EventCode;
            }
        }

        /// <summary>
        /// The date and time that the delivery event took place, in ISO 8601 date time format.
        /// </summary>
        /// <value>The date and time that the delivery event took place, in ISO 8601 date time format.</value>
        [DataMember(Name = "EventDate", EmitDefaultValue = false)]
        public Timestamp EventDate { get; set; }

        /// <summary>
        /// The city where the delivery event took place.
        /// </summary>
        /// <value>The city where the delivery event took place.</value>
        [DataMember(Name = "EventAddress", EmitDefaultValue = false)]
        public TrackingAddress EventAddress { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingEvent {\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventAddress: ").Append(EventAddress).Append("\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
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
            return this.Equals(input as TrackingEvent);
        }

        /// <summary>
        /// Returns true if TrackingEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) &&
                (
                    this.EventAddress == input.EventAddress ||
                    (this.EventAddress != null &&
                    this.EventAddress.Equals(input.EventAddress))
                ) &&
                (
                    this.EventCode == input.EventCode ||
                    (this.EventCode != null &&
                    this.EventCode.Equals(input.EventCode))
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
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.EventAddress != null)
                    hashCode = hashCode * 59 + this.EventAddress.GetHashCode();
                if (this.EventCode != null)
                    hashCode = hashCode * 59 + this.EventCode.GetHashCode();
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
