using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// One sector row. The altitude pips live in their own gutter and the three text
// lines start to the right of it, so nothing overlaps (C.25).
public sealed class _0x98bb2d26 : MonoBehaviour
{
    private const float TextLeft = 140f;
    [SerializeField]
    private TextMeshProUGUI _goalLine;
    public void _0x2f8aa4af(bool _0x6b196c42)
    {
        this._0xbe6525db = _0x6b196c42;
        _0x2b6114b1 _0xa6e86bd3 = _0xe6c2d6f3.Row(this._0x7d43c9a1);
        int _0xf22c1c6f = _0x69baa7e4.BestFor(this._0x7d43c9a1);
        this._goalLine.text = _0x343c0d5b._0x5161c151(new byte[5] { 49, 57, 55, 58, 86 }, 118) + _0xa6e86bd3._0xf5383d4c.ToString() + _0x343c0d5b._0x5161c151(new byte[2] { 142, 227 }, 174);
        if (_0x6b196c42)
        {
            this._bestLine.text = _0x343c0d5b._0x5161c151(new byte[22] { 52, 55, 59, 51, 61, 60, 88, 85, 88, 59, 52, 61, 57, 42, 88, 43, 61, 59, 44, 55, 42, 88 }, 120) + this._0x7d43c9a1.ToString();
        }
        else
        {
            this._bestLine.text = _0xf22c1c6f > 0 ? _0x343c0d5b._0x5161c151(new byte[5] { 9, 14, 24, 31, 107 }, 75) + _0xf22c1c6f.ToString() + _0x343c0d5b._0x5161c151(new byte[2] { 78, 35 }, 110) : _0x343c0d5b._0x5161c151(new byte[6] { 28, 27, 13, 10, 126, 115 }, 94);
        }

        if (this._lockBadge != null)
        {
            this._lockBadge.gameObject.SetActive(_0x6b196c42);
        }

        float _0xc8795714 = _0xa6e86bd3._0xf5383d4c <= 0 ? 0f : Mathf.Clamp01((float)_0xf22c1c6f / _0xa6e86bd3._0xf5383d4c);
        int _0x9c8cda9e = Mathf.RoundToInt(_0xc8795714 * 4f);
        for (int _0x20ef3f11 = 0; _0x20ef3f11 < this._pips.Length; _0x20ef3f11++)
        {
            if (this._pips[_0x20ef3f11] == null)
            {
                continue;
            }

            this._pips[_0x20ef3f11].gameObject.SetActive(!_0x6b196c42);
            this._pips[_0x20ef3f11].color = _0x20ef3f11 < _0x9c8cda9e ? _0xf18456f5.Gold : _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.22f);
        }

