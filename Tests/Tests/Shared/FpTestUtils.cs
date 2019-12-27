using NUnit.Framework;

namespace Unity.Mathematics.FixedPoint.Tests
{
    partial class TestUtils
    {
        public static void AreEqual(fp a, fp b, fp delta = default)
        {
            Assert.AreEqual((double)a, (double)b, (double)delta);
        }

        public static void AreEqual(double a, double b, long maxUlp, bool signedZeroEqual)
        {
            if (signedZeroEqual && a == b)
                return;

            if (math.isfinite(a) && math.isfinite(b))
            {
                long la = math.aslong(a);
                long lb = math.aslong(b);
                if ((la ^ lb) < 0)
                    Assert.AreEqual(true, false);
                long ulps = math.abs(la - lb);
                Assert.AreEqual(true, ulps <= maxUlp, "ulps: " + ulps);
            }
            else
            {
                if (a != b && (!math.isnan(a) || !math.isnan(b)))
                    Assert.AreEqual(true, false);
            }
        }

        public static void AreEqual(fp a, fp b, long maxUlp, bool signedZeroEqual)
        {
            try
            {
                AreEqual((double)a, (double)b, maxUlp, signedZeroEqual);
            }
            catch (System.Exception e)
            {
                throw new System.AggregateException($"{a} == {b}", e);
            }
        }
        
        // fp
        public static void AreEqual(fp2 a, fp2 b, fp delta = default)
        {
            AreEqual(a.x, b.x, delta);
            AreEqual(a.y, b.y, delta);
        }

        public static void AreEqual(fp2 a, fp2 b, long maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.x, b.x, maxUlp, signedZeroEqual);
            AreEqual(a.y, b.y, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp3 a, fp3 b, fp delta = default)
        {
            AreEqual(a.x, b.x, delta);
            AreEqual(a.y, b.y, delta);
            AreEqual(a.z, b.z, delta);
        }

        public static void AreEqual(fp3 a, fp3 b, long maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.x, b.x, maxUlp, signedZeroEqual);
            AreEqual(a.y, b.y, maxUlp, signedZeroEqual);
            AreEqual(a.z, b.z, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp4 a, fp4 b, fp delta = default)
        {
            AreEqual(a.x, b.x, delta);
            AreEqual(a.y, b.y, delta);
            AreEqual(a.z, b.z, delta);
            AreEqual(a.w, b.w, delta);
        }

        public static void AreEqual(fp4 a, fp4 b, long maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.x, b.x, maxUlp, signedZeroEqual);
            AreEqual(a.y, b.y, maxUlp, signedZeroEqual);
            AreEqual(a.z, b.z, maxUlp, signedZeroEqual);
            AreEqual(a.w, b.w, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(fp2x2 a, fp2x2 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(fp2x2 a, fp2x2 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp3x2 a, fp3x2 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(fp3x2 a, fp3x2 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp4x2 a, fp4x2 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(fp4x2 a, fp4x2 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(fp2x3 a, fp2x3 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(fp2x3 a, fp2x3 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
            AreEqual(a.c2, b.c2, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp3x3 a, fp3x3 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(fp3x3 a, fp3x3 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
            AreEqual(a.c2, b.c2, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp4x3 a, fp4x3 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(fp4x3 a, fp4x3 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
            AreEqual(a.c2, b.c2, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(fp2x4 a, fp2x4 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(fp2x4 a, fp2x4 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
            AreEqual(a.c2, b.c2, maxUlp, signedZeroEqual);
            AreEqual(a.c3, b.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp3x4 a, fp3x4 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(fp3x4 a, fp3x4 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
            AreEqual(a.c2, b.c2, maxUlp, signedZeroEqual);
            AreEqual(a.c3, b.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(fp4x4 a, fp4x4 b, fp delta = default)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(fp4x4 a, fp4x4 b, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(a.c0, b.c0, maxUlp, signedZeroEqual);
            AreEqual(a.c1, b.c1, maxUlp, signedZeroEqual);
            AreEqual(a.c2, b.c2, maxUlp, signedZeroEqual);
            AreEqual(a.c3, b.c3, maxUlp, signedZeroEqual);
        }
    }
}
