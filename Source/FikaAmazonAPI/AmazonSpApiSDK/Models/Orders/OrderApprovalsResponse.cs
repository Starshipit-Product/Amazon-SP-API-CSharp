﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The order items list with approvals along with the order ID.
    /// </summary>
    [DataContract]
    public partial class OrderApprovalsResponse : IEquatable<OrderApprovalsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApprovalsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderApprovalsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApprovalsResponse" /> class.
        /// </summary>
        /// <param name="nextToken">When present and not empty, pass this string token in the next request to return the next response page..</param>
        /// <param name="orderItemsApprovalsList">List of OrderItemApprovals. (required).</param>
        public OrderApprovalsResponse(string nextToken = default(string), List<OrderItemApprovals> orderItemsApprovalsList = default(List<OrderItemApprovals>))
        {
            // to ensure "orderItemsApprovalsList" is required (not null)
            if (orderItemsApprovalsList == null)
            {
                throw new InvalidDataException("orderItemsApprovalsList is a required property for OrderApprovalsResponse and cannot be null");
            }
            else
            {
                this.OrderItemsApprovalsList = orderItemsApprovalsList;
            }
            this.NextToken = nextToken;
        }

        /// <summary>
        /// When present and not empty, pass this string token in the next request to return the next response page.
        /// </summary>
        /// <value>When present and not empty, pass this string token in the next request to return the next response page.</value>
        [DataMember(Name = "NextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// List of OrderItemApprovals.
        /// </summary>
        /// <value>List of OrderItemApprovals.</value>
        [DataMember(Name = "OrderItemsApprovalsList", EmitDefaultValue = false)]
        public List<OrderItemApprovals> OrderItemsApprovalsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderApprovalsResponse {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  OrderItemsApprovalsList: ").Append(OrderItemsApprovalsList).Append("\n");
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
            return this.Equals(input as OrderApprovalsResponse);
        }

        /// <summary>
        /// Returns true if OrderApprovalsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderApprovalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderApprovalsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) &&
                (
                    this.OrderItemsApprovalsList == input.OrderItemsApprovalsList ||
                    this.OrderItemsApprovalsList != null
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
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
                if (this.OrderItemsApprovalsList != null)
                    hashCode = hashCode * 59 + this.OrderItemsApprovalsList.GetHashCode();
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