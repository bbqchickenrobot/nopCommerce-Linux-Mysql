using Nop.Core;

namespace Nop.Plugin.Tax.CountryStateZip.Domain
{
    /// <summary>
    /// Represents a tax rate
    /// </summary>
    public partial class TaxRate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the tax category identifier
        /// </summary>
        public virtual int TaxCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the country identifier
        /// </summary>
        public virtual int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the state/province identifier
        /// </summary>
        public virtual int StateProvinceId { get; set; }

        /// <summary>
        /// Gets or sets the zip
        /// </summary>
        public virtual string Zip { get; set; }

        /// <summary>
        /// Gets or sets the percentage
        /// </summary>
        public virtual decimal Percentage { get; set; }
    }
}