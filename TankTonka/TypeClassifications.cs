﻿namespace TankTonka {
    public static class TypeClassifications {
        public static ushort[] STUv1;
        public static ushort[] STUv2 = {0x3, 0x13, 0x14, 0x15, 0x18, 0x1A, 0x1B, 0x1F, 0x20, 0x21, 0x24, 0x25, 0x2C, 
            0x2D, 0x2E, 0x2F};  // todo
        public static ushort[] Chunked = {0x7, 0xC, 0xD, 0x8E, 0x8F, 0xCB};
        public static ushort[] MapChunk = {0xBC};
    }
}