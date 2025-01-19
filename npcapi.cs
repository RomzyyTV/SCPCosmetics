using Exiled.API.Features;
using UnityEngine;

namespace NPCs.API
{
    public static class Extensions
    {
        public static bool IsNpc(this Player player) => player is Npc;

        public static bool IsNpc(this ReferenceHub referenceHub)
        {
            return ((Component)referenceHub).gameObject.IsNpc();
        }

        public static bool IsNpc(this GameObject gameObject) => Npc.Dictionary.ContainsKey(gameObject);
    }
}
