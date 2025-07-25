using System.Text.Json.Serialization;

namespace Models
{
    public class UserData
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("UserId")]
        public int UserId  { get; set; }
        
        [JsonPropertyName("Email")]
        public string Email  { get; set; }
        
        [JsonPropertyName("FullName")]
        public string FullName  { get; set; }

    }
}