using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendlyBlazorAPI.Model
{

    public class Rootobject
    {
        public Collection[] collection { get; set; }
        public Pagination pagination { get; set; }

        public Rootobject()
        {
            this.collection = new Collection[] {};
            this.pagination = new Pagination();
        }
    }

    public class Pagination
    {
        public int count { get; set; }
        public object next_page { get; set; }
        public object next_page_token { get; set; }
        public object previous_page { get; set; }
        public object previous_page_token { get; set; }
    }

    public class Collection
    {
        public DateTime created_at { get; set; }
        public DateTime end_time { get; set; }
        public object[] event_guests { get; set; }
        public Event_Memberships[] event_memberships { get; set; }
        public string event_type { get; set; }
        public Invitees_Counter invitees_counter { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public DateTime start_time { get; set; }
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public string uri { get; set; }
    }

    public class Invitees_Counter
    {
        public int active { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
    }

    public class Location
    {
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Event_Memberships
    {
        public string user { get; set; }
    }

}
