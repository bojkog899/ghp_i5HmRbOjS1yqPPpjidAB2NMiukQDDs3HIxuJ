using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Readouts for the climb: round clock, altitude against the sector goal, the
// ascent-field ring and the two transient lines (objective, rescue banner).
public sealed class _0xa9ecf821 : MonoBehaviour
{
    private bool _0xd9464cc3;
    [SerializeField]
    private TextMeshProUGUI _fieldCaption;
    public void _0x421ec28d(int _0xdc4d5aa1, int _0xf93056bb)
    {
        if (this._altitude != null)
        {
            this._altitude.text = _0xdc4d5aa1.ToString() + _0xb983afb8._0xdc543c23(new byte[5] { 165, 200, 165, 170, 165 }, 133) + _0xf93056bb.ToString() + _0xb983afb8._0xdc543c23(new byte[2] { 137, 228 }, 169);
        }
    }

    public void _0xe77ae458()
    {
        if (this._altitude != null)
        {
            this._altitude.transform.DOPunchScale(Vector3.one * 0.12f, 0.2f, 5, 0.6f).SetLink(this._altitude.transform.gameObject);
        }
    }

    public void _0x109f48b3(string _0x1640e19d)
    {
        if (this._bannerRoot == null || this._banner == null)
        {
            return;
        }

        this._banner.text = _0x1640e19d;
        this._bannerRoot.gameObject.SetActive(true);
        this._0xb7304db6 = 1.7f;
        this._bannerRoot.localScale = Vector3.one * 0.85f;
        this._bannerRoot.DOScale(1f, 0.25f).SetEase(Ease.OutBack).SetLink(this._bannerRoot.gameObject);
    }

