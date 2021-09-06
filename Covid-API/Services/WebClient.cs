using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Covid_API.Services
{
    public class WebClient
    {
        private HttpClient Client { get; set; }

        public WebClient(string BaseAddress)
        {
            Client = new HttpClient
            {
                BaseAddress = new Uri(BaseAddress),
            };
        }

        public async Task<ResponseWebClient> GetAsyn(string path)
        {
            HttpResponseMessage message = await Client.GetAsync(path);
            return new ResponseWebClient
            {
                StatusCode = Convert.ToInt32(message.StatusCode),
                Content = await message.Content.ReadAsStringAsync(),
                RequestMessage = message.RequestMessage
            };

        }
    }

    public class ResponseWebClient
    {
        public int StatusCode { get; set; }
        public string Content { get; set; }
        public HttpRequestMessage RequestMessage { get; set; }
        public T Deserialize<T>()
        {
            try { return JsonSerializer.Deserialize<T>(Content); } catch { return default; }
        }

    }
      
}
