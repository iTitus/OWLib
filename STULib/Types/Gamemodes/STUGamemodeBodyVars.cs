// File auto generated by STUHashTool

using STULib.Types.Gamemodes.Unknown;
using STULib.Types.Generic;

namespace STULib.Types.Gamemodes {
    [STU(0x57AEDFA2, "STUGameModeBodyVars")]
    public class STUGamemodeBodyVars : Common.STUInstance {
        [STUField(0x5C307091)]
        public STUGamemodeVarValuePair[] m_5C307091;

        [STUField(0x37AB13D3, "m_hero", EmbeddedInstance = true)]
        public STUBrawlHeroContainer Hero;
    }
}
