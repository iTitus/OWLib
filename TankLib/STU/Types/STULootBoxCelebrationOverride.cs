// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x73458B17, "STULootBoxCelebrationOverride")]
    public class STULootBoxCelebrationOverride : STUInstance {
        [STUFieldAttribute(0x649099ED, "m_celebrationType")]
        public teStructuredDataAssetRef<STUIdentifier> m_celebrationType;

        [STUFieldAttribute(0x7A404E56, "m_lootbox")]
        public teStructuredDataAssetRef<STUUnlock> m_lootbox;
    }
}
