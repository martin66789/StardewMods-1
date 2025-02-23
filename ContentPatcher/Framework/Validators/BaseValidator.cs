#nullable disable

using ContentPatcher.Framework.Patches;
using StardewModdingAPI;

namespace ContentPatcher.Framework.Validators
{
    /// <summary>The base implementation for a content pack validator.</summary>
    internal abstract class BaseValidator : IAssetValidator
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Validate a content pack.</summary>
        /// <param name="assetName">The asset name being loaded.</param>
        /// <param name="data">The loaded asset data to validate.</param>
        /// <param name="patch">The patch which loaded the asset.</param>
        /// <param name="error">An error message which indicates why validation failed.</param>
        /// <returns>Returns whether validation succeeded.</returns>
        public virtual bool TryValidate<T>(IAssetName assetName, T data, IPatch patch, out string error)
        {
            error = null;
            return false;
        }
    }
}
