// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x3482B4E9, "STUUnlock_HeroMod")]
    public class STUUnlock_HeroMod : STUUnlock {
        [STUFieldAttribute(0x0E27C815, "m_description")]
        public teStructuredDataAssetRef<ulong> m_description;

        [STUFieldAttribute(0xB2CA6977, "m_identifier")]
        public teStructuredDataAssetRef<STUIdentifier> m_identifier;

        [STUFieldAttribute(0x32A11A46, "m_slot")]
        public Enum_796D50FE m_slot;
    }
}
