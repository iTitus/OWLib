// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x0DF7E24F, "STUStatescriptGraph")]
    public class STUStatescriptGraph : STUInstance {
        [STUFieldAttribute(0x45B2BAB8, "m_graph", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUGraph m_graph;

        [STUFieldAttribute(0x51CABA98, "m_nodes", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptBase[] m_nodes;

        [STUFieldAttribute(0x7B5125B3, "m_states", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptState[] m_states;

        [STUFieldAttribute(0x77B7FF8C, "m_entries", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptEntry[] m_entries;

        [STUFieldAttribute(0x682B3B61, "m_consoleCommand")]
        public teString m_consoleCommand;

        [STUFieldAttribute(0xCE243EEE)]
        public teStructuredDataAssetRef<STUIdentifier>[] m_CE243EEE;

        [STUFieldAttribute(0xA258A936)]
        public teStructuredDataAssetRef<STUIdentifier>[] m_A258A936;

        [STUFieldAttribute(0xFE8F3A77)]
        public teStructuredDataAssetRef<STUIdentifier>[] m_FE8F3A77;

        [STUFieldAttribute(0x2AEFDE3F)]
        public teStructuredDataAssetRef<STUIdentifier>[] m_2AEFDE3F;

        [STUFieldAttribute(0xE03B7F7B)]
        public int[] m_E03B7F7B;

        [STUFieldAttribute(0xD9B17C50)]
        public int[] m_D9B17C50;

        [STUFieldAttribute(0x3EFC52DE)]
        public teStructuredDataAssetRef<STUIdentifier>[] m_3EFC52DE;

        [STUFieldAttribute(0xD6484A9C, "m_remoteSyncNodes", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptBase[] m_remoteSyncNodes;

        [STUFieldAttribute(0x0E7F6C88, "m_syncVars", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUStatescriptSyncVar[] m_syncVars;

        [STUFieldAttribute(0x6B840897, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUStatescriptOperationPattern[] m_6B840897;

        [STUFieldAttribute(0x0EF4C042, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUStatescriptOperationPattern[] m_0EF4C042;

        [STUFieldAttribute(0x7CAAB050, "m_publicSchema", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUStatescriptSchema m_publicSchema;

        [STUFieldAttribute(0xF321AB27, "m_playScriptHotReloadBehavior")]
        public Enum_F21FF822 m_playScriptHotReloadBehavior;

        [STUFieldAttribute(0x0BCE4CB5)]
        public uint m_0BCE4CB5;

        [STUFieldAttribute(0x0E4C38E1, "m_predictionBehavior")]
        public Enum_79A4B921 m_predictionBehavior;

        [STUFieldAttribute(0xF7EAE932, "m_nodesBitCount")]
        public int m_nodesBitCount;

        [STUFieldAttribute(0xB6A640C2, "m_statesBitCount")]
        public int m_statesBitCount;

        [STUFieldAttribute(0x47600440, "m_remoteSyncNodesBitCount")]
        public int m_remoteSyncNodesBitCount;

        [STUFieldAttribute(0xB30634BA, "m_syncVarsBitCount")]
        public int m_syncVarsBitCount;

        [STUFieldAttribute(0x47E36E2C)]
        public int m_47E36E2C;

        [STUFieldAttribute(0xAC1C3244)]
        public int m_AC1C3244;

        [STUFieldAttribute(0x01169D71)]
        public byte m_01169D71;

        [STUFieldAttribute(0xFE10F816)]
        public byte m_FE10F816;

        [STUFieldAttribute(0xCD875AE9)]
        public byte m_CD875AE9;

        [STUFieldAttribute(0xC8356376)]
        public byte m_C8356376;
    }
}
