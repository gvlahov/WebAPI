using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIServer.Models
{
    public class Request
    {
        public Guid apiToken { get; set; }
        public ContactInfo bcmContactInfo { get; set; }
        public EventInfo bcmEventInfo { get; set; }
        public ServiceInfo serviceInfo { get; set; }
    }

    public class ContactInfo
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public int bcmContactId { get; set; }
        public int bcmLanguageId { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string streetAddress { get; set; }
    }

    public class EventInfo
    {
        public Guid operatorId { get; set; }
        public int eventHistoryId { get; set; }
        public int eventType { get; set; }
    }

    public class ServiceInfo
    {
        public string brand { get; set; }
        public string model { get; set; }
        public bool guarantee { get; set; }
        public string description { get; set; }
    }
}