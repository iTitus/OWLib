﻿using System.IO;
using System.Runtime.InteropServices;

namespace OWLib.Types.STUD.Binding {
    [System.Diagnostics.DebuggerDisplay(OWLib.STUD.STUD_DEBUG_STR)]
    public class ChildParameterRecord : ISTUDInstance {
        public uint Id => 0x378F54CD;
        public string Name => "Binding:ChildParameter";

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct ChildParameter {
            public STUDInstanceInfo instance;
            public OWRecord binding;
            public ulong offset;
            public ulong offset2;
            public ulong offset3;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct Child {
            public OWRecord unk1;
            public ulong unk2;
            public ulong unk3;
            public ulong unk4;
            public OWRecord parameter;
        }

        private ChildParameter header;
        private Child[] children;
        public ChildParameter Header => header;
        public Child[] Children => children;

        public void Read(Stream input, OWLib.STUD stud) {
            using (BinaryReader reader = new BinaryReader(input, System.Text.Encoding.Default, true)) {
                header = reader.Read<ChildParameter>();
                if (header.offset > 0) {
                    input.Position = (long)header.offset;
                    STUDArrayInfo ptr = reader.Read<STUDArrayInfo>();
                    children = new Child[ptr.count];
                    input.Position = (long)ptr.offset;
                    for (ulong i = 0; i < ptr.count; ++i) {
                        children[i] = reader.Read<Child>();
                    }
                } else {
                    children = new Child[0];
                }
            }
        }
    }
}
