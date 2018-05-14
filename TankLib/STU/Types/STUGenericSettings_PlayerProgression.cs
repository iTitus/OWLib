// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x33597A76, "STUGenericSettings_PlayerProgression")]
    public class STUGenericSettings_PlayerProgression : STUGenericSettings_Base {
        [STUFieldAttribute(0x5C57AB57, "m_otherUnlocks", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUUnlocks m_otherUnlocks;

        [STUFieldAttribute(0x7160F769)]
        public teStructuredDataAssetRef<STUUnlock>[] m_7160F769;

        [STUFieldAttribute(0x2DC24372, "m_lootBoxCelebrationOverrides", ReaderType = typeof(InlineInstanceFieldReader))]
        public STULootBoxCelebrationOverride[] m_lootBoxCelebrationOverrides;

        [STUFieldAttribute(0x52B28679, "m_rulesetWinRewards", ReaderType = typeof(InlineInstanceFieldReader))]
        public STURulesetWinReward[] m_rulesetWinRewards;

        [STUFieldAttribute(0xAE517B51, "m_additionalUnlocks", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAdditionalUnlocks[] m_additionalUnlocks;

        [STUFieldAttribute(0xB772FEE7, "m_lootBoxesUnlocks", ReaderType = typeof(InlineInstanceFieldReader))]
        public STULootBoxUnlocks[] m_lootBoxesUnlocks;

        [STUFieldAttribute(0x08C102FE, "m_lootBoxesCurrencyUnlocks", ReaderType = typeof(InlineInstanceFieldReader))]
        public STULootBoxCurrencyUnlocks[] m_lootBoxesCurrencyUnlocks;

        [STUFieldAttribute(0x15D3515D)]
        public ulong[] m_15D3515D;

        [STUFieldAttribute(0xDA56339E)]
        public int m_DA56339E;

        [STUFieldAttribute(0xC2F7F550)]
        public uint m_C2F7F550;
    }
}
