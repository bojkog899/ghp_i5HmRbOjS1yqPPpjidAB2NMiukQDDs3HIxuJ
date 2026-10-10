using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Three fall charges in their own gutter on the left. The gutter never shares an
// x-band with the altitude readout (C.25).
public sealed class _0x4e779dfa : MonoBehaviour
{
    public const float GutterWidth = 150f;
    public void _0xb7f1d900(Transform _0xc7344bff, Sprite _0xdf094be3, TMP_FontAsset _0xc25a754c, int _0x6101b582)
    {
        this._pips = new Image[_0x6101b582];
        float _0xccedcc13 = GutterCentreX / _0x341165e8.CanvasWidth;
        for (int _0x81238f0a = 0; _0x81238f0a < _0x6101b582; _0x81238f0a++)
        {
            Vector2 _0x36f5ef31 = new Vector2(_0xccedcc13, TopAnchorY - (_0x81238f0a * StepY));
            Image _0xc17c47d3 = _0x341165e8.Picture(_0xc7344bff, _0xcf1630ac._0x5e8c71eb(new byte[9] { 237, 198, 207, 220, 201, 203, 254, 199, 222 }, 174) + _0x81238f0a.ToString(), _0xdf094be3, _0x36f5ef31, Vector2.zero, new Vector2(48f, 48f));
            this._pips[_0x81238f0a] = _0xc17c47d3;
        }

        this._caption = _0x341165e8.Label(_0xc7344bff, _0xcf1630ac._0x5e8c71eb(new byte[13] { 24, 51, 58, 41, 60, 62, 24, 58, 43, 47, 50, 52, 53 }, 91), _0xcf1630ac._0x5e8c71eb(new byte[5] { 151, 144, 157, 157, 130 }, 209), new Vector2(_0xccedcc13, TopAnchorY - (_0x6101b582 * StepY) - 0.006f), Vector2.zero, new Vector2(170f, 40f), 24f, 30f, _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.62f), _0xc25a754c, TextAlignmentOptions.Center);
    }

    public void _0x08718919(int _0xbccfcad1)
    {
        if (this._pips == null)
        {
            return;
        }

        for (int _0xb08dfed6 = 0; _0xb08dfed6 < this._pips.Length; _0xb08dfed6++)
        {
            if (this._pips[_0xb08dfed6] == null)
            {
                continue;
            }

            bool _0x26b4fd8b = _0xb08dfed6 < _0xbccfcad1;
            this._pips[_0xb08dfed6].color = _0x26b4fd8b ? _0xf18456f5.Accent : _0xf18456f5.Alpha(_0xf18456f5.Danger, 0.35f);
        }
    }

    [SerializeField]
    private Image[] _pips;
    [SerializeField]
    private TextMeshProUGUI _caption;
    private const float TopAnchorY = 0.800f;
    private const float StepY = 62f / 2688f;
    public const float GutterCentreX = 96f;
}

internal static class _0xcf1630ac
{
    internal static string _0x5e8c71eb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}