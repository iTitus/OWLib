// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x08386AAC, "STUGameModeVarValuePair")]
    public class STUGameModeVarValuePair : STUInstance {
        [STUFieldAttribute(0x786F3480)]
        public teStructuredDataAssetRef<STUIdentifier> m_786F3480;

        [STUFieldAttribute(0x5180E750, "m_value", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUGameModeValue m_value;
    }
}
