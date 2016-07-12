using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Tulpep.Signtul.Entities;

namespace Tulpep.MailgunProxy.Controllers
{
    public class SendController : ApiController
    {
        public async Task<HttpStatusCode> Post(EmailMessage message)
        {
            using (var httpClient = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "from", message.From },
                    { "to", message.To },
                    { "subject", message.Subject },
                    { "html", String.Format("<h1>{0} {1}</h1>{2}", message.FromName, message.FromEmailAddress, message.Message) }

                };


                string credentials = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes("api" + ":" + ConfigurationManager.AppSettings[Constants.MailgunApiKey]));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                string url = String.Format("https://api.mailgun.net/v3/{0}/messages", ConfigurationManager.AppSettings[Constants.MailgunDomain]);
                var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(values));
                if(response.IsSuccessStatusCode)
                {
                    return HttpStatusCode.OK;
                }
                else
                {
                    return HttpStatusCode.InternalServerError;
                }
            }

        }
    }
}
