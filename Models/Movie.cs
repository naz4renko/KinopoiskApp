using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KinopoiskApp.Models
{
    public class Movie 
    {
        [JsonProperty("kinopoiskId")]
        public int KinopoiskId {  get; private set; }

        [JsonProperty("nameRu")]
        public string NameRu { get; private set; }

        [JsonProperty("nameEn")]
        public string NameEn { get; private set; }

        [JsonProperty("year")]
        public int Year { get; private set; }

        [JsonProperty("posterUrlPreview")]
        public string PosterUrl { get; private set; }

        public Movie(int kinopoiskId, string nameRu, string nameEn, int year, string posterUrl)
        {
            KinopoiskId = kinopoiskId;
            NameRu = nameRu;
            NameEn = nameEn;
            Year = year;
            PosterUrl = posterUrl;
        }
    }
}
