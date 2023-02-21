namespace PeanutGambleClassic
{
    using System;
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;

    /// <inheritdoc />
    public class Plugin : Plugin<Config>
    {
		private EventHandlers eventHandlers;
		
        /// <inheritdoc/>
        public override string Author { get; } = "Snow";

        /// <inheritdoc/>
        public override string Name { get; } = "PeanutGambleClassic";

        /// <inheritdoc/>
        public override string Prefix { get; } = "PeanutGambleClassic";

        /// <inheritdoc/>
        public override Version Version { get; } = new Version(1, 1, 0);

        /// <inheritdoc/>
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.DroppingItem += eventHandlers.PlayerDroppedItem;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            PlayerHandlers.DroppingItem -= eventHandlers.PlayerDroppedItem;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}