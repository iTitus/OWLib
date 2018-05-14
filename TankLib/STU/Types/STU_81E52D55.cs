// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x81E52D55)]
    public class STU_81E52D55 : STU_01C5AB87 {
        [STUFieldAttribute(0x5D71EE31, "m_numeratorStat")]
        public teStructuredDataAssetRef<STUStat> m_numeratorStat;

        [STUFieldAttribute(0xDDD19A1F, "m_denominatorStat")]
        public teStructuredDataAssetRef<STUStat> m_denominatorStat;

        [STUFieldAttribute(0xD9813284, "m_maps", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_3B0A36A8 m_maps;
    }
}
