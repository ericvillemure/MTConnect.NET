﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml.Serialization;

namespace MTConnect.MTConnectDevices
{
    public class Filter
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
