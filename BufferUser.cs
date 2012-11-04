﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace BufferAPI
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BufferUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("activity_at")]
        public long LastActivitySeconds { get; set; }

        public DateTime LastActivity
        {
            get
            {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                dtDateTime = dtDateTime.AddSeconds(LastActivitySeconds).ToLocalTime();
                return dtDateTime;
            }
        }

        [JsonProperty("created_at")]
        public long CreatedAtSeconds { get; set; }

        public DateTime CreatedAt
        {
            get
            {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                dtDateTime = dtDateTime.AddSeconds(CreatedAtSeconds).ToLocalTime();
                return dtDateTime;
            }
        }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("referral_link")]
        public string ReferralLink { get; set; }

        [JsonProperty("secret_email")]
        public string SecretEmail { get; set; }
    }
}