        this._0xad41c884(false);
    }

    private const float TextWidth = 820f;
    [SerializeField]
    private TextMeshProUGUI _nameLine;
    public bool _0x594dc1a0
    {
        get
        {
            return this._0xbe6525db;
        }
    }

    public void _0xf384ccff()
    {
        if (this._edge != null)
        {
            DOTween.Kill(this._edge, true);
            this._edge.color = _0xf18456f5.Danger;
            this._edge.DOColor(_0xf18456f5.Alpha(_0xf18456f5.Paper, 0.25f), 0.45f).SetLink(this._edge.gameObject);
        }

        this.transform.DOShakePosition(0.3f, new Vector3(18f, 0f, 0f), 14, 90f).SetLink(this.gameObject);
    }

    public int _0x09252f31
    {
        get
        {
            return this._0x7d43c9a1;
        }
    }

    private const float GutterWidth = 44f;
    [SerializeField]
    private Image _lockBadge;
    private const float CardHeight = 236f;
    public void _0xad41c884(bool _0xdc68f57c)
    {
        if (this._edge == null)
        {
            return;
        }

        if (this._0xbe6525db)
        {
            this._edge.color = _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.25f);
            return;
        }

        this._edge.color = _0xdc68f57c ? _0xf18456f5.Accent : _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.75f);
    }

    public void _0x444a7f02(RectTransform _0xf3356b6e, int _0x78fe9cfd, Sprite _0x59aab00c, Sprite _0x3f6eff3f, TMP_FontAsset _0x5e93f938, Sprite _0xb8d38d71)
    {
        this._0x7d43c9a1 = _0x78fe9cfd;
        float _0xfff8d008 = GutterCentre - (CardWidth * 0.5f);
        float _0xc0c0d371 = (TextLeft + (TextWidth * 0.5f)) - (CardWidth * 0.5f);
        this._edge = _0x341165e8.Plate(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[8] { 81, 115, 96, 118, 87, 118, 117, 119 }, 18), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth, CardHeight), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.75f), _0xb8d38d71);
        Image _0xfa25e596 = _0x341165e8.Plate(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[8] { 190, 156, 143, 153, 191, 146, 153, 132 }, 253), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 8f, CardHeight - 8f), _0xf18456f5.Alpha(_0xf18456f5.Surface, 0.96f), _0xb8d38d71);
        _0xfa25e596.raycastTarget = true;
        _0xfa25e596.canvasRenderer.cullTransparentMesh = false;
        this._pips = new Image[4];
        for (int _0x0c8ec7dd = 0; _0x0c8ec7dd < 4; _0x0c8ec7dd++)
        {
            this._pips[_0x0c8ec7dd] = _0x341165e8.Picture(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[9] { 38, 16, 22, 1, 26, 7, 37, 28, 5 }, 117) + _0x0c8ec7dd.ToString(), _0x59aab00c, new Vector2(0.5f, 0.5f), new Vector2(_0xfff8d008, 72f - (_0x0c8ec7dd * 48f)), new Vector2(36f, 36f));
        }

        this._lockBadge = _0x341165e8.Picture(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[10] { 79, 121, 127, 104, 115, 110, 80, 115, 127, 119 }, 28), _0x3f6eff3f, new Vector2(0.5f, 0.5f), new Vector2(_0xfff8d008, -56f), new Vector2(GutterWidth + 18f, GutterWidth + 18f));
        this._nameLine = _0x341165e8.Label(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[10] { 131, 181, 179, 164, 191, 162, 158, 177, 189, 181 }, 208), _0x343c0d5b._0x5161c151(new byte[7] { 64, 86, 80, 71, 92, 65, 51 }, 19) + (_0x78fe9cfd + 1).ToString(), new Vector2(0.5f, 0.5f), new Vector2(_0xc0c0d371, 50f), new Vector2(TextWidth, 56f), 34f, 48f, _0xf18456f5.Paper, _0x5e93f938, TextAlignmentOptions.Left);
        this._goalLine = _0x341165e8.Label(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[10] { 127, 73, 79, 88, 67, 94, 107, 67, 77, 64 }, 44), _0x343c0d5b._0x5161c151(new byte[4] { 237, 229, 235, 230 }, 170), new Vector2(0.5f, 0.5f), new Vector2(_0xc0c0d371, -10f), new Vector2(TextWidth, 46f), 26f, 36f, _0xf18456f5.Gold, _0x5e93f938, TextAlignmentOptions.Left);
        this._bestLine = _0x341165e8.Label(_0xf3356b6e, _0x343c0d5b._0x5161c151(new byte[10] { 163, 149, 147, 132, 159, 130, 178, 149, 131, 132 }, 240), _0x343c0d5b._0x5161c151(new byte[4] { 115, 116, 98, 101 }, 49), new Vector2(0.5f, 0.5f), new Vector2(_0xc0c0d371, -66f), new Vector2(TextWidth, 46f), 26f, 36f, _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.72f), _0x5e93f938, TextAlignmentOptions.Left);
    }

    private bool _0xbe6525db;
    private int _0x7d43c9a1;
    private const float CardWidth = 1040f;
    [SerializeField]
    private Image[] _pips;
    [SerializeField]
    private Image _edge;
    private const float GutterCentre = 72f;
    public void _0x3f3b9156()
    {
        this.transform.DOPunchScale(Vector3.one * 0.03f, 0.25f, 6, 0.6f).SetLink(this.gameObject);
    }

    [SerializeField]
    private TextMeshProUGUI _bestLine;
}

internal static class _0x343c0d5b
{
    internal static string _0x5161c151(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}