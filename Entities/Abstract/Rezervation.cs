using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract
{
    public class Rezervation : EntityBase
    {
        public string DepartureRoute { get; set; }
        public string ArrivalRoute { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string PersonCount { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public string CarrierId { get; set; }
        public string Plate { get; set; }
        public string Personal { get; set; }
        public string PersonalGsm { get; set; }
        public string PersonalTC { get; set; }
        public string FlightCode { get; set; }
        public string AirplaneTime { get; set; }
        public string RefCode { get; set; }
        public string TotalPrice { get; set; }
        public Guid? ReferenceId { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? VehicleCategoryId { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? PriceId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? UserId { get; set; }

        public virtual Reference Reference { get; set; }
        public virtual Company Company { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual VehicleCategory VehicleCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Price Prices { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual AdditionalServices AdditionalServices { get; set; }
    }
}