using System;

namespace IntrinsicSupport
{
    /// <summary>
    ///     Intrinsic Features
    /// </summary>
    [Flags]
    public enum SuppoprtedFeatures : uint
    {
        Arm = 0,
        X86 = 1,
        Is64Bit = 2,
        AdvSimd = 4,
        Aes = 8,
        Avx = 16,
        Avx2 = 32,
        Bmi1 = 64,
        Bmi2 = 128,
        Crc32 = 256,
        DP = 512,
        Fma = 1024,
        Lzcnt = 2048,
        Rdm = 4096,
        Pclmulqdq = 8192,
        Popcnt = 16384,
        Sha1 = 32768,
        Sha256 = 65536,
        Sse = 131072,
        Sse2 = 262144,
        Sse3 = 524288,
        Sse41 = 1048576,
        Sse42 = 2097152,
        Ssse3 = 4194304
    }

    /// <summary>
    ///     Class for getting the supported Intrinsic Features for the CPU
    /// </summary>
    public static class CpuFeatures
    {
        /// <summary>
        ///     Get's the Supported Features for the CPU
        /// </summary>
        /// <returns></returns>
        public static SuppoprtedFeatures GetSuppoprtedFeatures()
        {
            if (System.Runtime.Intrinsics.Arm.ArmBase.IsSupported)
                return GetArmFeatures();

            return GetX86Features();
        }

        private static SuppoprtedFeatures GetArmFeatures()
        {
            SuppoprtedFeatures cpuFeatures = SuppoprtedFeatures.Arm;

            if (System.Runtime.Intrinsics.Arm.ArmBase.Arm64.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Is64Bit;

            if (System.Runtime.Intrinsics.Arm.AdvSimd.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.AdvSimd;

            if (System.Runtime.Intrinsics.Arm.Aes.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Aes;

            if (System.Runtime.Intrinsics.Arm.Crc32.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Crc32;

            if (System.Runtime.Intrinsics.Arm.Dp.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.DP;

            if (System.Runtime.Intrinsics.Arm.Rdm.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Rdm;

            if (System.Runtime.Intrinsics.Arm.Sha1.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sha1;

            if (System.Runtime.Intrinsics.Arm.Sha256.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sha256;

            return cpuFeatures;
        }

        private static SuppoprtedFeatures GetX86Features()
        {
            SuppoprtedFeatures cpuFeatures = SuppoprtedFeatures.X86;

            if (System.Runtime.Intrinsics.X86.X86Base.X64.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Is64Bit;

            if (System.Runtime.Intrinsics.X86.Aes.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Aes;

            if (System.Runtime.Intrinsics.X86.Avx.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Avx;

            if (System.Runtime.Intrinsics.X86.Avx2.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Avx2;

            if (System.Runtime.Intrinsics.X86.Bmi1.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Bmi1;

            if (System.Runtime.Intrinsics.X86.Bmi2.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Bmi2;

            if (System.Runtime.Intrinsics.X86.Fma.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Bmi2;

            if (System.Runtime.Intrinsics.X86.Lzcnt.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Lzcnt;

            if (System.Runtime.Intrinsics.X86.Pclmulqdq.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Pclmulqdq;

            if (System.Runtime.Intrinsics.X86.Popcnt.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Popcnt;

            if (System.Runtime.Intrinsics.X86.Sse.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sse;

            if (System.Runtime.Intrinsics.X86.Sse2.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sse2;

            if (System.Runtime.Intrinsics.X86.Sse3.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sse3;

            if (System.Runtime.Intrinsics.X86.Sse41.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sse41;

            if (System.Runtime.Intrinsics.X86.Sse42.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Sse42;

            if (System.Runtime.Intrinsics.X86.Ssse3.IsSupported)
                cpuFeatures = cpuFeatures | SuppoprtedFeatures.Ssse3;

            return cpuFeatures;
        }
    }
}
