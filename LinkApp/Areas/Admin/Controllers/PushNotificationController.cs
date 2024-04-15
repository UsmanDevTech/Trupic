using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Trupic.Areas.Admin.Controllers
{
    public class PushNotificationController : Controller
    {
        // GET: Admin/PushNotification
        public async Task<bool> SendMessageToClient(string Fcm, string body, string title)
        {
            string content = string.Empty;
            HttpClient httpClient = null;
            HttpResponseMessage response = null;
            try
            {
                // Get this from your Firebase Developer Console Login  
                string serverApiKey = "	AAAAlzvLz3Q:APA91bEPeDXcRNGDR94nANC5qY_hA8R-x0yxEPhYRHhrkpTKZV_0TQNZkgAHjOVuLC8Zdn3HzxEKUTisbzM5YVjSW5YiyUmCJYdAJ3EIg9PhIKBewxBsvtXFyiJc5tvbZ7FT6GyJ3zpd";
                string apiEndpoint = "https://fcm.googleapis.com/fcm/send";
                using (httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", (string.Format("key={0}", serverApiKey)));
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    var dynamicPostData = new
                    {
                        to = Fcm,
                        notification = new
                        {
                            sound = "default",
                            body = body,
                            title = title,
                            content_available = true,
                            priority = "high"
                        },
                    };
                    response = httpClient.PostAsJsonAsync(new Uri(apiEndpoint), dynamicPostData).Result;

                    content = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();

                    FCMGroupResponse resp = JsonConvert.DeserializeObject<FCMGroupResponse>(content);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public class FCMGroupResponse
        {
            public long multicast_id { get; set; }
            public int success { get; set; }
            public int failure { get; set; }
            public int canonical_ids { get; set; }
        }
    }
}