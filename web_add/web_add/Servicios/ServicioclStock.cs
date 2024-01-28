using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Serialization;
using web_add.Servicios.Models;

namespace web_add
{
    public class ServicioclStock
    {
        public static bool AlwaysGoodCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors policyErrors)
        {
            return true;
        }
        string urlapi = WebConfigurationManager.AppSettings["urlapi"].ToString();
        public ServicioclStock() { }
        public List<clStock> GetList(string Token)
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(AlwaysGoodCertificate);
            List<clStock> oRol = new List<clStock>();
            var request = (HttpWebRequest)WebRequest.Create(urlapi + "Rol/ ");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization", "Bearer " + Token);
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                            return oRol;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JavaScriptSerializer j = new JavaScriptSerializer();
                            if (responseBody != null)
                            {
                                if (responseBody != "")
                                    oRol = j.Deserialize<List<clStock>>(responseBody);
                            }
                            return oRol;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.Write(ex.Message);
                return oRol;
            }
        }
    }
}