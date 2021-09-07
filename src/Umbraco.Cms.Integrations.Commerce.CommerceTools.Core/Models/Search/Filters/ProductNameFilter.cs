﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Umbraco.Cms.Integrations.Commerce.CommerceTools.Core.Models.Search.Filters
{
    public class ProductNameFilter : BaseFilter
    {
        public string Name { get; }

        public string LanguageCode { get; }

        /// <summary>
        /// Filter for a specific name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="languageCode"></param>
        public ProductNameFilter(string name, string languageCode)
        {
            Name = name;
            LanguageCode = languageCode;
        }

        public override string Stringify()
        {
            return $"masterData(current(name({LanguageCode}=\"{Name}\")))";
        }
    }
}
