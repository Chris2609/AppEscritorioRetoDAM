using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorioReto_PabloAimarChristian
{
    internal class Incidencia
    {
        public int Id { get; set; }
        public string AutonomousRegion { get; set; }
        public string CityTown { get; set; }
        public string Cause { get; set; }
        public string IncidenceType { get; set; }
        public string Province { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int SourceId { get; set; }
        public bool Api { get; set; }

        public Incidencia() { }

        public Incidencia(int id, string autonomousRegion, string cityTown, string cause, string incidenceType, string province, double latitude, double longitude, string startDate, string endDate, int sourceId, bool api)
        {
            Id = id;
            AutonomousRegion = autonomousRegion;
            CityTown = cityTown;
            Cause = cause;
            IncidenceType = incidenceType;
            Province = province;
            Latitude = latitude;
            Longitude = longitude;
            StartDate = startDate;
            EndDate = endDate;
            SourceId = sourceId;
            Api = api;
        }
    }
}
