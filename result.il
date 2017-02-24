.assembly program
{
}
.class public Program
{.field private static int32 a
.field private static int32 b
.field private static int32 i
.field private static int32 j
.field private static int32 k
.field private static bool c

  .method public static void main() cil managed {
    .entrypoint
    .locals init (
      [0] int32,
      [1] bool 
    )
    L_000000: ldc.i4 6
    L_000001: stloc 0
    L_000002: ldc.i4 1
    L_000003: stloc 1
    L_000004: ldc.i4 3
    L_000005: stsfld     int32 Program::a
    L_000006: ldc.i4 1
    L_000007: stsfld     int32 Program::i
    L_000008: br L_000015
    L_000009: ldc.i4 1
    L_000010: call void [mscorlib]System.Console::WriteLine(bool)
    L_000011: ldloc 4
    L_000012: ldc.i4 1
    L_000013: add
    L_000014: stloc 4
    L_000015: ldloc 4
    L_000016: ldc.i4 10
    L_000017: cgt
    L_000018: ldc.i4 0
    L_000019: ceq
    L_000020: brtrue L_000009
    L_000021: ret
  }

  .method public static int32 max2(int32 a , int32 b) cil managed {

    .locals init (
      [0] int32,
      [1] int32 
    )
    L_000000: ldarg 0
    L_000001: ldarg 1
    L_000002: cgt
    L_000003: brfalse L_000007
    L_000004: ldarg 0
    L_000005: stloc 0
    L_000006: br L_000009
    L_000007: ldarg 1
    L_000008: stloc 0
    L_000009: ldloc 0
    L_000010: ret
  }

  .method public static int32 max3(int32 a , int32 b , int32 g) cil managed {

    .locals init (
      [0] int32,
      [1] int32 
    )
    L_000000: ldarg 0
    L_000001: ldarg 2
    L_000002:  call       int32 Program::max2(int32, int32)
    L_000003: ldarg 1
    L_000004:  call       int32 Program::max2(int32, int32)
    L_000005: stloc 0
    L_000006: ldloc 0
    L_000007: ret
  }
}
