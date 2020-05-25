// ////////////////////////////////////////////////////
// StartTime:      2020/5/25 11:27
// FileName:       RequestUtil.cs
// Author:           psyduck007@outlook.com
// Purpose:         Lazy dog does not write purpose
// TODO:
// ////////////////////////////////////////////////////
//
//
using System;
using System.Net;
using System.Text.Json;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace DBACommonPackage.Utils
{
    public class HttpRequestUtil
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HttpRequestUtil> _p;
        public HttpRequestUtil(Uri urlBase, HttpClient httpClient, ILogger<HttpRequestUtil> logger)
        {
            _p = logger;
            _httpClient = httpClient;
            _httpClient.BaseAddress = urlBase;
            _p.LogDebug($"{this.GetType()} initilized");
        }

        public async void FetchAllNodes()
        {
            // 从这里抄的代码 https://github.com/PlayFab/consuldotnet/blob/master/Consul/Client.cs line from 947
            var resp = await _httpClient.GetAsync("v1/catalog/nodes");
            if (resp.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Get ${resp.RequestMessage.RequestUri} failed,code: {resp.StatusCode}");
            }
            var rawBytes = await resp.Content.ReadAsByteArrayAsync();
            JsonSerializer.Deserialize<string>(rawBytes);
        }
    }
}
