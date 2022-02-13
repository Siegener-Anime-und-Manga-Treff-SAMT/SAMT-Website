﻿using System;
using System.Collections.Generic;

namespace SAMT_Website.Models
{
    public partial class Event
    {
        public Event()
        {
            EventsGuests = new HashSet<EventsGuest>();
            EventsProducts = new HashSet<EventsProduct>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageLink { get; set; }
        public int FkLocationId { get; set; }

        public virtual Location FkLocation { get; set; }
        public virtual ICollection<EventsGuest> EventsGuests { get; set; }
        public virtual ICollection<EventsProduct> EventsProducts { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
