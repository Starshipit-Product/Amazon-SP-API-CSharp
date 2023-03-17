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
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Dimension, weight, and shipping information for the package.
    /// </summary>
    [DataContract]
    public partial class PartneredSmallParcelPackageOutput : IEquatable<PartneredSmallParcelPackageOutput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PackageStatus
        /// </summary>
        [DataMember(Name = "PackageStatus", EmitDefaultValue = false)]
        public PackageStatus PackageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredSmallParcelPackageOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PartneredSmallParcelPackageOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartneredSmallParcelPackageOutput" /> class.
        /// </summary>
        /// <param name="dimensions">dimensions (required).</param>
        /// <param name="weight">weight (required).</param>
        /// <param name="carrierName">The carrier specified with a previous call to putTransportDetails. (required).</param>
        /// <param name="trackingId">trackingId (required).</param>
        /// <param name="packageStatus">packageStatus (required).</param>
        public PartneredSmallParcelPackageOutput(Dimensions dimensions = default(Dimensions), Weight weight = default(Weight), string carrierName = default(string), string trackingId = default(string), PackageStatus packageStatus = default(PackageStatus))
        {
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new InvalidDataException("dimensions is a required property for PartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.Dimensions = dimensions;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for PartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            // to ensure "carrierName" is required (not null)
            if (carrierName == null)
            {
                throw new InvalidDataException("carrierName is a required property for PartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.CarrierName = carrierName;
            }
            // to ensure "trackingId" is required (not null)
            if (trackingId == null)
            {
                throw new InvalidDataException("trackingId is a required property for PartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.TrackingId = trackingId;
            }
            // to ensure "packageStatus" is required (not null)
            if (packageStatus == null)
            {
                throw new InvalidDataException("packageStatus is a required property for PartneredSmallParcelPackageOutput and cannot be null");
            }
            else
            {
                this.PackageStatus = packageStatus;
            }
        }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "Dimensions", EmitDefaultValue = false)]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// The carrier specified with a previous call to putTransportDetails.
        /// </summary>
        /// <value>The carrier specified with a previous call to putTransportDetails.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets TrackingId
        /// </summary>
        [DataMember(Name = "TrackingId", EmitDefaultValue = false)]
        public string TrackingId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartneredSmallParcelPackageOutput {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  PackageStatus: ").Append(PackageStatus).Append("\n");
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
            return this.Equals(input as PartneredSmallParcelPackageOutput);
        }

        /// <summary>
        /// Returns true if PartneredSmallParcelPackageOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of PartneredSmallParcelPackageOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartneredSmallParcelPackageOutput input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) &&
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) &&
                (
                    this.TrackingId == input.TrackingId ||
                    (this.TrackingId != null &&
                    this.TrackingId.Equals(input.TrackingId))
                ) &&
                (
                    this.PackageStatus == input.PackageStatus ||
                    (this.PackageStatus != null &&
                    this.PackageStatus.Equals(input.PackageStatus))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.TrackingId != null)
                    hashCode = hashCode * 59 + this.TrackingId.GetHashCode();
                if (this.PackageStatus != null)
                    hashCode = hashCode * 59 + this.PackageStatus.GetHashCode();
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