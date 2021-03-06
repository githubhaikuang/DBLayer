﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DBLayer.Persistence.Configuration.Property;

namespace DBLayer.Persistence.Configuration
{
    public class PropertySection : ConfigurationSection
    {
        public const string SectionName = "atom/prop";


        private const string xmlnsXmlKey = "xmlns";

        [ConfigurationProperty(xmlnsXmlKey, IsRequired = false, DefaultValue = "urn:property")]
        public string Xmlns
        {
            get { return (string)this[xmlnsXmlKey]; }
            set { this[xmlnsXmlKey] = value; }
        }
        
        [ConfigurationProperty(PropertyElementCollection.CollectionXmlName, IsRequired = true)]
        public PropertyElementCollection AtomProperties
        {
            get { return this[PropertyElementCollection.CollectionXmlName] as PropertyElementCollection; }
            set
            {
                this[PropertyElementCollection.CollectionXmlName] = value;
            }
        }
    }
}
