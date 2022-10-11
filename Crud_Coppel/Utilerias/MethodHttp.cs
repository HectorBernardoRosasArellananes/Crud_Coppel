using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Crud_Coppel.Utilerias
{
    public class MethodHttp
    {
        
        public static string GetItem(string RequestUrl, int id)
        {
            var url = RequestUrl + $"{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            string responseBody = string.Empty;
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            objReader.Close();
                        }
                    }
                }
                return responseBody;
            }
            catch (WebException ex)
            {
                return null;
            }
        }

        public static string GetItems(string RequestUrl)
        {
            var url = RequestUrl;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            string responseBody = string.Empty;
            try
            {
                using (WebResponse response =  request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            objReader.Close();
                        }
                    }
                }
                return responseBody;
            }
            catch (WebException ex)
            {
                return null;
            }
        }

        public static string PostItem(string RequestUrl, string AccessToken, object data,ref string HttpStatus)
        {
            var url = RequestUrl;
            var text = JsonConvert.SerializeObject(data);

            var request = (HttpWebRequest)WebRequest.Create(url);
            
            string json = text;
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            if (AccessToken != string.Empty)
            {
                request.PreAuthenticate = true;
                request.Headers.Add("Authorization", "Bearer " + AccessToken);
            }
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            string responseBody = string.Empty;
            try
            {
     
                    using (WebResponse response = request.GetResponse())
                    {

                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return null;


                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                 responseBody = objReader.ReadToEnd();

                                objReader.Close();
                            }
                        }
                    }

                return responseBody;

            }
            catch (WebException ex)
            {
                HttpStatus = ex.Message;
                return null;
            }
        }

        public static string DeleteItem(string RequestUrl, string AccessToken, int id)
        {
            string responseBody = string.Empty;
            var url = RequestUrl+ $"{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer " + AccessToken);
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            objReader.Close();
                           
                        }
                    }
                }
                return responseBody;
            }
            catch (WebException ex)
            {
                return null;
                // Handle error
            }
        }
    }
}
