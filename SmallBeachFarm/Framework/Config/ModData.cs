#nullable disable

using System;
using Microsoft.Xna.Framework;

namespace Pathoschild.Stardew.SmallBeachFarm.Framework.Config
{
    /// <summary>The mod's hardcoded data.</summary>
    internal class ModData
    {
        /// <summary>Tile areas in the farm map where both river and ocean fish can be caught.</summary>
        public Rectangle[] MixedFishAreas { get; set; } = Array.Empty<Rectangle>();
    }
}
