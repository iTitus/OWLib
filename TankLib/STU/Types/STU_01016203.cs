// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x01016203)]
    public class STU_01016203 : STUMirroredEntityComponent {
        [STUFieldAttribute(0x08DDC625, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_0C33E577 m_08DDC625;

        [STUFieldAttribute(0xA4D9D745, "m_eyeHardpoint")]
        public teStructuredDataAssetRef<STUHardPoint> m_eyeHardpoint;

        [STUFieldAttribute(0x57D655AD, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAIWeaponFireControlInfo[] m_57D655AD;
    }
}
