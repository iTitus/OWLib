// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xA408D74F)]
    public class STU_A408D74F : STUInstance {
        [STUFieldAttribute(0x401F5484, "m_stimulus")]
        public teStructuredDataAssetRef<STUVoiceStimulus> m_stimulus;

        [STUFieldAttribute(0xF79D31F9, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUVoiceConversationLine[] m_F79D31F9;

        [STUFieldAttribute(0x4FF98D41, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_C1A2DB26 m_4FF98D41;

        [STUFieldAttribute(0x9CDDC24D, "m_weight")]
        public float m_weight;
    }
}
