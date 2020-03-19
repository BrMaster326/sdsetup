﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace SDSetupCommon.Communications {
    public class AbstractCommunications {
        public static async Task<ReturnType> GetAsync<ReturnType>(string endpoint) {
            HttpResponseMessage response = await EndpointSettings.HttpClient.GetAsync(new Uri(endpoint));
            if (response.IsSuccessStatusCode) {
                return await Task.Run<ReturnType>(async () => {
                    return JsonConvert.DeserializeObject<ReturnType>(await response.Content.ReadAsStringAsync());
                });
            } else {
                return default;
            }
        }

        public static async Task<ReturnType> PostJsonAsync<ReturnType, PostType>(string endpoint, PostType postData) {
            string json = JsonConvert.SerializeObject(postData);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await EndpointSettings.HttpClient.PostAsync(endpoint, content);
            if (response.IsSuccessStatusCode) {
                return await Task.Run<ReturnType>(async () => {
                    return JsonConvert.DeserializeObject<ReturnType>(await response.Content.ReadAsStringAsync());
                });
            } else {
                return default;
            }
        }
    }
}
