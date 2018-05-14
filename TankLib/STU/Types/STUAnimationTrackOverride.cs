// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x386DA0AA, "STUAnimationTrackOverride")]
    public class STUAnimationTrackOverride : STUInstance {
        [STUFieldAttribute(0x0D5E2F60, "m_animCurve", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimCurve m_animCurve;

        [STUFieldAttribute(0x547D9847, "m_dataFlow")]
        public teStructuredDataAssetRef<STUDataFlow> m_dataFlow;

        [STUFieldAttribute(0x5180E750, "m_value")]
        public float m_value;
    }
}
