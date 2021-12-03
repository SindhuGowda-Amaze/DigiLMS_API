using Newtonsoft.Json;
using System.Collections.Generic;

namespace  FreshersApp.Common.Email
{
    public class ASM
    {

        [JsonProperty(PropertyName = "group_id")]
        public int GroupId { get; set; }

        [JsonProperty(PropertyName = "groups_to_display")]
        public List<int> GroupsToDisplay { get; set; }
    }
}