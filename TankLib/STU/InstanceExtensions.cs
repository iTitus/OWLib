using TankLib.STU.Types;

namespace TankLib.STU {
    public static class InstanceExtensions {
        #region STU_02514B6A
        public static ulong GetChunkKey(this STUMapHeader w, byte type) {
            return (w.m_map & ~0xFFFF00000000ul) | ((ulong) type << 32);
        }
        
        public static ulong GetChunkKey(this STUMapHeader w, Enums.teMAP_PLACEABLE_TYPE type) {
            return (w.m_map & ~0xFFFF00000000ul) | ((ulong) type << 32);
        }
        #endregion
    }
}