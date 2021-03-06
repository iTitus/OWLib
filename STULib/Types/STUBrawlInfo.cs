// File auto generated by STUHashTool

using STULib.Types.Dump.Enums;
using STULib.Types.Generic;

namespace STULib.Types {
    [STU(0x2E1A0A0B)]
    public class STUBrawlInfo : Common.STUInstance {
        [STUField(0xEB4F2408, "m_gamemode")]
        public Common.STUGUID Gamemode;  // STULib.Types.STUGamemode

        [STUField(0x3CE93B76)]
        public STUGamemodeVarValuePair[] Virtual1;

        [STUField(0xAD4BF17F)]
        public STUGamemodeVarValuePair[] Virtual2;

        [STUField(0xD440A0F7)]
        public STUBrawlTeam[] TeamConfig;

        [STUField(0xDB2577DB)]
        public STUEnum_56DF3C94[] UnknownEnum;

        [STUField(0xCA7E6EDC, "m_description")]
        public Common.STUGUID Description;
    }
}
