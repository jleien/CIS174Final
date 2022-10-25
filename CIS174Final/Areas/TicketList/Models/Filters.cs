using System.Collections.Generic;

namespace CIS174Final.Areas.TicketList.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all";
            string[] filters = FilterString.Split('-');
            SprintId = filters[0];
            PointId = filters[1];
            StatusId = filters[2];
        }
        public string FilterString { get; }
        public string SprintId { get; }
        public string PointId { get; }
        public string StatusId { get; }

        public bool HasSprint => SprintId.ToLower() != "all";
        public bool HasDue => PointId.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";

    }
}
