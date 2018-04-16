// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x871BD3D0, "STUModel")]
    public class STUModel : STUInstance {
        [STUFieldAttribute(0xC4A1DCA0, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_70778323 m_C4A1DCA0;

        [STUFieldAttribute(0xE52AB6E7, "m_info", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUModelInfo m_info;

        [STUFieldAttribute(0xF5E50593, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_E3E39626 m_F5E50593;

        [STUFieldAttribute(0x818D011C)]
        public teStructuredDataAssetRef<STUSkeleton> m_818D011C;

        [STUFieldAttribute(0xFD232466, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_F0E34581[] m_FD232466;

        [STUFieldAttribute(0xC45F5F6F, "m_hardpoints", ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUModelHardpoint[] m_hardpoints;

        [STUFieldAttribute(0xCB4D298D, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_2DD96D6D[] m_CB4D298D;

        [STUFieldAttribute(0x8289A6C9, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_548DEE5C[] m_8289A6C9;

        [STUFieldAttribute(0x0C8F8DC6, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_145F0B66[] m_0C8F8DC6;

        [STUFieldAttribute(0xE9A9B868)]
        public teStructuredDataAssetRef<ulong>[] m_E9A9B868;

        [STUFieldAttribute(0x37ED05D0)]
        public teStructuredDataAssetRef<STUModel> m_37ED05D0;

        [STUFieldAttribute(0x7E48C526, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STU_22BD6AAD m_7E48C526;

        [STUFieldAttribute(0x81AF6609)]
        public Enum_950F7205 m_81AF6609;

        [STUFieldAttribute(0x87916047)]
        public Enum_790E517D m_87916047;

        [STUFieldAttribute(0xD64F7813)]
        public byte m_D64F7813;

        [STUFieldAttribute(0xADC54E57)]
        public byte m_ADC54E57;
    }
}