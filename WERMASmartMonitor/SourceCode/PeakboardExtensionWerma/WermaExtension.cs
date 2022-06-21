using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peakboard.ExtensionKit;

namespace PeakboardExtensionWerma
{
    [ExtensionIcon("PeakboardExtensionWerma.werma.png")]
    public class WermaExtension : ExtensionBase
    {
        protected override ExtensionDefinition GetDefinitionOverride()
        {
            return new ExtensionDefinition
            {
                ID = "Werma",
                Name = "Werma Extension",
                Description = "Modified Extension for a project at Hochschule Esslingen",
                Version = "1.0",
                Author = "Peakboard Team, edited by Pascal Rosenfeld",
                Company = "Peakboard GmbH",
                Copyright = "Copyright © 2021",
            };
        }

        protected override CustomListCollection GetCustomListsOverride()
        {
            return new CustomListCollection
            {
                new WermaController(),
                new WermaTimestampList()
            };
        }
    }
}
