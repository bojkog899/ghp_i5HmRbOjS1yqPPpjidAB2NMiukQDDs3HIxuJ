using TMPro;
using UnityEngine;

// Labels built from code never reach stage 5c3 (it reads scenes and prefabs only),
// so every runtime label gets its own material instance with an outline that
// contrasts with its face colour. See CLAUDE-unity.md C.10 / C.14.
public static class _0xba6089da
{
    private static readonly Color _0x6ccbbb0c = _0xf18456f5.InkDeep;
    private static readonly Color _0xf175eb30 = _0xf18456f5.Paper;
    public static void ApplyOutline(TMP_Text _0x2ff29e93)
    {
        if (_0x2ff29e93 == null)
        {
            return;
        }

        Color _0xc802749d = _0x2ff29e93.color;
        float _0xa7a5f414 = (0.299f * _0xc802749d.r) + (0.587f * _0xc802749d.g) + (0.114f * _0xc802749d.b);
        Material _0x69fbfde0 = _0x2ff29e93.fontMaterial;
        if (_0x69fbfde0 == null)
        {
            return;
        }

        _0x69fbfde0.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x69fbfde0.SetColor(ShaderUtilities.ID_OutlineColor, _0xa7a5f414 < 0.5f ? _0xf175eb30 : _0x6ccbbb0c);
        _0x69fbfde0.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.2f);
        _0x69fbfde0.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }
}