    private float _0xc6137e0b;
    private float _0xb7304db6;
    public void _0x377d335d(Transform _0xb1a166c8, TMP_FontAsset _0x17ce901e, Sprite _0x92500f1d, int _0x9e148aa5)
    {
        this._clock = _0x341165e8.Label(_0xb1a166c8, _0xb983afb8._0xdc543c23(new byte[8] { 30, 57, 34, 15, 32, 35, 47, 39 }, 76), _0xb983afb8._0xdc543c23(new byte[5] { 65, 64, 75, 69, 68 }, 113), new Vector2(0.5f, 0.943f), Vector2.zero, new Vector2(360f, 92f), 40f, 64f, _0xf18456f5.Paper, _0x17ce901e, TextAlignmentOptions.Center);
        this._fieldRing = _0x341165e8.Plate(_0xb1a166c8, _0xb983afb8._0xdc543c23(new byte[10] { 217, 235, 251, 253, 246, 236, 202, 241, 246, 255 }, 152), new Vector2(0.5f, 0.866f), Vector2.zero, new Vector2(240f, 56f), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.85f), _0x92500f1d);
        this._fieldRing.type = Image.Type.Filled;
        this._fieldRing.fillMethod = Image.FillMethod.Horizontal;
        this._fieldRing.fillOrigin = 0;
        this._fieldRing.fillAmount = 1f;
        this._fieldCaption = _0x341165e8.Label(_0xb1a166c8, _0xb983afb8._0xdc543c23(new byte[13] { 171, 153, 137, 143, 132, 158, 169, 139, 154, 158, 131, 133, 132 }, 234), _0xb983afb8._0xdc543c23(new byte[12] { 188, 174, 190, 184, 179, 169, 221, 187, 180, 184, 177, 185 }, 253), new Vector2(0.5f, 0.838f), Vector2.zero, new Vector2(360f, 40f), 24f, 30f, _0xf18456f5.Alpha(_0xf18456f5.Paper, 0.62f), _0x17ce901e, TextAlignmentOptions.Center);
        // Text column starts to the RIGHT of the charge gutter: 550 - 350 = 200 >= 195.
        this._altitude = _0x341165e8.Label(_0xb1a166c8, _0xb983afb8._0xdc543c23(new byte[15] { 122, 87, 79, 82, 79, 78, 95, 94, 105, 94, 90, 95, 84, 78, 79 }, 59), _0xb983afb8._0xdc543c23(new byte[6] { 57, 41, 68, 41, 38, 41 }, 9) + _0x9e148aa5.ToString() + _0xb983afb8._0xdc543c23(new byte[2] { 122, 23 }, 90), new Vector2(550f / _0x341165e8.CanvasWidth, 0.800f), Vector2.zero, new Vector2(700f, 76f), 34f, 56f, _0xf18456f5.Gold, _0x17ce901e, TextAlignmentOptions.Left);
        this._goal = _0x341165e8.Label(_0xb1a166c8, _0xb983afb8._0xdc543c23(new byte[8] { 240, 216, 214, 219, 251, 222, 217, 210 }, 183), _0xb983afb8._0xdc543c23(new byte[6] { 189, 170, 174, 172, 167, 207 }, 239) + _0x9e148aa5.ToString() + _0xb983afb8._0xdc543c23(new byte[2] { 93, 48 }, 125), new Vector2(0.5f, 0.720f), Vector2.zero, new Vector2(820f, 90f), 36f, 58f, _0xf18456f5.Gold, _0x17ce901e, TextAlignmentOptions.Center);
        this._0xc6137e0b = 4f;
        this._bannerRoot = _0x341165e8.Node(_0xb1a166c8, _0xb983afb8._0xdc543c23(new byte[10] { 65, 98, 109, 109, 102, 113, 81, 108, 108, 119 }, 3), new Vector2(0.5f, 0.615f), Vector2.zero, new Vector2(900f, 118f));
        Image _0x32f294bd = _0x341165e8.Plate(this._bannerRoot, _0xb983afb8._0xdc543c23(new byte[11] { 53, 22, 25, 25, 18, 5, 39, 27, 22, 3, 18 }, 119), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 118f), _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.9f), _0x92500f1d);
        _0x32f294bd.raycastTarget = false;
        this._banner = _0x341165e8.Label(this._bannerRoot, _0xb983afb8._0xdc543c23(new byte[10] { 209, 242, 253, 253, 246, 225, 199, 246, 235, 231 }, 147), _0xb983afb8._0xdc543c23(new byte[12] { 184, 175, 185, 169, 191, 175, 202, 186, 191, 166, 185, 175 }, 234), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(840f, 100f), 36f, 60f, _0xf18456f5.Paper, _0x17ce901e, TextAlignmentOptions.Center);
        this._banner.transform.SetAsLastSibling();
        this._bannerRoot.gameObject.SetActive(false);
    }

    public void _0x6571a259(float deltaTime)
    {
        if (this._0xc6137e0b > 0f)
        {
            this._0xc6137e0b -= deltaTime;
            if (this._0xc6137e0b <= 0f && this._goal != null)
            {
                this._goal.gameObject.SetActive(false);
            }
        }

        if (this._0xb7304db6 > 0f)
        {
            this._0xb7304db6 -= deltaTime;
            if (this._0xb7304db6 <= 0f && this._bannerRoot != null)
            {
                this._bannerRoot.gameObject.SetActive(false);
            }
        }
    }

    [SerializeField]
    private TextMeshProUGUI _clock;
    [SerializeField]
    private TextMeshProUGUI _goal;
    [SerializeField]
    private TextMeshProUGUI _banner;
    [SerializeField]
    private RectTransform _bannerRoot;
    [SerializeField]
    private Image _fieldRing;
    public void _0x3f731ae8(float _0x3d62fd94)
    {
        if (this._fieldRing == null)
        {
            return;
        }

        float _0xd796f127 = Mathf.Clamp01(_0x3d62fd94);
        this._fieldRing.fillAmount = _0xd796f127;
        this._fieldRing.color = _0xd796f127 < 0.15f ? _0xf18456f5.Alpha(_0xf18456f5.Danger, 0.9f) : _0xf18456f5.Alpha(_0xf18456f5.Violet, 0.85f);
        if (this._fieldCaption != null && _0xd796f127 <= 0f)
        {
            this._fieldCaption.text = _0xb983afb8._0xdc543c23(new byte[12] { 101, 106, 102, 111, 103, 3, 96, 111, 108, 112, 102, 103 }, 35);
        }
    }

    [SerializeField]
    private TextMeshProUGUI _altitude;
    public void _0x6d415f1c(float _0x03da8f86)
    {
        if (this._clock == null)
        {
            return;
        }

        int _0xa613f2a1 = Mathf.Max(0, Mathf.CeilToInt(_0x03da8f86));
        int _0x7131b8df = _0xa613f2a1 / 60;
        int _0x013b5924 = _0xa613f2a1 % 60;
        this._clock.text = _0x7131b8df.ToString(_0xb983afb8._0xdc543c23(new byte[2] { 103, 103 }, 87)) + _0xb983afb8._0xdc543c23(new byte[1] { 53 }, 15) + _0x013b5924.ToString(_0xb983afb8._0xdc543c23(new byte[2] { 87, 87 }, 103));
        bool _0x5fdf697d = _0x03da8f86 <= 15f;
        if (_0x5fdf697d == this._0xd9464cc3)
        {
            return;
        }

        this._0xd9464cc3 = _0x5fdf697d;
        this._clock.color = _0x5fdf697d ? _0xf18456f5.Danger : _0xf18456f5.Paper;
        if (_0x5fdf697d)
        {
            this._clock.transform.DOPunchScale(Vector3.one * 0.1f, 0.4f, 6, 0.6f).SetLink(this._clock.transform.gameObject);
        }
    }
}

internal static class _0xb983afb8
{
    internal static string _0xdc543c23(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}