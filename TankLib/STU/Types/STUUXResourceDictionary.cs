// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x18B8F445, "STUUXResourceDictionary")]
    public class STUUXResourceDictionary : STUUXObject {
        [STUFieldAttribute(0x2A217ECD, "m_keys")]
        public ulong[] m_keys;

        [STUFieldAttribute(0x70341E18, "m_values", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUUXObject[] m_values;

        [STUFieldAttribute(0xBBA15F10)]
        public teStructuredDataAssetRef<ulong>[] m_BBA15F10;

        [STUFieldAttribute(0x3547155A, "m_resourceKeyLookup", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_EDCF5A52 m_resourceKeyLookup;
    }
}
