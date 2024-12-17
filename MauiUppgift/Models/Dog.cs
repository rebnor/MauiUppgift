using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiUppgift.Models
{
    public class Dog
    {
        [JsonPropertyName("image_link")]
        public string ImageLink { get; set; }

        [JsonPropertyName("good_with_children")]
        public int? GoodWithChildren { get; set; }

        [JsonPropertyName("good_with_other_dogs")]
        public int? GoodWithOtherDogs { get; set; }

        [JsonPropertyName("shedding")]
        public int? Shedding { get; set; }

        [JsonPropertyName("grooming")]
        public int? Grooming { get; set; }

        [JsonPropertyName("drooling")]
        public int? Drooling { get; set; }

        [JsonPropertyName("coat_length")]
        public int? CoatLength { get; set; }

        [JsonPropertyName("good_with_strangers")]
        public int? GoodWithStrangers { get; set; }

        [JsonPropertyName("playfulness")]
        public int? Playfulness { get; set; }

        [JsonPropertyName("protectiveness")]
        public int? Protectiveness { get; set; }

        [JsonPropertyName("trainability")]
        public int? Trainability { get; set; }

        [JsonPropertyName("energy")]
        public int? Energy { get; set; }

        [JsonPropertyName("barking")]
        public int? Barking { get; set; }

        [JsonPropertyName("min_life_expectancy")]
        public double? MinLifeExpectancy { get; set; }

        [JsonPropertyName("max_life_expectancy")]
        public double? MaxLifeExpectancy { get; set; }

        [JsonPropertyName("max_height_male")]
        public double? MaxHeightMale { get; set; }

        [JsonPropertyName("max_height_female")]
        public double? MaxHeightFemale { get; set; }

        [JsonPropertyName("max_weight_male")]
        public double? MaxWeightMale { get; set; }

        [JsonPropertyName("max_weight_female")]
        public double? MaxWeightFemale { get; set; }

        [JsonPropertyName("min_height_male")]
        public double? MinHeightMale { get; set; }

        [JsonPropertyName("min_height_female")]
        public double? MinHeightFemale { get; set; }

        [JsonPropertyName("min_weight_male")]
        public double? MinWeightMale { get; set; }

        [JsonPropertyName("min_weight_female")]
        public double? MinWeightFemale { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }



        // Beräknade egenskaper för vikt i kg
        public double? MinWeightMaleKg => MinWeightMale.HasValue ? Math.Round(MinWeightMale.Value * 0.453592, 2) : null;
        public double? MaxWeightMaleKg => MaxWeightMale.HasValue ? Math.Round(MaxWeightMale.Value * 0.453592, 2) : null;
        public double? MinWeightFemaleKg => MinWeightFemale.HasValue ? Math.Round(MinWeightFemale.Value * 0.453592, 2) : null;
        public double? MaxWeightFemaleKg => MaxWeightFemale.HasValue ? Math.Round(MaxWeightFemale.Value * 0.453592, 2) : null;


        // Beräknade egenskaper för höjd i cm
        public double? MinHeightMaleCm => MinHeightMale.HasValue ? MinHeightMale.Value * 2.54 : null;
        public double? MaxHeightMaleCm => MaxHeightMale.HasValue ? MaxHeightMale.Value * 2.54 : null;
        public double? MinHeightFemaleCm => MinHeightFemale.HasValue ? MinHeightFemale.Value * 2.54 : null;
        public double? MaxHeightFemaleCm => MaxHeightFemale.HasValue ? MaxHeightFemale.Value * 2.54 : null;

        public string LifeSpan => $"{MinLifeExpectancy}-{MaxLifeExpectancy} years";
    }
}
