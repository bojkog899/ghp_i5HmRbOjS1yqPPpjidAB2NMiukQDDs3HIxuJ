using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x12206869 : MonoBehaviour
{
    private readonly List<TMP_Text> _0x25a0faf8 = new List<TMP_Text>();
    private static void Fix(TMP_Text _0x842be6ab)
    {
        if (_0x842be6ab == null || !_0x842be6ab.isActiveAndEnabled)
            return;
        Material _0xa9ede8d2 = _0x842be6ab.fontSharedMaterial;
        if (_0xa9ede8d2 == null || !_0xa9ede8d2.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xa9ede8d2.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xa9ede8d2.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xaf9872af = _0x842be6ab.color;
        if (_0xaf9872af.a <= 0f)
            return;
        Color _0xddc98fa1 = _0xa9ede8d2.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xaf9872af, _0xddc98fa1) >= MinRatio)
            return;
        Color _0x2e01a08f = Luminance(_0xddc98fa1) < 0.5f ? Color.white : Color.black;
        Color _0xa4b8fbe8;
        if (Ratio(_0x2e01a08f, _0xddc98fa1) < TargetRatio)
        {
            _0xa4b8fbe8 = _0x2e01a08f;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x4272e2bf = 0f;
            float _0x4e683ac4 = 1f;
            for (int _0x965a2713 = 0; _0x965a2713 < 20; _0x965a2713++)
            {
                float _0x147c1cac = (_0x4272e2bf + _0x4e683ac4) * 0.5f;
                if (Ratio(Color.Lerp(_0xaf9872af, _0x2e01a08f, _0x147c1cac), _0xddc98fa1) >= TargetRatio)
                    _0x4e683ac4 = _0x147c1cac;
                else
                    _0x4272e2bf = _0x147c1cac;
            }

            _0xa4b8fbe8 = Color.Lerp(_0xaf9872af, _0x2e01a08f, _0x4e683ac4);
        }

        _0xa4b8fbe8.a = _0xaf9872af.a;
        _0x842be6ab.color = _0xa4b8fbe8;
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xbef012da)
    {
        return 0.2126f * Linear(_0xbef012da.r) + 0.7152f * Linear(_0xbef012da.g) + 0.0722f * Linear(_0xbef012da.b);
    }

    private void LateUpdate()
    {
        if (this._0x4d33d3f1.Count == 0)
            return;
        this._0x25a0faf8.Clear();
        this._0x25a0faf8.AddRange(this._0x4d33d3f1);
        this._0x4d33d3f1.Clear();
        for (int _0x78a77c18 = 0; _0x78a77c18 < this._0x25a0faf8.Count; _0x78a77c18++)
            Fix(this._0x25a0faf8[_0x78a77c18]);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xf72152a0 != null)
            return;
        GameObject _0xae68dfc0 = new GameObject(_0x0a53b171._0xecf0a9ce(new byte[16] { 3, 58, 39, 20, 56, 57, 35, 37, 54, 36, 35, 16, 34, 54, 37, 51 }, 87));
        _0xae68dfc0.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xae68dfc0);
        _0xf72152a0 = _0xae68dfc0.AddComponent<_0x12206869>();
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xe68a3bee;
    private const float TargetRatio = 7f;
    private readonly HashSet<TMP_Text> _0x4d33d3f1 = new HashSet<TMP_Text>();
    private static _0x12206869 _0xf72152a0;
    private static float Ratio(Color _0x10920c06, Color _0xada35882)
    {
        float _0xc37f46c0 = Luminance(_0x10920c06);
        float _0x2571a482 = Luminance(_0xada35882);
        return (Mathf.Max(_0xc37f46c0, _0x2571a482) + 0.05f) / (Mathf.Min(_0xc37f46c0, _0x2571a482) + 0.05f);
    }

    private const float MinRatio = 4.5f;
    private void OnEnable()
    {
        if (this._0xe68a3bee == null)
            this._0xe68a3bee = _0xa20a9248 => this._0x845988e7(_0xa20a9248);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xe68a3bee);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x845988e7(Object _0x4abdb22b)
    {
        TMP_Text _0xbb5b7201 = _0x4abdb22b as TMP_Text;
        if (_0xbb5b7201 != null)
            this._0x4d33d3f1.Add(_0xbb5b7201);
    }

    private const float MinOutlineWidth = 0.01f;
    private static float Linear(float _0xca67495a)
    {
        _0xca67495a = Mathf.Clamp01(_0xca67495a);
        return _0xca67495a <= 0.03928f ? _0xca67495a / 12.92f : Mathf.Pow((_0xca67495a + 0.055f) / 1.055f, 2.4f);
    }

    private void OnDisable()
    {
        if (this._0xe68a3bee != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xe68a3bee);
    }
}

internal static class _0x0a53b171
{
    internal static string _0xecf0a9ce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}