﻿using Newtonsoft.Json;
using qBittorrentSharp.Enums;
using System;

namespace qBittorrentSharp.JSON
{
    public class TorrentJSON
    {
        [JsonProperty("added_on")]
        public int Added_on { get; set; }

        [JsonProperty("amount_left")]
        public long Amount_left { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("completion_on")]
        public int Completion_on { get; set; }

        [JsonProperty("dl_limit")]
        public int Dl_limit { get; set; }

        [JsonProperty("dlspeed")]
        public int Dlspeed { get; set; }

        [JsonProperty("downloaded")]
        public long Downloaded { get; set; }

        [JsonProperty("downloaded_session")]
        public long Downloaded_session { get; set; }

        [JsonProperty("eta")]
        public int Eta { get; set; }

        [JsonProperty("f_l_piece_prio")]
        public bool F_l_piece_prio { get; set; }

        [JsonProperty("Force_start")]
        public bool Force_start { get; set; }

        [JsonProperty("last_activity")]
        public int Last_activity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_complete")]
        public int Num_complete { get; set; }

        [JsonProperty("num_incomplete")]
        public int Num_incomplete { get; set; }

        [JsonProperty("num_leechs")]
        public int Num_leechs { get; set; }

        [JsonProperty("num_seeds")]
        public int Num_seeds { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("progress")]
        public float Progress { get; set; }

        [JsonProperty("ratio")]
        public float Ratio { get; set; }

        [JsonProperty("ratio_limit")]
        public float Ratio_limit { get; set; }

        [JsonProperty("Save_path")]
        public string Save_path { get; set; }

        [JsonProperty("seen_complete")]
        public int Seen_complete { get; set; }

        [JsonProperty("seq_dl")]
        public bool Seq_dl { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("state")]
        public States State { get; set; }

        [JsonProperty("super_seeding")]
        public bool Super_seeding { get; set; }

        [JsonProperty("total_size")]
        public long Total_size { get; set; }

        [JsonProperty("tracker")]
        public Uri Tracker { get; set; }

        [JsonProperty("up_limit")]
        public int Up_limit { get; set; }

        [JsonProperty("uploaded")]
        public long Uploaded { get; set; }

        [JsonProperty("uploaded_session")]
        public long Uploaded_session { get; set; }

        [JsonProperty("upspeed")]
        public int Upspeed { get; set; }
    }
}
