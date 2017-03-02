using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class ItemResponse : IModelBase
    {
        public int Id { get; set; }

        public int Waybill { get; set; }

        public int Truck { get; set; }

        public string Facility { get; set; }

        public string Location { get; set; }

        public bool IsDamaged { get; set; }

        public bool IsOSD { get; set; }

        public string Notes { get; set; }

        public string Desc { get; set; }

        public Damage Damage { get; set; }

        public string Who { get; set; }

        public bool IsActive { get; set; }

        public List<ItemResponse> Items { get; set; }

        public ItemResponse()
        {
            
        }

        public ItemResponse(bool fillDummyData, bool isWaybill)
        {
            if (!isWaybill)
            {
                Items = new List<ItemResponse>
                {
                    new ItemResponse()
                    {
                        Id = 1112223333,
                        Waybill = 1122334455,
                        Truck = 1,
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
                        }.FacilityId,
                        Location = "Aisle 3",
                        IsDamaged = false,
                        IsOSD = false,
                        Notes = "",
                        Desc = "Futura Dining room chair",
                        Damage = new Damage { Id = 1, Image = "", IsActive = true, Notes = "", Date = DateTime.Now },
                        Who = "",
                        IsActive = true
                    }
                };
             }

            else if (isWaybill)
            {
                Items = new List<ItemResponse>
                {
                   new ItemResponse()
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
                        }.FacilityId,
                        Location = "Aisle 3",
                        IsDamaged = false,
                        IsOSD = false,
                        Desc = "Futura Dining room chair"
                    },
                    new ItemResponse()
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
                        }.FacilityId,
                        Location = "Aisle 3",
                        IsDamaged = false,
                        IsOSD = false,
                        Desc = "Futura Dining room chair"
                    },
                    new ItemResponse()
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
                        }.FacilityId,
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