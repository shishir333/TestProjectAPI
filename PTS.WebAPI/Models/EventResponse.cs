using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class EventResponse : IModelBase
    {
        public string Id { get; set; }

        public int Timestamp { get; set; }

        public string Type { get; set; }

        public string Src { get; set; }

        public string Dest { get; set; }

        public string Who { get; set; }

        public int Truck { get; set; }

        public string Notes { get; set; }

        public Damage Damage { get; set; }

        public bool IsActive { get; set; }

        public List<EventResponse> Items { get; set; }

        public EventResponse()
        {
        }

        public EventResponse(bool fillDummyData, bool isWaybill, bool isShipment, bool isShipmentRef)
        {
            if (!isWaybill && !isShipment && !isShipmentRef)
            {
                Items = new List<EventResponse>
                {
                    new EventResponse()
                    {
                        Id = "7d8c9522-c7a4-4f7b-8793-c5f088e3096a",
                        Timestamp = 1487997292,
                        Truck = 1,
                        Notes = "",
                        Damage = new Damage { Id = 1, Image = "", IsActive = true, Notes = "", Date = DateTime.Now },
                        Who = "",
                        IsActive = true
                    }
                };
             }

            else if (isWaybill && isShipment  && isShipmentRef)
            {
                Items = new List<EventResponse>
                {
                   new EventResponse()
                    {
                        Id = "7d8c9522-c7a4-4f7b-8793-c5f088e3096a",
                        Timestamp = 1487997292,
                        Truck = 1,
                        Notes = "",
                        Damage = new Damage { Id = 1, Image = "", IsActive = true, Notes = "", Date = DateTime.Now },
                        Who = "",
                        IsActive = true
                    },
                    new EventResponse()
                    {
                        Id = "7d8c9522-c7a4-4f7b-8793-c5f088e3096a",
                        Timestamp = 1487997292,
                        Truck = 1,
                        Notes = "",
                        Damage = new Damage { Id = 1, Image = "", IsActive = true, Notes = "", Date = DateTime.Now },
                        Who = "",
                        IsActive = true
                    },
                   new EventResponse()
                    {
                        Id = "7d8c9522-c7a4-4f7b-8793-c5f088e3096a",
                        Timestamp = 1487997292,
                        Truck = 1,
                        Notes = "",
                        Damage = new Damage { Id = 1, Image = "", IsActive = true, Notes = "", Date = DateTime.Now },
                        Who = "",
                        IsActive = true
                    }
               };
            }
        }
    }
}