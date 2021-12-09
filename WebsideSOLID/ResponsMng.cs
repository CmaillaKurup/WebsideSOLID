using System;
using System.Net;

namespace WebsideSOLID
{
    public class ResponsMng : IResponseMng
    {
        public void webrequest()
        {
            WebRequest request = WebRequest.Create("https://docs.microsoft.com");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            response.Close();
        }
    }
}