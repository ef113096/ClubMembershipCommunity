﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Kendo.Mvc.UI;

namespace ClubMembershipCommunity.Models
{
    public class CalendarEvents : ISchedulerEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }

    }
}