using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OxyApi
{
    class Program
    {
        static async Task Main()
        {
            const string Username = "YOUR_USERNAME";
            const string Password = "YOUR_PASSWORD";

            var parameters = new Dictionary<string, string>()
            {
                { "source", "universal" },
                { "url", "https://www.trip.com/flights?locale=en-xx&allianceid=742331&sid=2506234&ppcid=adid-660427218467_akid-kwd-11635721_adgid-144762786930&utm_source=google&utm_medium=cpc&utm_campaign=sitelink&utm_extensiontype=sitelink&utm_extension=flight&gad_source=1&gclid=cj0kcqia7oqrbhd9arisak3uxh0t8thl3l86ic0h1fo1wind3utjhjhrafxiu3yeyfc3trwbfv4pz0kaahvlealw_wcb"},
            }


            var client = new HttpClient();

            Uri baseUri = new Uri("https://realtime.oxylabs.io");
            client.BaseAddress = baseUri;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/v1/queries");
            requestMessage.Content = JsonContent.Create(parameters);

            var authenticationString = $"{Username}:{Password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(authenticationString));
            requestMessage.Headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);

            var response = await client.SendAsync(requestMessage);
            var contents = await response.Content.ReadAsStringAsync();

            Console.WriteLine(contents);
        }
    }
}