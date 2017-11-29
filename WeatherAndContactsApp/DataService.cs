﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ModernHttpClient;

namespace WeatherAndContactsApp
{
    public class DataService
    {
        public static async Task<JContainer> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient(new NativeMessageHandler());
            var response = await client.GetAsync(queryString);

            JContainer data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = (JContainer)JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    }
}
