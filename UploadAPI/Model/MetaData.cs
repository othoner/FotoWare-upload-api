﻿using Newtonsoft.Json;

namespace UploadAPI.Model
{
    [JsonArrayAttribute]
    public class MetaData
    {
        public List<MetaDataField> Fields { get; set; }
        public List<KeyValuePair<string, string>> Attributes { get; set; }
    }
}
