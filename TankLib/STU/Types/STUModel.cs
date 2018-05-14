// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x1582A494, "STUModel")]
    public class STUModel : STUInstance {
        [STUFieldAttribute(0xC452A30B, "m_lighting", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUModelLighting m_lighting;

        [STUFieldAttribute(0x55260B76, "m_info", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUModelInfo m_info;

        [STUFieldAttribute(0xDD99BB78, "m_lod", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUModelLOD m_lod;

        [STUFieldAttribute(0xD2821F52, "m_skeleton")]
        public teStructuredDataAssetRef<STUSkeleton> m_skeleton;

        [STUFieldAttribute(0x76FA48C2, "m_transforms", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUModelTransform[] m_transforms;

        [STUFieldAttribute(0xA8B28299, "m_hardPoints", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUModelHardpoint[] m_hardPoints;

        [STUFieldAttribute(0xE860DC51, "m_collisionShapes", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_5903254B[] m_collisionShapes;

        [STUFieldAttribute(0x53D62B9A, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_250549AE[] m_53D62B9A;

        [STUFieldAttribute(0x1CC68EC9, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_E0E6BDF3[] m_1CC68EC9;

        [STUFieldAttribute(0x7FA005E4)]
        public teStructuredDataAssetRef<STU_875E571C>[] m_7FA005E4;

        [STUFieldAttribute(0xECA54F6C, "m_breakable", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUBreakable m_breakable;

        [STUFieldAttribute(0x3B888342, "m_usageCategory")]
        public Enum_BD2B42FA m_usageCategory;

        [STUFieldAttribute(0x9466F0DC)]
        public Enum_ACBB4E26 m_9466F0DC;

        [STUFieldAttribute(0x352D8841)]
        public byte m_352D8841;

        [STUFieldAttribute(0xCB9BBC10)]
        public byte m_CB9BBC10;
    }
}
