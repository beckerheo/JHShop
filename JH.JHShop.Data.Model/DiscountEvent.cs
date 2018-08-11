namespace JH.JHShop.Data.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="DiscountEvent" />
    /// </summary>
    public class DiscountEvent
    {
        /// <summary>
        /// Gets or sets the EventId
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Gets or sets the StartTime
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the EndTime
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets or sets the DiscountProducts
        /// </summary>
        public List<int> DiscountProducts { get; set; } = new List<int>();

        /// <summary>
        /// Defines the DiscountCondition
        /// </summary>
        public event EventHandler DiscountCondition;
    }
}
