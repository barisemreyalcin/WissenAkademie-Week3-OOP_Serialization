using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonSerialization
{
    public class User
    {
        [JsonPropertyName("User Id")]
        public int UserId { get; set; }
        [JsonPropertyName("Username")]
        public string Username { get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }
        [JsonPropertyName("Login Status")]
        public bool IsLoggedIn { get; set; }
        [JsonPropertyName("Login History")]
        //[JsonIgnore] // Datada bunu göstermemesi için
        public List<LoginInformation> LoginInfo { get; set; }
    }
}
