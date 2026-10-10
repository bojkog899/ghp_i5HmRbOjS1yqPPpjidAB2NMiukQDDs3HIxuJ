using UnityEngine;

// One row per sector of the shaft. Counts come from here (difficulty); the
// POSITIONS always come from the seeded generator (C.11).
public sealed class _0x2b6114b1
{
    public float NarrowestLedge;
    public int Fans;
    public int _0xf5383d4c
    {
        get
        {
            return this.Ledges * _0xe6c2d6f3.MetresPerLedge;
        }
    }

    public float WidestLedge;
    public int Shutters;
    public int Ledges;
    public float RoundSeconds;
    public float RiseStep;
}

public static class _0xe6c2d6f3
{
    public const int MetresPerLedge = 12;
    public const int Count = 5;
    public static _0x2b6114b1 Row(int _0x9efdbcfe)
    {
        return _0xc1986e9a[Mathf.Clamp(_0x9efdbcfe, 0, _0xe6c2d6f3.Count - 1)];
    }

    private static _0x2b6114b1[] Build()
    {
        return new _0x2b6114b1[]
        {
            new _0x2b6114b1
            {
                Ledges = 14,
                WidestLedge = 1.10f,
                NarrowestLedge = 0.95f,
                RiseStep = 1.30f,
                Shutters = 0,
                Fans = 0,
                RoundSeconds = 105f
            },
            new _0x2b6114b1
            {
                Ledges = 18,
                WidestLedge = 1.00f,
                NarrowestLedge = 0.86f,
                RiseStep = 1.34f,
                Shutters = 2,
                Fans = 0,
                RoundSeconds = 105f
            },
            new _0x2b6114b1
            {
                Ledges = 22,
                WidestLedge = 0.92f,
                NarrowestLedge = 0.76f,
                RiseStep = 1.38f,
                Shutters = 3,
                Fans = 1,
                RoundSeconds = 110f
            },
            new _0x2b6114b1
            {
                Ledges = 26,
                WidestLedge = 0.84f,
                NarrowestLedge = 0.68f,
                RiseStep = 1.42f,
                Shutters = 4,
                Fans = 2,
                RoundSeconds = 115f
            },
            new _0x2b6114b1
            {
                Ledges = 30,
                WidestLedge = 0.78f,
                NarrowestLedge = 0.62f,
                RiseStep = 1.46f,
                Shutters = 5,
                Fans = 3,
                RoundSeconds = 120f
            },
        };
    }

    private static readonly _0x2b6114b1[] _0xc1986e9a = _0xe6c2d6f3.Build();
}