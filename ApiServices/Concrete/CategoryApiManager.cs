using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlogFront.ApiServices.Interfaces;
using BlogFront.Models;
using Newtonsoft.Json;

namespace BlogFront.ApiServices.Concrete{
    public class CategoryApiManager : ICategoryApiService
    {
        private readonly HttpClient _httpClient;
        public CategoryApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress= new Uri("http://localhost:49602/api/categories/");
        }
        public async Task<List<CategoryListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<CategoryListModel>>
                (await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<List<CategoryWithBlogsCountModel>> GetAllWithBlogsCount(){
            var responseMessage = await _httpClient.GetAsync("GetWithBlogsCount");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<CategoryWithBlogsCountModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<CategoryListModel> GetByIdAsync(int id){
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<CategoryListModel>(await 
                responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}