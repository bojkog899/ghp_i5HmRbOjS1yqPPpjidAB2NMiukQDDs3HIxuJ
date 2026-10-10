using UnityEngine;

// Palette and shared geometry constants for the vertical climb.
// Every colour the game shows comes from here, so the screens read as one world.
public static class _0xf18456f5
{
    public static readonly Color Gold = new Color(0.941176f, 0.768627f, 0.282353f, 1f);
    public const int HazardOrder = -11;
    public const int AimOrder = -6;
    public const int RingOrder = -17;
    public const int LedgeOrder = -14;
    public const int AnchorOrder = -13;
    public static readonly Color Violet = new Color(0.447059f, 0.329412f, 0.827451f, 1f);
    public const int CoreOrder = -8;
    public const int BrakeOrder = -4;
    public static readonly Color Accent = new Color(0.180392f, 0.772549f, 0.898039f, 1f);
    public static readonly Color Danger = new Color(0.941176f, 0.266667f, 0.352941f, 1f);
    public static readonly Color Ink = new Color(0.062745f, 0.082353f, 0.145098f, 1f);
    public static Color Alpha(Color _0x6f10aca3, float _0x60c3706a)
    {
        return new Color(_0x6f10aca3.r, _0x6f10aca3.g, _0x6f10aca3.b, _0x60c3706a);
    }

    public static readonly Color Surface = new Color(0.078431f, 0.101961f, 0.180392f, 1f);
    public static readonly Color InkDeep = new Color(0.039216f, 0.054902f, 0.101961f, 1f);
    public const int BeaconOrder = -12;
    public const int SparkOrder = -3;
    // Sorting band. Named constants only - never a literal at the call site (C.21).
    public const int BackdropOrder = -19;
    public static readonly Color Paper = new Color(0.956863f, 0.945098f, 0.909804f, 1f);
    public const int WallOrder = -16;
}