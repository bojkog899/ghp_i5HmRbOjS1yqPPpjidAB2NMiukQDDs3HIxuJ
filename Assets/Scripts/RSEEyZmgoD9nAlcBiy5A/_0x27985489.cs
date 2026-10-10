using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Win / Lose / Pause cards. The template chrome inside each pop body is switched
// off and an own card is built in its place, so no template label (Score:, Reward:)
// and no sprite-less close button can reach the screen (C.3 / B.1).
public sealed class _0x27985489 : MonoBehaviour
{
    [SerializeField]
    private TMP_FontAsset _font;
    public void _0xa5da216b(RectTransform _0xcf99730d, string _0x101bd917, string _0x51c64a10, string _0x44381664)
    {
        if (_0xcf99730d == null)
        {
            return;
        }

        _0x341165e8.Label(_0xcf99730d, _0xd380ad49._0xea7571f8(new byte[10] { 156, 190, 173, 187, 151, 186, 190, 187, 186, 173 }, 223), _0x101bd917, new Vector2(0.5f, 0.86f), Vector2.zero, new Vector2(860f, 130f), 48f, 86f, _0xf18456f5.Gold, this._font, TextAlignmentOptions.Center);
        _0x341165e8.Label(_0xcf99730d, _0xd380ad49._0xea7571f8(new byte[8] { 69, 103, 116, 98, 68, 105, 98, 127 }, 6), _0x51c64a10, new Vector2(0.5f, 0.73f), Vector2.zero, new Vector2(860f, 110f), 32f, 52f, _0xf18456f5.Paper, this._font, TextAlignmentOptions.Center);
        _0x341165e8.Label(_0xcf99730d, _0xd380ad49._0xea7571f8(new byte[10] { 176, 146, 129, 151, 183, 150, 135, 146, 154, 159 }, 243), _0x44381664, new Vector2(0.5f, 0.575f), Vector2.zero, new Vector2(860f, 220f), 30f, 46f, _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.9f), this._font, TextAlignmentOptions.Center);
    }

    public RectTransform _0x01567c65(_0x8e511e3c _0xd75cfabf, int _0x83eb9bdd)
    {
        if (_0xd75cfabf == null || _0xd75cfabf.Content == null)
        {
            return null;
        }

        RectTransform _0x8db71eea;
        if (this._0xcdde71a3.TryGetValue(_0x83eb9bdd, out _0x8db71eea) && _0x8db71eea != null)
        {
            return _0x8db71eea;
        }

        Transform _0x9e641c22 = _0xd75cfabf.Content.transform;
        for (int _0x792627c6 = _0x9e641c22.childCount - 1; _0x792627c6 >= 0; _0x792627c6--)
        {
            _0x9e641c22.GetChild(_0x792627c6).gameObject.SetActive(false);
        }

        RectTransform _0x72f4456f = _0x341165e8.Node(_0x9e641c22, _0xd380ad49._0xea7571f8(new byte[9] { 229, 222, 215, 208, 194, 245, 215, 196, 210 }, 182), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(980f, 1080f));
        Image _0xc073a9eb = _0x341165e8.Plate(_0x72f4456f, _0xd380ad49._0xea7571f8(new byte[8] { 76, 110, 125, 107, 72, 99, 96, 120 }, 15), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1100f), _0xf18456f5.Alpha(_0xf18456f5.Accent, 0.55f), this._roundPlate);
        _0xc073a9eb.raycastTarget = false;
        Image _0x45cbd085 = _0x341165e8.Plate(_0x72f4456f, _0xd380ad49._0xea7571f8(new byte[8] { 247, 213, 198, 208, 242, 213, 215, 209 }, 180), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(980f, 1080f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.98f), this._roundPlate);
        _0x45cbd085.raycastTarget = true;
        _0x45cbd085.canvasRenderer.cullTransparentMesh = false;
        this._0xcdde71a3[_0x83eb9bdd] = _0x72f4456f;
        return _0x72f4456f;
    }

    public Button _0x36059deb(RectTransform _0xf847971b)
    {
        if (_0xf847971b == null)
        {
            return null;
        }

        return _0x341165e8.IconCta(_0xf847971b, _0xd380ad49._0xea7571f8(new byte[9] { 242, 208, 195, 213, 242, 221, 222, 194, 212 }, 177), this._closeIcon, new Vector2(0.9f, 0.935f), Vector2.zero, new Vector2(104f, 104f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.95f), _0xf18456f5.Alpha(_0xf18456f5.Danger, 0.9f), this._roundPlate);
    }

    // One caption per slot, counted from the top of the action column (C.17).
    public Button _0xe0dafa0b(RectTransform _0x83de9174, int _0x47122670, string _0xeb06f317, Color _0xc24a25f3)
    {
        if (_0x83de9174 == null)
        {
            return null;
        }

        float _0xff609ab8 = 0.37f - (_0x47122670 * 0.145f);
        return _0x341165e8.Cta(_0x83de9174, _0xd380ad49._0xea7571f8(new byte[10] { 138, 168, 187, 173, 136, 170, 189, 160, 166, 167 }, 201) + _0x47122670.ToString(), _0xeb06f317, new Vector2(0.5f, _0xff609ab8), Vector2.zero, new Vector2(700f, 140f), _0xf18456f5.Alpha(_0xf18456f5.Ink, 0.95f), _0xc24a25f3, _0xf18456f5.Paper, 32f, 48f, this._font, this._roundPlate);
    }

    public void _0x28685f10(Sprite _0x879cbc90, Sprite _0x44574d91, TMP_FontAsset _0x787de776)
    {
        this._closeIcon = _0x879cbc90;
        this._roundPlate = _0x44574d91;
        this._font = _0x787de776;
    }

    [SerializeField]
    private Sprite _closeIcon;
    private readonly Dictionary<int, RectTransform> _0xcdde71a3 = new Dictionary<int, RectTransform>();
    [SerializeField]
    private Sprite _roundPlate;
}

internal static class _0xd380ad49
{
    internal static string _0xea7571f8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}