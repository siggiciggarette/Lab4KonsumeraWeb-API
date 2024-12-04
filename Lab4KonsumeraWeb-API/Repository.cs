using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Lab4KonsumeraWeb_API
{
    

    public class Repository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }

        [JsonPropertyName("pushed_at")]
        public DateTime PushedAt { get; set; }

        public override string ToString()
        {
            return $"\nName: {Name}\nDescription: {Description}\nURL: {HtmlUrl}\n" +
                   $"Homepage: {Homepage}\nWatchers: {Watchers}\nLast Pushed: {PushedAt}\n";
        }
    }



}
