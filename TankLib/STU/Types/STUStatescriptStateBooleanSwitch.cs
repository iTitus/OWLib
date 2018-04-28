// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x76F0CF47, "STUStatescriptStateBooleanSwitch")]
    public class STUStatescriptStateBooleanSwitch : STUStatescriptState {
        [STUFieldAttribute(0xBAA74493, "m_condition", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_condition;

        [STUFieldAttribute(0xCCB1626C, "m_onTruePlug", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptOutputPlug m_onTruePlug;

        [STUFieldAttribute(0x4ED7649D, "m_onFalsePlug", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptOutputPlug m_onFalsePlug;

        [STUFieldAttribute(0x508D4685, "m_trueSubgraphPlug", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_904BFCEC m_trueSubgraphPlug;

        [STUFieldAttribute(0x3953AC0D, "m_falseSubgraphPlug", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_904BFCEC m_falseSubgraphPlug;
    }
}