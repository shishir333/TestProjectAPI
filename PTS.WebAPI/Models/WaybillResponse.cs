using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class WaybillResponse : IModelBase
    {
        public int Id { get; set; }

        public Location Source { get; set; }

        public Location Destination { get; set; }

        public Facility Facility { get; set; }

        public string Shipment { get; set; }

        public string Ref { get; set; }

        public string Notes { get; set; }

        public int ItemCount { get; set; }

        public List<Item> Items { get; set; }

        /// <summary>
        /// Constructor to fill dummy data
        /// </summary>
        /// <param name="fillDummyData"></param>
        /// <param name="expand"></param>
        public WaybillResponse(bool fillDummyData, bool expand)
        {
            Id = 1122334;
            Shipment = "OS-1232-33AA1";
            Ref = "Maria-12345";
            ItemCount = 3;
            Source = new Location
            {
                Name = "Overstock Inc",
                Address = new Address
                {
                    AddressLine1 = "1000 Overstock Way",
                    City = "Provo",
                    State = "UT",
                    Zip = "72344"
                }
            };
            Destination = new Location
            {
                Name = "Maria Mueller",
                Address = new Address
                {
                    AddressLine1 = "123 N. Main St.",
                    City = "Gilbert",
                    State = "AZ",
                    Zip = "85295-2243"
                }
            };
            Facility = new Facility
            {
                FacilityId = "AZ0102",
                Address = new Address
                {
                    AddressLine1 = "",
                    City = "Gilbert",
                    State = "AZ",
                    Zip = ""
                }
            };
            if (expand)
            {
                Items = new List<Item>
                {
                    new Item()
                    {
                        Id = 1112223333,
                        Waybill = 1122334455,
                        Facility = new Facility
                        {
                            FacilityId = "AZ0102",
                            Address = new Address
                            {
                                AddressLine1 = "",
                                City = "Gilbert",
                                State = "AZ",
                                Zip = ""
                            }
                        },
                        Location = "Aisle 3",
                        IsDamaged = false,
                        IsOSD = false,
                        Desc = "Futura Dining room chair"
                    },
                    new Item()
                    {
                        Id = 1112223334,
                        Waybill = 1122334455,
                        Facility = new Facility
                        {
                            FacilityId = "AZ0102",
                            Address = new Address
                            {
                                AddressLine1 = "",
                                City = "Gilbert",
                                State = "AZ",
                                Zip = ""
                            }
                        },
                        Location = "Aisle 3",
                        IsDamaged = false,
                        IsOSD = false,
                        Desc = "Futura Dining room chair"
                    },
                    new Item()
                    {
                        Id = 1112223335,
                        Waybill = 1122334455,
                        Facility = new Facility
                        {
                            FacilityId = "AZ0102",
                            Address = new Address
                            {
                                AddressLine1 = "",
                                City = "Gilbert",
                                State = "AZ",
                                Zip = ""
                            }
                        },
                        Location = "Aisle 3",
                        IsDamaged = false,
                        IsOSD = false,
                        Desc = "Futura Dining room chair"
                    }
                };
            }
        }
    }
}