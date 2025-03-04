﻿using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    /// <summary>
    /// Base class for data models.
    /// This is a test
    /// </summary>
    public abstract class Model
    {
        // The value that uniquely identifies this object.
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}