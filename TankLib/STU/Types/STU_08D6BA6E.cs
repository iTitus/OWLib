// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x08D6BA6E)]
    public class STU_08D6BA6E : STUStatescriptAction {
        [STUFieldAttribute(0x03AD3873, "m_ignoreEntities", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar[] m_ignoreEntities;

        [STUFieldAttribute(0x1A44BF69, "m_startPosWS", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_startPosWS;

        [STUFieldAttribute(0x40FFACD9, "m_dirWS", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_dirWS;

        [STUFieldAttribute(0xBC946B94, "m_castLength", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_castLength;

        [STUFieldAttribute(0x1F94170C, "m_castRadius", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_castRadius;

        [STUFieldAttribute(0x8CBE558B, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_8CBE558B;

        [STUFieldAttribute(0x7404C882, "m_castFilter", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVarFilter m_castFilter;

        [STUFieldAttribute(0x23974AAB, "m_out_HitSomething", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVarDynamic m_out_HitSomething;

        [STUFieldAttribute(0x70E41E8A, "m_out_HitEntity", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVarDynamic m_out_HitEntity;

        [STUFieldAttribute(0x2158DFDE, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVarDynamic m_2158DFDE;

        [STUFieldAttribute(0xB3FC76F3, "m_out_HitPointWS", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVarDynamic m_out_HitPointWS;

        [STUFieldAttribute(0x3BDBD513, "m_out_HitNormal", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVarDynamic m_out_HitNormal;

        [STUFieldAttribute(0x0619C597, "m_type")]
        public Enum_54CE6D16 m_type;
    }
}
