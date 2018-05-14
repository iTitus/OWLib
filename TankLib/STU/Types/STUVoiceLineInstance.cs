// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x8884C15A, "STUVoiceLineInstance")]
    public class STUVoiceLineInstance : STUInstance {
        [STUFieldAttribute(0xA13D55A6, "m_effectHardpoint")]
        public teStructuredDataAssetRef<STUHardPoint> m_effectHardpoint;

        [STUFieldAttribute(0xC903EEAE)]
        public teStructuredDataAssetRef<STU_722E96D9> m_C903EEAE;

        [STUFieldAttribute(0x7B562F09, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_07A46D78 m_7B562F09;

        [STUFieldAttribute(0x77B08A61, "m_voiceLineRuntime", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUVoiceLine m_voiceLineRuntime;

        [STUFieldAttribute(0x06207B8F, "m_resourceKey")]
        public ulong m_resourceKey;
    }
}
