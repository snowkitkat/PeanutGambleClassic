namespace PeanutGambleClassic
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug messages should be shown in the console.
        /// </summary>
        [Description("Whether debug logs should be shown in the console.")]
        public bool Debug { get; set; }

        [Description("Allowed ItemIDs to spawn. (Ex; 48 to allow the Com45 from spawning. Valid numbers are 0-48. Use -1 for none.")]
        public int[] Whitelist { get; set; } = new int[] {-1, 0, 1, 2, 3, 4, 5};
    }
}