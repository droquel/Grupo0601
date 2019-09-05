using System;


namespace Grupo0601.raiz
{
    // Validar librerias
    class Raiz
    {
        //
        public static string API_KEY = "c53bbb8a57a3796dc8834c682a36cfdb";
        public static string API_LINK = "http://api.openweathermap.org/data/2.5/weather";

        public static string API_REQUEST(string lat, string lng)
        {
            StringBuilder ab = new StringBuilder(API_LINK);
            sb.AppenedFormat("?lat={0}&lon{1}&APPID={2}&units=metric");
            return sb.toString();
        }

    }

    public static DateTime unixTimeStampToDateTime(double unixTimeStamp)
    {
        DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        dt = dt.AddSeconds(unixTimeStamp).ToLocalTime();
        return dt;
    }

    public static String getImage(String icon)
    {
        return $"http://openweathermap.org/img/w/{icon}.png";
    }
}