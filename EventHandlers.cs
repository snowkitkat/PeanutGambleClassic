namespace PeanutGambleClassic
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Player;
    using System;
    using Exiled.API.Features;
    using Exiled.API.Features.Items;

    /// <summary>
    /// General event handlers.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">The <see cref="Plugin{TConfig}"/> class reference.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void PlayerDroppedItem(DroppingItemEventArgs ev)
        {
            if (ev.Player.CurrentRoom.Type == Exiled.API.Enums.RoomType.Lcz173 && UnityEngine.Vector3.Distance(ev.Player.CurrentRoom.GameObject.transform.InverseTransformPoint(ev.Player.Position), new UnityEngine.Vector3(17.0f, 12.4f, 8.0f)) <= 6.6f)
            {
                ev.IsAllowed = false;
                ev.Item.Destroy();
                int[] arr = plugin.Config.Whitelist;
                Item item = Item.Create((ItemType)arr[UnityEngine.Random.Range(0, arr.Length)]);
                item.CreatePickup(ev.Player.Position);
            }

            // GET DROP ITEM POS --> Log.Info(ev.Player.CurrentRoom.GameObject.transform.InverseTransformPoint(ev.Player.Position));
        }
    }
}