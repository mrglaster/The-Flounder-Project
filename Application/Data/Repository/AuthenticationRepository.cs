using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;

using Glossa_App.Data.Repository.Interfaces;
using System.Xml;
//using Java.Lang;
//using Android.OS;

namespace Glossa_App.Data.Repository
{
    internal class AuthenticationRepository : IAuthenticationRepository
    {
        private const int SECRETKEY = 42;
        private const string URI = "http://192.168.0.12:8000";
        private readonly HttpClient _httpClient;
        private static AuthenticationRepository authenticationInstance = null;
        private const int _page_size = 5;

        private AuthenticationRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(URI);
        }

        public static AuthenticationRepository Initialize(HttpClient httpClient)
        {
            if (authenticationInstance == null)
                authenticationInstance = new AuthenticationRepository(httpClient);
            return authenticationInstance;
        }

        public async Task<string> AuthenticateUser(string _login, string _password)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    login = _login,
                    password = _password,
                    secretkey = SECRETKEY
                }),
                Encoding.UTF8,
                "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync(
                "login",
                jsonContent);
            string result = await response.Content.ReadAsStringAsync();
            JsonNode jsonResponse = JsonNode.Parse(result);
            return jsonResponse["status"].ToString();
        }

        public async Task<string> RegistrationUser(string _login, string _password, string _email)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    nickname = _login,
                    password = _password,
                    email = _email,
                    avatar = "null",
                    secretkey = SECRETKEY
                }),
                Encoding.UTF8,
                "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync(
                "register",
                jsonContent);
            string result = await response.Content.ReadAsStringAsync();
            JsonNode jsonResponse = JsonNode.Parse(result);
            return jsonResponse["status"].ToString();
        }

        public async Task<JsonNode> GetModules(int _page)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    page = _page,
                    page_size = _page_size,
                    secretkey = SECRETKEY
                }),
                Encoding.UTF8,
                "application/json");
            UriBuilder uriBuilder = new UriBuilder($"{URI}/study/latest_modules");
            uriBuilder.Query = $"secretkey={SECRETKEY}&page={_page}&page_size={_page_size}";
            using HttpResponseMessage response = await _httpClient.PostAsync(
                "study/latest_modules", jsonContent);
            //System.Diagnostics.Debug.WriteLine(uriBuilder.Uri.ToString());
            string result = await response.Content.ReadAsStringAsync();
            JsonNode jsonResponse = JsonNode.Parse(result);
            return jsonResponse;
        }

        public async Task<String> GetGSMF(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }

        //public async Task DownloadFile(string url, string filePath)
        //{
        //        // Отправка GET-запроса по указанной ссылке
        //        HttpResponseMessage response = await _httpClient.GetAsync(url);
        //        response.EnsureSuccessStatusCode();

        //        // Сохранение содержимого файла в указанный путь
        //        using (var fileStream = System.IO.File.Create(filePath))
        //        {
        //            await response.Content.CopyToAsync(fileStream);
        //        }
        //}

        //public async string LoadXmlFromUrl(string url)
        //{
        //        // Отправка GET-запроса по указанной ссылке
        //        HttpResponseMessage response = await _httpClient.GetAsync(url);
        //        response.EnsureSuccessStatusCode();

        //        // Получение содержимого файла в виде строки
        //       string xmlContent = await response.Content.ReadAsStringAsync();

        //    return xmlContent;
        //}
    }
}
