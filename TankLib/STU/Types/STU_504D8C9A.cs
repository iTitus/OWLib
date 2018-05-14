// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.Math;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x504D8C9A)]
    public class STU_504D8C9A : STUInstance {
        [STUFieldAttribute(0x82B882AD)]
        public teStructuredDataAssetRef<STUThumbnailData> m_82B882AD;

        [STUFieldAttribute(0xAB0D1C71, "m_contactMaterial")]
        public teStructuredDataAssetRef<STUContactMaterial> m_contactMaterial;

        [STUFieldAttribute(0xE91154F1, "m_materialData")]
        public teStructuredDataAssetRef<STUMaterialData> m_materialData;

        [STUFieldAttribute(0xC83CF0BB, "m_materialType", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUMaterialType m_materialType;

        [STUFieldAttribute(0x1D560AAD)]
        public teColorRGBA m_1D560AAD;

        [STUFieldAttribute(0x70D5340F)]
        public float m_70D5340F;

        [STUFieldAttribute(0x8FBF4044, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_231BC8AF m_8FBF4044;

        [STUFieldAttribute(0xE9E94493)]
        public byte m_E9E94493;

        [STUFieldAttribute(0xA0553E74)]
        public byte m_A0553E74;

        [STUFieldAttribute(0x85966B46)]
        public byte m_85966B46;

        [STUFieldAttribute(0x14C8231D)]
        public byte m_14C8231D;

        [STUFieldAttribute(0xD108766C)]
        public byte m_D108766C;

        [STUFieldAttribute(0x1573E215)]
        public byte m_1573E215;

        [STUFieldAttribute(0xC000D95E)]
        public byte m_C000D95E;
    }
}
