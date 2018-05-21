﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace JiraDashboard.Localization
{
    public static class JiraDashboardLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(JiraDashboardConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(JiraDashboardLocalizationConfigurer).GetAssembly(),
                        "JiraDashboard.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
