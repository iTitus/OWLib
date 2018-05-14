// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xCCAB4575, "STULootBoxCurrencyUnlocks")]
    public class STULootBoxCurrencyUnlocks : STUInstance {
        [STUFieldAttribute(0x719E981B, "m_unlocks", ReaderType = typeof(InlineInstanceFieldReader))]
        public STULootBoxCurrencyRarityUnlock[] m_unlocks;

        [STUFieldAttribute(0x581570BA, "m_lootboxType")]
        public Enum_26C6CD90 m_lootboxType;
    }
}
