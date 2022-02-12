using System;

namespace AutonomousCars
{
    public class GPSData
    {
        // Latitude value in degrees [-90.000000:90.000000]
        // ( 90 degrees south to 90 degrees north )
        public double Latitude { get;}

        // Longitude value in degrees [-180.000000:180.000000]
        // ( 180 degrees west to 180 degrees east )
        public double Longitude { get;}

        // Altitude value in millimeters above sea level
        public double Altitude { get;}

        public GPSData(double latitude, double longitude, double altitude)
        {
            if (latitude < -90 || latitude > 90)
            {
                throw new ArgumentException("Invalid latitude value!");
            }

            if (longitude < -180 || longitude > 180)
            {
                throw new ArgumentException("Invalid longitude value!");
            }

            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        public GPSData(GPSData gpsData)
        {
            Latitude = gpsData.Latitude;
            Longitude = gpsData.Longitude;
            Altitude = gpsData.Altitude;
        }
    }
}