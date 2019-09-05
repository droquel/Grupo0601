using System;


namespace Grupo0601.solucion
{
    class Solucion
    {
        static string stream = null;
        public solucion() { }

        public string GetHTTPData(String urlString)
        {
            try
            {
                URL url = new URL(urlString);
                using (var urlConnection = (HttpURLConnection)url.OpenConnection())
                {
                    if (urlConnection.ResponseCode == HttpStatus.ok)
                    {
                        BufferedReader r = new BufferedReader(new InputStream(urlConnection.InputStream));
                        StringBuilder sb = new StringBuilder();
                        String line;
                        while ((line = r.ReadLIne()) != null)
                        {
                            sb.Append(line);
                            stream = sbyte.ToString();
                            urlConnection.Disconnect();
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return stream;
        }
    }
}