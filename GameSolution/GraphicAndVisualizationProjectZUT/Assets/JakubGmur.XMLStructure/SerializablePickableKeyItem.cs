﻿using System;
using System.Xml.Serialization;

namespace Assets.JakubGmur.XMLStructure
{
    [Serializable]
    public class SerializablePickableKey : SerializablePickable
    {

        public SerializablePickableKey()
        {

        }

        public SerializablePickableKey(string targetDoorId)
        {
            TargetDoorId = targetDoorId;
        }

        [XmlElement("TargetDoorId")]
        public string TargetDoorId { get; set; }
    }
}
