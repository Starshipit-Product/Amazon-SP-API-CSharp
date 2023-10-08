/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.CatalogItems.V20220401
{
    /// <summary>
    /// Summary details of an Amazon catalog item for the indicated Amazon marketplace.
    /// </summary>
    [DataContract]
    public partial class ItemSummaryByMarketplace : IEquatable<ItemSummaryByMarketplace>, IValidatableObject
    {
        /// <summary>
        /// Classification type associated with the Amazon catalog item.
        /// </summary>
        /// <value>Classification type associated with the Amazon catalog item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemClassificationEnum
        {

            /// <summary>
            /// Enum BASEPRODUCT for value: BASE_PRODUCT
            /// </summary>
            [EnumMember(Value = "BASE_PRODUCT")]
            BASEPRODUCT = 1,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 2,

            /// <summary>
            /// Enum PRODUCTBUNDLE for value: PRODUCT_BUNDLE
            /// </summary>
            [EnumMember(Value = "PRODUCT_BUNDLE")]
            PRODUCTBUNDLE = 3,

            /// <summary>
            /// Enum VARIATIONPARENT for value: VARIATION_PARENT
            /// </summary>
            [EnumMember(Value = "VARIATION_PARENT")]
            VARIATIONPARENT = 4
        }

        /// <summary>
        /// Classification type associated with the Amazon catalog item.
        /// </summary>
        /// <value>Classification type associated with the Amazon catalog item.</value>
        [DataMember(Name = "itemClassification", EmitDefaultValue = false)]
        public ItemClassificationEnum? ItemClassification { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSummaryByMarketplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemSummaryByMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSummaryByMarketplace" /> class.
        /// </summary>
        /// <param name="marketplaceId">Amazon marketplace identifier. (required).</param>
        /// <param name="brand">Name of the brand associated with an Amazon catalog item..</param>
        /// <param name="browseClassification">Classification (browse node) associated with an Amazon catalog item..</param>
        /// <param name="color">Name of the color associated with an Amazon catalog item..</param>
        /// <param name="itemClassification">Classification type associated with the Amazon catalog item..</param>
        /// <param name="itemName">Name, or title, associated with an Amazon catalog item..</param>
        /// <param name="manufacturer">Name of the manufacturer associated with an Amazon catalog item..</param>
        /// <param name="modelNumber">Model number associated with an Amazon catalog item..</param>
        /// <param name="packageQuantity">Quantity of an Amazon catalog item in one package..</param>
        /// <param name="partNumber">Part number associated with an Amazon catalog item..</param>
        /// <param name="releaseDate">First date on which an Amazon catalog item is shippable to customers..</param>
        /// <param name="size">Name of the size associated with an Amazon catalog item..</param>
        /// <param name="style">Name of the style associated with an Amazon catalog item..</param>
        /// <param name="websiteDisplayGroup">Name of the website display group associated with an Amazon catalog item..</param>
        public ItemSummaryByMarketplace(string marketplaceId = default, string brand = default, ItemBrowseClassification browseClassification = default,
            string color = default, ItemClassificationEnum? itemClassification = default, string itemName = default, string manufacturer = default,
            string modelNumber = default, int? packageQuantity = default, string partNumber = default, DateTime? releaseDate = default,
            string size = default, string style = default, string websiteDisplayGroup = default, string websiteDisplayGroupName = default)
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ItemSummaryByMarketplace and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            this.Brand = brand;
            this.BrowseClassification = browseClassification;
            this.Color = color;
            this.ItemClassification = itemClassification;
            this.ItemName = itemName;
            this.Manufacturer = manufacturer;
            this.ModelNumber = modelNumber;
            this.PackageQuantity = packageQuantity;
            this.PartNumber = partNumber;
            this.ReleaseDate = releaseDate;
            this.Size = size;
            this.Style = style;
            this.WebsiteDisplayGroup = websiteDisplayGroup;
            this.WebsiteDisplayGroupName = websiteDisplayGroupName;
        }

        /// <summary>
        /// Amazon marketplace identifier.
        /// </summary>
        /// <value>Amazon marketplace identifier.</value>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Name of the brand associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the brand associated with an Amazon catalog item.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Classification (browse node) associated with an Amazon catalog item.
        /// </summary>
        /// <value>Classification (browse node) associated with an Amazon catalog item.</value>
        [DataMember(Name = "browseClassification", EmitDefaultValue = false)]
        public ItemBrowseClassification BrowseClassification { get; set; }

        /// <summary>
        /// Name of the color associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the color associated with an Amazon catalog item.</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }


        /// <summary>
        /// Name, or title, associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name, or title, associated with an Amazon catalog item.</value>
        [DataMember(Name = "itemName", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Name of the manufacturer associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the manufacturer associated with an Amazon catalog item.</value>
        [DataMember(Name = "manufacturer", EmitDefaultValue = false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Model number associated with an Amazon catalog item.
        /// </summary>
        /// <value>Model number associated with an Amazon catalog item.</value>
        [DataMember(Name = "modelNumber", EmitDefaultValue = false)]
        public string ModelNumber { get; set; }

        /// <summary>
        /// Quantity of an Amazon catalog item in one package.
        /// </summary>
        /// <value>Quantity of an Amazon catalog item in one package.</value>
        [DataMember(Name = "packageQuantity", EmitDefaultValue = false)]
        public int? PackageQuantity { get; set; }

        /// <summary>
        /// Part number associated with an Amazon catalog item.
        /// </summary>
        /// <value>Part number associated with an Amazon catalog item.</value>
        [DataMember(Name = "partNumber", EmitDefaultValue = false)]
        public string PartNumber { get; set; }

        /// <summary>
        /// First date on which an Amazon catalog item is shippable to customers.
        /// </summary>
        /// <value>First date on which an Amazon catalog item is shippable to customers.</value>
        [DataMember(Name = "releaseDate", EmitDefaultValue = false)]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Name of the size associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the size associated with an Amazon catalog item.</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// Name of the style associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the style associated with an Amazon catalog item.</value>
        [DataMember(Name = "style", EmitDefaultValue = false)]
        public string Style { get; set; }

        /// <summary>
        /// Name of the website display group associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the website display group associated with an Amazon catalog item.</value>
        [DataMember(Name = "websiteDisplayGroup", EmitDefaultValue = false)]
        public string WebsiteDisplayGroup { get; set; }

        /// <summary>
        /// Name of the website display group associated with an Amazon catalog item.
        /// </summary>
        /// <value>Name of the website display group associated with an Amazon catalog item.</value>
        [DataMember(Name = "websiteDisplayGroupName", EmitDefaultValue = false)]
        public string WebsiteDisplayGroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemSummaryByMarketplace {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  BrowseClassification: ").Append(BrowseClassification).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  ItemClassification: ").Append(ItemClassification).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  ModelNumber: ").Append(ModelNumber).Append("\n");
            sb.Append("  PackageQuantity: ").Append(PackageQuantity).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  WebsiteDisplayGroup: ").Append(WebsiteDisplayGroup).Append("\n");
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
            return this.Equals(input as ItemSummaryByMarketplace);
        }

        /// <summary>
        /// Returns true if ItemSummaryByMarketplace instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemSummaryByMarketplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemSummaryByMarketplace input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) &&
                (
                    this.BrowseClassification == input.BrowseClassification ||
                    (this.BrowseClassification != null &&
                    this.BrowseClassification.Equals(input.BrowseClassification))
                ) &&
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) &&
                (
                    this.ItemClassification == input.ItemClassification ||
                    (this.ItemClassification != null &&
                    this.ItemClassification.Equals(input.ItemClassification))
                ) &&
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) &&
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) &&
                (
                    this.ModelNumber == input.ModelNumber ||
                    (this.ModelNumber != null &&
                    this.ModelNumber.Equals(input.ModelNumber))
                ) &&
                (
                    this.PackageQuantity == input.PackageQuantity ||
                    (this.PackageQuantity != null &&
                    this.PackageQuantity.Equals(input.PackageQuantity))
                ) &&
                (
                    this.PartNumber == input.PartNumber ||
                    (this.PartNumber != null &&
                    this.PartNumber.Equals(input.PartNumber))
                ) &&
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) &&
                (
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
                ) &&
                (
                    this.WebsiteDisplayGroup == input.WebsiteDisplayGroup ||
                    (this.WebsiteDisplayGroup != null &&
                    this.WebsiteDisplayGroup.Equals(input.WebsiteDisplayGroup))
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.BrowseClassification != null)
                    hashCode = hashCode * 59 + this.BrowseClassification.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.ItemClassification != null)
                    hashCode = hashCode * 59 + this.ItemClassification.GetHashCode();
                if (this.ItemName != null)
                    hashCode = hashCode * 59 + this.ItemName.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.ModelNumber != null)
                    hashCode = hashCode * 59 + this.ModelNumber.GetHashCode();
                if (this.PackageQuantity != null)
                    hashCode = hashCode * 59 + this.PackageQuantity.GetHashCode();
                if (this.PartNumber != null)
                    hashCode = hashCode * 59 + this.PartNumber.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Style != null)
                    hashCode = hashCode * 59 + this.Style.GetHashCode();
                if (this.WebsiteDisplayGroup != null)
                    hashCode = hashCode * 59 + this.WebsiteDisplayGroup.GetHashCode();
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
