using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InsightGaming_V1._0
{
    class VideoJuegos
    {
    
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }

        [JsonProperty("user_platforms")]
        public bool UserPlatforms { get; set; }
    

    public partial class Result
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playtime")]
        public long Playtime { get; set; }

        [JsonProperty("platforms")]
        public object[] Platforms { get; set; }

        [JsonProperty("stores")]
        public object[] Stores { get; set; }

        [JsonProperty("released")]
        public DateTimeOffset? Released { get; set; }

        [JsonProperty("tba")]
        public bool Tba { get; set; }

        [JsonProperty("background_image")]
        public Uri BackgroundImage { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("rating_top")]
        public long RatingTop { get; set; }

        [JsonProperty("ratings")]
        public object[] Ratings { get; set; }

        [JsonProperty("ratings_count")]
        public long RatingsCount { get; set; }

        [JsonProperty("reviews_text_count")]
        public long ReviewsTextCount { get; set; }

        [JsonProperty("added")]
        public long Added { get; set; }

        [JsonProperty("added_by_status")]
        public AddedByStatus AddedByStatus { get; set; }

            [JsonProperty("metacritic")]
            public long? Metacritic { get; set; } = 20;

        [JsonProperty("suggestions_count")]
        public long SuggestionsCount { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("score")]
        public object Score { get; set; }

        [JsonProperty("clip")]
        public Clip Clip { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("user_game")]
        public object UserGame { get; set; }

        [JsonProperty("reviews_count")]
        public long ReviewsCount { get; set; }

        [JsonProperty("saturated_color")]
        public string SaturatedColor { get; set; }

        [JsonProperty("dominant_color")]
        public string DominantColor { get; set; }

        [JsonProperty("short_screenshots")]
        public object[] ShortScreenshots { get; set; }

        [JsonProperty("parent_platforms")]
        public object[] ParentPlatforms { get; set; }

        [JsonProperty("genres")]
        public object[] Genres { get; set; }
    }

    public partial class AddedByStatus
    {
    }

    }
    public partial class Clip
    {
        [JsonProperty("clip")]
        public Uri ClipClip { get; set; }

        [JsonProperty("clips")]
        public Clips Clips { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("preview")]
        public Uri Preview { get; set; }
    }
     public partial class Clips
    {
        [JsonProperty("320")]
        public Uri The320 { get; set; }

        [JsonProperty("640")]
        public Uri The640 { get; set; }

        [JsonProperty("full")]
        public Uri Full { get; set; }
    }
}
