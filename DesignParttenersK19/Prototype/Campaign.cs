using System;

namespace DesignParttenersK19.Prototype
{
    /// <summary>
    /// Model class to explain how to Prototype Partner works.
    /// Well, is just a implementation of ICloneble .NET interface. 
    /// </summary>
    public class Campaign:ICloneable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }
        public object Clone()
        {
            return new Campaign
            {
                Description = this.Description,
                Title = this.Title,
                InitDate = this.InitDate,
                EndDate = this.EndDate
            };
        }
    }
}